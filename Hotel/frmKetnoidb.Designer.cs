
namespace Hotel
{
    partial class frmketnoidb
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
            this.components = new System.ComponentModel.Container();
            this.virtualServerModeSource1 = new DevExpress.Data.VirtualServerModeSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnKiemTra);
            this.groupControl1.Controls.Add(this.cboDatabase);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtServer);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(417, 273);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(165, 174);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 24);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(278, 174);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 24);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(56, 174);
            this.btnKiemTra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(68, 24);
            this.btnKiemTra.TabIndex = 11;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(124, 127);
            this.cboDatabase.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(195, 24);
            this.cboDatabase.TabIndex = 10;
            this.cboDatabase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboDatabase_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Database";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(124, 81);
            this.txtServer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(197, 23);
            this.txtServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servername";
            // 
            // frmketnoidb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 273);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmketnoidb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.frmketnoidb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Data.VirtualServerModeSource virtualServerModeSource1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.ComboBox cboDatabase;
    }
}