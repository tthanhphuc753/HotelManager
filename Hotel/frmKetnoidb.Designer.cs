
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtservername = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboDatab = new System.Windows.Forms.ComboBox();
            this.btnKiemtra = new System.Windows.Forms.Button();
            this.btnLuufile = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtpassw = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(96, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Severname";
            // 
            // txtservername
            // 
            this.txtservername.Location = new System.Drawing.Point(238, 62);
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(251, 27);
            this.txtservername.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(96, 223);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Database";
            // 
            // cboDatab
            // 
            this.cboDatab.FormattingEnabled = true;
            this.cboDatab.Location = new System.Drawing.Point(238, 219);
            this.cboDatab.Name = "cboDatab";
            this.cboDatab.Size = new System.Drawing.Size(249, 27);
            this.cboDatab.TabIndex = 7;
            this.cboDatab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboDatab_MouseClick);
            // 
            // btnKiemtra
            // 
            this.btnKiemtra.Location = new System.Drawing.Point(138, 282);
            this.btnKiemtra.Name = "btnKiemtra";
            this.btnKiemtra.Size = new System.Drawing.Size(110, 40);
            this.btnKiemtra.TabIndex = 8;
            this.btnKiemtra.Text = "Kiểm tra ";
            this.btnKiemtra.UseVisualStyleBackColor = true;
            this.btnKiemtra.Click += new System.EventHandler(this.btnKiemtra_Click_1);
            // 
            // btnLuufile
            // 
            this.btnLuufile.Location = new System.Drawing.Point(288, 282);
            this.btnLuufile.Name = "btnLuufile";
            this.btnLuufile.Size = new System.Drawing.Size(110, 40);
            this.btnLuufile.TabIndex = 10;
            this.btnLuufile.Text = "Lưu";
            this.btnLuufile.UseVisualStyleBackColor = true;
            this.btnLuufile.Click += new System.EventHandler(this.btnLuufile_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(423, 282);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(110, 40);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(238, 116);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(251, 27);
            this.txtusername.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 169);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 19);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Password";
            // 
            // txtpassw
            // 
            this.txtpassw.Location = new System.Drawing.Point(238, 165);
            this.txtpassw.Name = "txtpassw";
            this.txtpassw.Size = new System.Drawing.Size(251, 27);
            this.txtpassw.TabIndex = 15;
            this.txtpassw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(94, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 19);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Username";
            // 
            // frmKetnoidb
            // 
            this.ClientSize = new System.Drawing.Size(678, 386);
            this.Controls.Add(this.txtpassw);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnLuufile);
            this.Controls.Add(this.btnKiemtra);
            this.Controls.Add(this.cboDatab);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtservername);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmKetnoidb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmKetnoidb_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtservername;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cboDatab;
        private System.Windows.Forms.Button btnKiemtra;
        private System.Windows.Forms.Button btnLuufile;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtusername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtpassw;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}