namespace Demo_Singleton
{
    partial class FormMain
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
            this.btnFrmThuong = new System.Windows.Forms.Button();
            this.btnFrmSingleton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrmThuong
            // 
            this.btnFrmThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmThuong.Location = new System.Drawing.Point(107, 90);
            this.btnFrmThuong.Name = "btnFrmThuong";
            this.btnFrmThuong.Size = new System.Drawing.Size(148, 76);
            this.btnFrmThuong.TabIndex = 0;
            this.btnFrmThuong.Text = "Form Thường";
            this.btnFrmThuong.UseVisualStyleBackColor = true;
            this.btnFrmThuong.Click += new System.EventHandler(this.BtnFrmThuong_Click);
            // 
            // btnFrmSingleton
            // 
            this.btnFrmSingleton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmSingleton.Location = new System.Drawing.Point(298, 90);
            this.btnFrmSingleton.Name = "btnFrmSingleton";
            this.btnFrmSingleton.Size = new System.Drawing.Size(148, 76);
            this.btnFrmSingleton.TabIndex = 0;
            this.btnFrmSingleton.Text = "Form singleton";
            this.btnFrmSingleton.UseVisualStyleBackColor = true;
            this.btnFrmSingleton.Click += new System.EventHandler(this.BtnFrmSingleton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 297);
            this.Controls.Add(this.btnFrmSingleton);
            this.Controls.Add(this.btnFrmThuong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrmThuong;
        private System.Windows.Forms.Button btnFrmSingleton;
    }
}

