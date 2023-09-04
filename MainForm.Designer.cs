namespace MoarBytes
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectFile = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.Button();
            this.CountMb = new System.Windows.Forms.NumericUpDown();
            this.AddBytesLabel = new System.Windows.Forms.Label();
            this.OutputSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CountMb)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.BackColor = System.Drawing.Color.Transparent;
            this.SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectFile.Location = new System.Drawing.Point(12, 55);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(168, 40);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.TabStop = false;
            this.SelectFile.Text = "Выбрать файл";
            this.SelectFile.UseVisualStyleBackColor = false;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLabel.ForeColor = System.Drawing.Color.Red;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(168, 43);
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "Файл: Не выбран";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileSizeLabel.ForeColor = System.Drawing.Color.Blue;
            this.FileSizeLabel.Location = new System.Drawing.Point(12, 98);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(168, 43);
            this.FileSizeLabel.TabIndex = 3;
            this.FileSizeLabel.Text = "Размер файла: -";
            this.FileSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.Color.Transparent;
            this.SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFile.Location = new System.Drawing.Point(12, 187);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(168, 40);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.TabStop = false;
            this.SaveFile.Text = "Сохранить файл";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // CountMb
            // 
            this.CountMb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CountMb.Location = new System.Drawing.Point(102, 149);
            this.CountMb.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CountMb.Name = "CountMb";
            this.CountMb.Size = new System.Drawing.Size(78, 26);
            this.CountMb.TabIndex = 5;
            this.CountMb.TabStop = false;
            this.CountMb.ValueChanged += new System.EventHandler(this.CountMb_ValueChanged);
            // 
            // AddBytesLabel
            // 
            this.AddBytesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBytesLabel.ForeColor = System.Drawing.Color.Blue;
            this.AddBytesLabel.Location = new System.Drawing.Point(12, 141);
            this.AddBytesLabel.Name = "AddBytesLabel";
            this.AddBytesLabel.Size = new System.Drawing.Size(73, 43);
            this.AddBytesLabel.TabIndex = 6;
            this.AddBytesLabel.Text = "Добавить(МБ)";
            this.AddBytesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputSizeLabel
            // 
            this.OutputSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputSizeLabel.ForeColor = System.Drawing.Color.Blue;
            this.OutputSizeLabel.Location = new System.Drawing.Point(12, 230);
            this.OutputSizeLabel.Name = "OutputSizeLabel";
            this.OutputSizeLabel.Size = new System.Drawing.Size(168, 43);
            this.OutputSizeLabel.TabIndex = 7;
            this.OutputSizeLabel.Text = "Выходной размер: -";
            this.OutputSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(192, 278);
            this.Controls.Add(this.OutputSizeLabel);
            this.Controls.Add(this.AddBytesLabel);
            this.Controls.Add(this.CountMb);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.FileSizeLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.SelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoarBytes";
            ((System.ComponentModel.ISupportInitialize)(this.CountMb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.NumericUpDown CountMb;
        private System.Windows.Forms.Label AddBytesLabel;
        private System.Windows.Forms.Label OutputSizeLabel;
    }
}

