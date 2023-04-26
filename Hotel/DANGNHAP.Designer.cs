
namespace Hotel
{
    partial class DANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGNHAP));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_username = new DevExpress.XtraEditors.TextEdit();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_check = new DevExpress.XtraEditors.CheckEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_check.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(181, 100);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(181, 166);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(269, 97);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(201, 22);
            this.txt_username.TabIndex = 2;
            this.txt_username.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(269, 164);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.UseSystemPasswordChar = true;
            this.txt_password.Size = new System.Drawing.Size(201, 22);
            this.txt_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Appearance.Options.UseFont = true;
            this.btn_login.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_login.ImageOptions.SvgImage")));
            this.btn_login.Location = new System.Drawing.Point(269, 236);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(87, 36);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Log in";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_exit.ImageOptions.SvgImage")));
            this.btn_exit.Location = new System.Drawing.Point(383, 236);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 36);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(269, 304);
            this.btn_check.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_check.Name = "btn_check";
            this.btn_check.Properties.Caption = "Remember";
            this.btn_check.Size = new System.Drawing.Size(201, 24);
            this.btn_check.TabIndex = 6;
            this.btn_check.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(62, 100);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(100, 86);
            this.pictureEdit2.TabIndex = 8;
            this.pictureEdit2.EditValueChanged += new System.EventHandler(this.pictureEdit2_EditValueChanged);
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 372);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DANGNHAP.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "DANGNHAP";

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DANGNHAP_FormClosing);

            this.Load += new System.EventHandler(this.DANGNHAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_check.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_username;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.XtraEditors.CheckEdit btn_check;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}