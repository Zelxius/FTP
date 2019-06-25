namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UploadBtn = new System.Windows.Forms.Button();
            this.FtpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(322, 198);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(151, 49);
            this.UploadBtn.TabIndex = 0;
            this.UploadBtn.Text = "Upload File";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // FtpBtn
            // 
            this.FtpBtn.Location = new System.Drawing.Point(322, 69);
            this.FtpBtn.Name = "FtpBtn";
            this.FtpBtn.Size = new System.Drawing.Size(150, 53);
            this.FtpBtn.TabIndex = 1;
            this.FtpBtn.Text = "FTP";
            this.FtpBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FtpBtn);
            this.Controls.Add(this.UploadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Button FtpBtn;
    }
}

