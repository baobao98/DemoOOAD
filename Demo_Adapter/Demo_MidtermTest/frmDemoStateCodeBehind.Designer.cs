namespace Demo_MidtermTest
{
    partial class frmDemoStateCodeBehind
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
            this.btn_KetNoi = new System.Windows.Forms.Button();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.cb_PhichCam = new System.Windows.Forms.ComboBox();
            this.ck_adapter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_KetNoi
            // 
            this.btn_KetNoi.Location = new System.Drawing.Point(96, 121);
            this.btn_KetNoi.Name = "btn_KetNoi";
            this.btn_KetNoi.Size = new System.Drawing.Size(89, 36);
            this.btn_KetNoi.TabIndex = 0;
            this.btn_KetNoi.Text = "Kết nối";
            this.btn_KetNoi.UseVisualStyleBackColor = true;
            this.btn_KetNoi.Click += new System.EventHandler(this.Btn_KetNoi_Click);
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.Location = new System.Drawing.Point(260, 144);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(66, 13);
            this.lbl_KetQua.TabIndex = 1;
            this.lbl_KetQua.Text = "[ kết quả ]";
            // 
            // cb_PhichCam
            // 
            this.cb_PhichCam.FormattingEnabled = true;
            this.cb_PhichCam.Items.AddRange(new object[] {
            "Phich Cam 2 Chan",
            "Phich Cam 3 Chan"});
            this.cb_PhichCam.Location = new System.Drawing.Point(84, 46);
            this.cb_PhichCam.Name = "cb_PhichCam";
            this.cb_PhichCam.Size = new System.Drawing.Size(121, 21);
            this.cb_PhichCam.TabIndex = 2;
            this.cb_PhichCam.Text = "Chọn phích cắm";
            // 
            // ck_adapter
            // 
            this.ck_adapter.AutoSize = true;
            this.ck_adapter.Location = new System.Drawing.Point(253, 48);
            this.ck_adapter.Name = "ck_adapter";
            this.ck_adapter.Size = new System.Drawing.Size(106, 17);
            this.ck_adapter.TabIndex = 3;
            this.ck_adapter.Text = "Sử dụng Adapter";
            this.ck_adapter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tình trạng kết nối :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "kết nối tới ổ điện => máy tính hoạt động";
            // 
            // frmDemoStateCodeBehind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ck_adapter);
            this.Controls.Add(this.cb_PhichCam);
            this.Controls.Add(this.lbl_KetQua);
            this.Controls.Add(this.btn_KetNoi);
            this.Name = "frmDemoStateCodeBehind";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_KetNoi;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.ComboBox cb_PhichCam;
        private System.Windows.Forms.CheckBox ck_adapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

