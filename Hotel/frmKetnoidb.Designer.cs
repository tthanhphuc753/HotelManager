
namespace Hotel
{
    partial class frmKetnoidb
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbodatabase = new System.Windows.Forms.ComboBox();
            this.btnkiemtraketnoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnDocfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDocfile);
            this.groupControl1.Controls.Add(this.btnkiemtraketnoi);
            this.groupControl1.Controls.Add(this.btnluu);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.cbodatabase);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtServer);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(598, 245);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "THÔNG TIN KẾT NỐI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(194, 48);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(220, 27);
            this.txtServer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Database";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbodatabase
            // 
            this.cbodatabase.FormattingEnabled = true;
            this.cbodatabase.Location = new System.Drawing.Point(194, 91);
            this.cbodatabase.Name = "cbodatabase";
            this.cbodatabase.Size = new System.Drawing.Size(217, 27);
            this.cbodatabase.TabIndex = 7;
            this.cbodatabase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbodatabase_MouseClick);
            // 
            // btnkiemtraketnoi
            // 
            this.btnkiemtraketnoi.Location = new System.Drawing.Point(68, 160);
            this.btnkiemtraketnoi.Name = "btnkiemtraketnoi";
            this.btnkiemtraketnoi.Size = new System.Drawing.Size(96, 40);
            this.btnkiemtraketnoi.TabIndex = 8;
            this.btnkiemtraketnoi.Text = "Kiểm tra ";
            this.btnkiemtraketnoi.UseVisualStyleBackColor = true;
            this.btnkiemtraketnoi.Click += new System.EventHandler(this.btnkiemtraketnoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(435, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 40);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(315, 160);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(96, 40);
            this.btnluu.TabIndex = 10;
            this.btnluu.Text = "Lưu File";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnDocfile
            // 
            this.btnDocfile.Location = new System.Drawing.Point(194, 160);
            this.btnDocfile.Name = "btnDocfile";
            this.btnDocfile.Size = new System.Drawing.Size(96, 40);
            this.btnDocfile.TabIndex = 11;
            this.btnDocfile.Text = "Đọc File";
            this.btnDocfile.UseVisualStyleBackColor = true;
            this.btnDocfile.Click += new System.EventHandler(this.btnDocfile_Click);
            // 
            // frmKetnoidb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 245);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKetnoidb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU";
            this.Load += new System.EventHandler(this.frmKetnoidb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbodatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDocfile;
        private System.Windows.Forms.Button btnkiemtraketnoi;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnThoat;
    }
}