namespace BigFileMaker
{
    partial class BigFileMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createFile = new System.Windows.Forms.Button();
            this.sizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonGb = new System.Windows.Forms.RadioButton();
            this.radioButtonMb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.sizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // createFile
            // 
            this.createFile.Location = new System.Drawing.Point(82, 200);
            this.createFile.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(161, 57);
            this.createFile.TabIndex = 0;
            this.createFile.Text = "Create File";
            this.createFile.UseVisualStyleBackColor = true;
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // sizeUpDown
            // 
            this.sizeUpDown.Location = new System.Drawing.Point(82, 44);
            this.sizeUpDown.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.sizeUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sizeUpDown.Name = "sizeUpDown";
            this.sizeUpDown.Size = new System.Drawing.Size(161, 43);
            this.sizeUpDown.TabIndex = 1;
            // 
            // radioButtonGb
            // 
            this.radioButtonGb.AutoSize = true;
            this.radioButtonGb.Location = new System.Drawing.Point(57, 144);
            this.radioButtonGb.Name = "radioButtonGb";
            this.radioButtonGb.Size = new System.Drawing.Size(211, 41);
            this.radioButtonGb.TabIndex = 2;
            this.radioButtonGb.Text = "Gigabytes (GB)";
            this.radioButtonGb.UseVisualStyleBackColor = true;
            // 
            // radioButtonMb
            // 
            this.radioButtonMb.AutoSize = true;
            this.radioButtonMb.Checked = true;
            this.radioButtonMb.Location = new System.Drawing.Point(57, 97);
            this.radioButtonMb.Name = "radioButtonMb";
            this.radioButtonMb.Size = new System.Drawing.Size(228, 41);
            this.radioButtonMb.TabIndex = 3;
            this.radioButtonMb.TabStop = true;
            this.radioButtonMb.Text = "Megabytes (MB)";
            this.radioButtonMb.UseVisualStyleBackColor = true;
            // 
            // BigFileMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 301);
            this.Controls.Add(this.radioButtonMb);
            this.Controls.Add(this.radioButtonGb);
            this.Controls.Add(this.sizeUpDown);
            this.Controls.Add(this.createFile);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BigFileMaker";
            this.Text = "Big File Maker";
            ((System.ComponentModel.ISupportInitialize)(this.sizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createFile;
        public NumericUpDown sizeUpDown;
        private SaveFileDialog saveFileDialog1;
        private RadioButton radioButtonGb;
        private RadioButton radioButtonMb;
    }
}