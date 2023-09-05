using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Numerics;
using System.Diagnostics;

namespace MoarBytes
{
    public partial class MainForm : Form
    {
        private string fPath;
        private BigInteger fSize, mLeft;
        public MainForm()
        {
            InitializeComponent();
            TypeBytes.SelectedIndex = 2;
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fPath = fileDialog.FileName;
                    fSize = GetFileSize(new Uri(fPath));


                    FileNameLabel.Text = $"Файл: {fileDialog.SafeFileName}";
                    FileNameLabel.ForeColor = Color.Green;

                    FileSizeLabel.Text = $"Размер файла: {GetFriendlySize(fSize)}";
                    OutputSizeLabel.Text = $"Выходной размер: {GetFriendlySize(fSize + GetMoarSize())}";

                    UpdateDriveInfo();
                }
            }
        }

        private string GetFriendlySize(BigInteger bytes)
        {
            bytes = bytes < 0 ? -bytes : bytes;
            string[] suffixes = { "Б", "КБ", "МБ", "ГБ" };
            int order = 0;

            if (bytes < (BigInteger)2 * 1024 * 1024 * 1024)
            {
                decimal rationalBytes = (decimal)bytes;
                while (rationalBytes >= 1024 && order < suffixes.Length - 1)
                {
                    rationalBytes /= 1024;
                    order++;
                }
                return $"{rationalBytes:0.##} {suffixes[order]}";
            }
            else
            {
                while (bytes >= 1024 && order < suffixes.Length - 1)
                {
                    bytes /= 1024;
                    order++;
                }
                return $"{bytes:0.##} {suffixes[order]}";
            }
        }

        private void UpdateDriveInfo()
        {
            var driveLetter = Path.GetPathRoot(fPath);
            var drive = new DriveInfo(driveLetter);

            OutputSizeLabel.Text = $"Выходной размер: {GetFriendlySize(fSize + GetMoarSize())}";
            DriveLabel.Text = $"Том: \"{driveLetter[0]}\"";
            TotalMemLabel.Text = $"Всего: {GetFriendlySize(drive.TotalSize)}";
            FreeMemLabel.Text = $"Свободно: {GetFriendlySize(drive.AvailableFreeSpace)}";

            mLeft = drive.AvailableFreeSpace - (fSize + GetMoarSize());
            if (mLeft < 0)
            {
                LeftMemLabel.Text = $"Останется: -{GetFriendlySize(mLeft)}";
                LeftMemLabel.ForeColor = Color.Red;
            }
            else
            {
                LeftMemLabel.Text = $"Останется: {GetFriendlySize(mLeft)}";
                LeftMemLabel.ForeColor = Color.Blue;
            }
        }

        private BigInteger GetFileSize(Uri uriPath)
        {
            var webRequest = WebRequest.Create(uriPath);
            webRequest.Method = "HEAD";
            using (var webResponse = webRequest.GetResponse())
                return BigInteger.Parse(webResponse.Headers.Get("Content-Length"));
        }

        private BigInteger GetMoarSize() => (BigInteger)(CountBytes.Value * (decimal)Math.Pow(1024, TypeBytes.SelectedIndex));

        private void RunProcess(string name, string arguments)
        {
            Process process = new Process();
            ProcessStartInfo processInfo = new ProcessStartInfo
            {

                FileName = name,
                Arguments = arguments,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            process.StartInfo = processInfo;
            process.Start();
            process.WaitForExit();
        }


        private string GetFileNameWithMoared()
        {
            string directory = Path.GetDirectoryName(fPath);
            string fileName = Path.GetFileNameWithoutExtension(fPath);
            string fileExtension = Path.GetExtension(fPath);
            return Path.Combine(directory, $"{fileName}_moared{fileExtension}");
        }

        private void CountMb_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fPath))
            {
                UpdateDriveInfo();
            }
        }

        private void TypeBytes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fPath))
            {
                UpdateDriveInfo();
            }
        }
         private void SaveFile_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(fPath))
                {
                    MessageBox.Show("Файл не выбран");
                    return;
                }

                if(!File.Exists(fPath))
                {
                    MessageBox.Show("Файл не существует");
                    
                    FileNameLabel.Text = "Файл: Не выбран";
                    FileNameLabel.ForeColor = Color.Red;

                    FileSizeLabel.Text = "Размер файла: -";
                    OutputSizeLabel.Text = "Выходной размер: -";

                    DriveLabel.Text = "Том: -";
                    TotalMemLabel.Text = "Всего: -";
                    FreeMemLabel.Text = "Свободно: -";
                    
                    LeftMemLabel.Text = "Останется: -";
                    LeftMemLabel.ForeColor = Color.Blue;

                    fPath = string.Empty;
                    return;
                }

                if(mLeft <= 0)
                {
                    MessageBox.Show("Нельзя создать файл, так как его размер в сумме с размерами других файлов превышает объем свободного пространства на томе");
                    return;
                }

                string fileMoared = GetFileNameWithMoared();
                if (File.Exists(fileMoared))
                    File.Delete(fileMoared);
                File.Copy(fPath, fileMoared);
                RunProcess("fsutil", $"file seteof \"{fileMoared}\" {GetMoarSize() + fSize}");

                if (GetFileSize(new Uri(fileMoared)) != GetMoarSize() + fSize)
                {
                    if (File.Exists(fileMoared))
                        File.Delete(fileMoared);
                    MessageBox.Show("Увеличение размера файле не произошло");
                }
                else
                    RunProcess("explorer", $"/e, /select, \"{fileMoared}\"");
            }
            catch(IOException)
            {
                MessageBox.Show("Файл используется другим процессом");
            }
        }

    }
}
