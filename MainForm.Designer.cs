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
            this.CountBytes = new System.Windows.Forms.NumericUpDown();
            this.AddBytesLabel = new System.Windows.Forms.Label();
            this.OutputSizeLabel = new System.Windows.Forms.Label();
            this.TypeBytes = new System.Windows.Forms.ComboBox();
            this.DriveLabel = new System.Windows.Forms.Label();
            this.TotalMemLabel = new System.Windows.Forms.Label();
            this.FreeMemLabel = new System.Windows.Forms.Label();
            this.LeftMemLabel = new System.Windows.Forms.Label();
            this.ReturnOriginalSize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountBytes)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.BackColor = System.Drawing.Color.Transparent;
            this.SelectFile.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectFile.Location = new System.Drawing.Point(12, 55);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(228, 40);
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
            this.FileNameLabel.Size = new System.Drawing.Size(228, 43);
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
            this.FileSizeLabel.Size = new System.Drawing.Size(228, 43);
            this.FileSizeLabel.TabIndex = 3;
            this.FileSizeLabel.Text = "Размер файла: -";
            this.FileSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.Color.Transparent;
            this.SaveFile.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFile.Location = new System.Drawing.Point(12, 187);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(228, 40);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.TabStop = false;
            this.SaveFile.Text = "Сохранить файл";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // CountBytes
            // 
            this.CountBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CountBytes.Location = new System.Drawing.Point(91, 149);
            this.CountBytes.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CountBytes.Name = "CountBytes";
            this.CountBytes.Size = new System.Drawing.Size(78, 26);
            this.CountBytes.TabIndex = 5;
            this.CountBytes.TabStop = false;
            this.CountBytes.ValueChanged += new System.EventHandler(this.CountMb_ValueChanged);
            // 
            // AddBytesLabel
            // 
            this.AddBytesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBytesLabel.ForeColor = System.Drawing.Color.Blue;
            this.AddBytesLabel.Location = new System.Drawing.Point(12, 141);
            this.AddBytesLabel.Name = "AddBytesLabel";
            this.AddBytesLabel.Size = new System.Drawing.Size(73, 43);
            this.AddBytesLabel.TabIndex = 6;
            this.AddBytesLabel.Text = "Добавить";
            this.AddBytesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputSizeLabel
            // 
            this.OutputSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputSizeLabel.ForeColor = System.Drawing.Color.Blue;
            this.OutputSizeLabel.Location = new System.Drawing.Point(12, 276);
            this.OutputSizeLabel.Name = "OutputSizeLabel";
            this.OutputSizeLabel.Size = new System.Drawing.Size(228, 43);
            this.OutputSizeLabel.TabIndex = 7;
            this.OutputSizeLabel.Text = "Выходной размер: -";
            this.OutputSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeBytes
            // 
            this.TypeBytes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TypeBytes.FormattingEnabled = true;
            this.TypeBytes.Items.AddRange(new object[] {
            "Б",
            "КБ",
            "МБ",
            "ГБ"});
            this.TypeBytes.Location = new System.Drawing.Point(175, 148);
            this.TypeBytes.Name = "TypeBytes";
            this.TypeBytes.Size = new System.Drawing.Size(65, 28);
            this.TypeBytes.TabIndex = 8;
            this.TypeBytes.SelectedIndexChanged += new System.EventHandler(this.TypeBytes_SelectedIndexChanged);
            // 
            // DriveLabel
            // 
            this.DriveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriveLabel.ForeColor = System.Drawing.Color.Blue;
            this.DriveLabel.Location = new System.Drawing.Point(12, 319);
            this.DriveLabel.Name = "DriveLabel";
            this.DriveLabel.Size = new System.Drawing.Size(228, 23);
            this.DriveLabel.TabIndex = 9;
            this.DriveLabel.Text = "Том: -";
            this.DriveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalMemLabel
            // 
            this.TotalMemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalMemLabel.ForeColor = System.Drawing.Color.Blue;
            this.TotalMemLabel.Location = new System.Drawing.Point(12, 342);
            this.TotalMemLabel.Name = "TotalMemLabel";
            this.TotalMemLabel.Size = new System.Drawing.Size(228, 23);
            this.TotalMemLabel.TabIndex = 10;
            this.TotalMemLabel.Text = "Всего: -";
            this.TotalMemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FreeMemLabel
            // 
            this.FreeMemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeMemLabel.ForeColor = System.Drawing.Color.Blue;
            this.FreeMemLabel.Location = new System.Drawing.Point(12, 365);
            this.FreeMemLabel.Name = "FreeMemLabel";
            this.FreeMemLabel.Size = new System.Drawing.Size(228, 23);
            this.FreeMemLabel.TabIndex = 11;
            this.FreeMemLabel.Text = "Свободно: -";
            this.FreeMemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftMemLabel
            // 
            this.LeftMemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftMemLabel.ForeColor = System.Drawing.Color.Blue;
            this.LeftMemLabel.Location = new System.Drawing.Point(12, 388);
            this.LeftMemLabel.Name = "LeftMemLabel";
            this.LeftMemLabel.Size = new System.Drawing.Size(228, 23);
            this.LeftMemLabel.TabIndex = 12;
            this.LeftMemLabel.Text = "Останется: -";
            this.LeftMemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnOriginalSize
            // 
            this.ReturnOriginalSize.BackColor = System.Drawing.Color.Transparent;
            this.ReturnOriginalSize.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ReturnOriginalSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnOriginalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnOriginalSize.Location = new System.Drawing.Point(12, 233);
            this.ReturnOriginalSize.Name = "ReturnOriginalSize";
            this.ReturnOriginalSize.Size = new System.Drawing.Size(228, 40);
            this.ReturnOriginalSize.TabIndex = 13;
            this.ReturnOriginalSize.TabStop = false;
            this.ReturnOriginalSize.Text = "Вернуть исходный размер";
            this.ReturnOriginalSize.UseVisualStyleBackColor = false;
            this.ReturnOriginalSize.Click += new System.EventHandler(this.ReturnOriginalSize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(252, 418);
            this.Controls.Add(this.ReturnOriginalSize);
            this.Controls.Add(this.LeftMemLabel);
            this.Controls.Add(this.FreeMemLabel);
            this.Controls.Add(this.TotalMemLabel);
            this.Controls.Add(this.DriveLabel);
            this.Controls.Add(this.TypeBytes);
            this.Controls.Add(this.OutputSizeLabel);
            this.Controls.Add(this.AddBytesLabel);
            this.Controls.Add(this.CountBytes);
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
            ((System.ComponentModel.ISupportInitialize)(this.CountBytes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.NumericUpDown CountBytes;
        private System.Windows.Forms.Label AddBytesLabel;
        private System.Windows.Forms.Label OutputSizeLabel;
        private System.Windows.Forms.ComboBox TypeBytes;
        private System.Windows.Forms.Label DriveLabel;
        private System.Windows.Forms.Label TotalMemLabel;
        private System.Windows.Forms.Label FreeMemLabel;
        private System.Windows.Forms.Label LeftMemLabel;
        private System.Windows.Forms.Button ReturnOriginalSize;
    }
}

