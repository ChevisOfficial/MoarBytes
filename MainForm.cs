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
        private BigInteger fSize;
        public MainForm()
        {
            InitializeComponent();
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
                }
            }
        }

        private string GetFriendlySize(BigInteger bytes)
        {
            string[] suffixes = { "Б", "КБ", "МБ", "ГБ" };
            int order = 0;

            while (bytes >= 1024 && order < suffixes.Length - 1)
            {
                bytes /= 1024;
                order++;
            }
            

            return $"{bytes:0.##} {suffixes[order]}";
        }

        private BigInteger GetFileSize(Uri uriPath)
        {
            var webRequest = WebRequest.Create(uriPath);
            webRequest.Method = "HEAD";
            using (var webResponse = webRequest.GetResponse())
                return BigInteger.Parse(webResponse.Headers.Get("Content-Length"));
        }

        private BigInteger GetMoarSize() => (BigInteger)CountMb.Value * 1024 * 1024;

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
            if(!string.IsNullOrEmpty(fPath))
                OutputSizeLabel.Text = $"Выходной размер: {GetFriendlySize(fSize + GetMoarSize())}";
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
                    
                    FileNameLabel.Text = $"Файл: Не выбран";
                    FileNameLabel.ForeColor = Color.Red;

                    FileSizeLabel.Text = $"Размер файла: -";
                    OutputSizeLabel.Text = $"Выходной размер: -";

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
