namespace MoarBytes
{
    partial class CountingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountingForm));
            this.CountingLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.NullMoarBar = new MoarBytes.MoarProgressBar();
            this.SuspendLayout();
            // 
            // CountingLabel
            // 
            this.CountingLabel.AutoSize = true;
            this.CountingLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountingLabel.ForeColor = System.Drawing.Color.Blue;
            this.CountingLabel.Location = new System.Drawing.Point(9, 9);
            this.CountingLabel.Name = "CountingLabel";
            this.CountingLabel.Size = new System.Drawing.Size(191, 17);
            this.CountingLabel.TabIndex = 0;
            this.CountingLabel.Text = "Подсчёт контрольной суммы...";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(12, 67);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(237, 40);
            this.Cancel.TabIndex = 5;
            this.Cancel.TabStop = false;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NullMoarBar
            // 
            this.NullMoarBar.BackgroundColor = System.Drawing.Color.DarkGray;
            this.NullMoarBar.BarColor = System.Drawing.Color.Purple;
            this.NullMoarBar.BorderColor = System.Drawing.Color.Black;
            this.NullMoarBar.ForeColor = System.Drawing.Color.White;
            this.NullMoarBar.Location = new System.Drawing.Point(12, 38);
            this.NullMoarBar.Maximum = ((System.Numerics.BigInteger)(resources.GetObject("NullMoarBar.Maximum")));
            this.NullMoarBar.Minimum = ((System.Numerics.BigInteger)(resources.GetObject("NullMoarBar.Minimum")));
            this.NullMoarBar.Name = "NullMoarBar";
            this.NullMoarBar.Size = new System.Drawing.Size(237, 23);
            this.NullMoarBar.TabIndex = 6;
            this.NullMoarBar.Value = ((System.Numerics.BigInteger)(resources.GetObject("NullMoarBar.Value")));
            // 
            // CountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 117);
            this.Controls.Add(this.NullMoarBar);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CountingLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoarBytes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountingLabel;
        private System.Windows.Forms.Button Cancel;
        private MoarProgressBar NullMoarBar;
    }
}