
namespace Hotel
{
    partial class Thaydoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thaydoi));
            this.dvg = new System.Windows.Forms.DataGridView();
            this.txtgiatien = new System.Windows.Forms.TextBox();
            this.txtloaiphong = new System.Windows.Forms.TextBox();
            this.txtsonguoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.them = new DevExpress.XtraEditors.SimpleButton();
            this.xoa = new DevExpress.XtraEditors.SimpleButton();
            this.sua = new DevExpress.XtraEditors.SimpleButton();
            this.khoitao = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvg
            // 
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg.Location = new System.Drawing.Point(4, 24);
            this.dvg.Margin = new System.Windows.Forms.Padding(4);
            this.dvg.Name = "dvg";
            this.dvg.RowHeadersWidth = 51;
            this.dvg.RowTemplate.Height = 24;
            this.dvg.Size = new System.Drawing.Size(618, 239);
            this.dvg.TabIndex = 0;
            this.dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_CellContentClick);
            // 
            // txtgiatien
            // 
            this.txtgiatien.Location = new System.Drawing.Point(143, 101);
            this.txtgiatien.Margin = new System.Windows.Forms.Padding(4);
            this.txtgiatien.Name = "txtgiatien";
            this.txtgiatien.Size = new System.Drawing.Size(127, 27);
            this.txtgiatien.TabIndex = 1;
            // 
            // txtloaiphong
            // 
            this.txtloaiphong.Location = new System.Drawing.Point(143, 26);
            this.txtloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtloaiphong.Name = "txtloaiphong";
            this.txtloaiphong.Size = new System.Drawing.Size(127, 27);
            this.txtloaiphong.TabIndex = 1;
            // 
            // txtsonguoi
            // 
            this.txtsonguoi.Location = new System.Drawing.Point(143, 185);
            this.txtsonguoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtsonguoi.Name = "txtsonguoi";
            this.txtsonguoi.Size = new System.Drawing.Size(127, 27);
            this.txtsonguoi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số người:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvg);
            this.groupBox1.Location = new System.Drawing.Point(30, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(626, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // them
            // 
            this.them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("them.ImageOptions.Image")));
            this.them.Location = new System.Drawing.Point(483, 327);
            this.them.Margin = new System.Windows.Forms.Padding(4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(121, 34);
            this.them.TabIndex = 4;
            this.them.Text = "Thêm";
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xoa.ImageOptions.Image")));
            this.xoa.Location = new System.Drawing.Point(483, 386);
            this.xoa.Margin = new System.Windows.Forms.Padding(4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(121, 34);
            this.xoa.TabIndex = 4;
            this.xoa.Text = "Xóa";
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sua.ImageOptions.Image")));
            this.sua.Location = new System.Drawing.Point(483, 445);
            this.sua.Margin = new System.Windows.Forms.Padding(4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(121, 34);
            this.sua.TabIndex = 4;
            this.sua.Text = "Sửa";
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // khoitao
            // 
            this.khoitao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("khoitao.ImageOptions.Image")));
            this.khoitao.Location = new System.Drawing.Point(483, 505);
            this.khoitao.Margin = new System.Windows.Forms.Padding(4);
            this.khoitao.Name = "khoitao";
            this.khoitao.Size = new System.Drawing.Size(121, 34);
            this.khoitao.TabIndex = 4;
            this.khoitao.Text = "Làm mới ";
            this.khoitao.Click += new System.EventHandler(this.khoitao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtgiatien);
            this.groupBox2.Controls.Add(this.txtloaiphong);
            this.groupBox2.Controls.Add(this.txtsonguoi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(30, 305);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(378, 260);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chỉnh sửa";
            // 
            // Thaydoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 580);
            this.Controls.Add(this.khoitao);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Thaydoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi quy định";
            this.Load += new System.EventHandler(this.Thaydoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.TextBox txtgiatien;
        private System.Windows.Forms.TextBox txtloaiphong;
        private System.Windows.Forms.TextBox txtsonguoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton them;
        private DevExpress.XtraEditors.SimpleButton xoa;
        private DevExpress.XtraEditors.SimpleButton sua;
        private DevExpress.XtraEditors.SimpleButton khoitao;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}