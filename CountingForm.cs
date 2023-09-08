using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace MoarBytes
{
    public partial class CountingForm : Form
    {
        public BigInteger fileByteSum = 0, fileRealBytes = 0;
        private Thread _thread;
        public CountingForm()
        {
            InitializeComponent();
            ControlBox = false;
            CheckForIllegalCrossThreadCalls = false;

            _thread = new Thread(() =>
            {
                CountingLabel.Text = "Подсчёт контрольной суммы...";
                NullMoarBar.Value = 0;
                NullMoarBar.Maximum = MainForm.fSize;
                fileByteSum = CalculateByteSum(MainForm.fPath);
                CountingLabel.Text = "Считывание исходных байтов...";
                NullMoarBar.Value = 0;
                NullMoarBar.Maximum = fileByteSum;
                fileRealBytes = CalculateBytesReadUntilSum(MainForm.fPath, fileByteSum);
                DialogResult = DialogResult.OK;
            });

            _thread.Start();
        }


        public BigInteger CalculateByteSum(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024];
                BigInteger byteSum = 0;
                int bytesRead;

                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    byteSum += buffer.Take(bytesRead).Sum(b => (long)b);
                    NullMoarBar.Value += bytesRead;
                }
                return byteSum;
            }
        }

        public BigInteger CalculateBytesReadUntilSum(string filePath, BigInteger targetSum)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                BigInteger bytesRead = 0;
                BigInteger byteSum = 0;
                int currentByte;

                while ((currentByte = fs.ReadByte()) >= 0)
                {
                    if (byteSum == targetSum)
                        return bytesRead;

                    byteSum += currentByte;
                    bytesRead++;
                    NullMoarBar.Value = byteSum;
                }

                return bytesRead;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            _thread.Abort();
            DialogResult = DialogResult.Cancel;
        }
    }
}
