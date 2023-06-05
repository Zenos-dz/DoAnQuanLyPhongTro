namespace Doancs
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.csvc_panel = new System.Windows.Forms.Panel();
            this.csvc_sqlclient = new System.Windows.Forms.Button();
            this.csvc_linq = new System.Windows.Forms.Button();
            this.bcsvc = new System.Windows.Forms.Button();
            this.a5hoadon = new System.Windows.Forms.Button();
            this.sodiennuoc_panel = new System.Windows.Forms.Panel();
            this.sodiennuocsql = new System.Windows.Forms.Button();
            this.sodiennuoclinq = new System.Windows.Forms.Button();
            this.a4sodiennuoc = new System.Windows.Forms.Button();
            this.a3hopdong = new System.Windows.Forms.Button();
            this.a2nguoithue = new System.Windows.Forms.Button();
            this.phongtro_panel = new System.Windows.Forms.Panel();
            this.phongtrosql = new System.Windows.Forms.Button();
            this.phongtrolinq = new System.Windows.Forms.Button();
            this.a1phongtro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_welcome = new System.Windows.Forms.Label();
            this.CLOCK = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.logo_main = new System.Windows.Forms.PictureBox();
            this.TimerForMainClock = new System.Windows.Forms.Timer(this.components);
            this.changepass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.csvc_panel.SuspendLayout();
            this.sodiennuoc_panel.SuspendLayout();
            this.phongtro_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_main)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.csvc_panel);
            this.splitContainer1.Panel1.Controls.Add(this.bcsvc);
            this.splitContainer1.Panel1.Controls.Add(this.a5hoadon);
            this.splitContainer1.Panel1.Controls.Add(this.sodiennuoc_panel);
            this.splitContainer1.Panel1.Controls.Add(this.a4sodiennuoc);
            this.splitContainer1.Panel1.Controls.Add(this.a3hopdong);
            this.splitContainer1.Panel1.Controls.Add(this.a2nguoithue);
            this.splitContainer1.Panel1.Controls.Add(this.phongtro_panel);
            this.splitContainer1.Panel1.Controls.Add(this.a1phongtro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(946, 488);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 8;
            // 
            // csvc_panel
            // 
            this.csvc_panel.Controls.Add(this.csvc_sqlclient);
            this.csvc_panel.Controls.Add(this.csvc_linq);
            this.csvc_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.csvc_panel.Location = new System.Drawing.Point(0, 504);
            this.csvc_panel.Name = "csvc_panel";
            this.csvc_panel.Size = new System.Drawing.Size(173, 0);
            this.csvc_panel.TabIndex = 11;
            this.csvc_panel.Visible = false;
            // 
            // csvc_sqlclient
            // 
            this.csvc_sqlclient.Dock = System.Windows.Forms.DockStyle.Top;
            this.csvc_sqlclient.Location = new System.Drawing.Point(0, 28);
            this.csvc_sqlclient.Name = "csvc_sqlclient";
            this.csvc_sqlclient.Size = new System.Drawing.Size(173, 28);
            this.csvc_sqlclient.TabIndex = 1;
            this.csvc_sqlclient.Text = "csvc_sqlclient";
            this.csvc_sqlclient.UseVisualStyleBackColor = true;
            this.csvc_sqlclient.Click += new System.EventHandler(this.csvc_sqlclient_Click);
            // 
            // csvc_linq
            // 
            this.csvc_linq.Dock = System.Windows.Forms.DockStyle.Top;
            this.csvc_linq.Location = new System.Drawing.Point(0, 0);
            this.csvc_linq.Name = "csvc_linq";
            this.csvc_linq.Size = new System.Drawing.Size(173, 28);
            this.csvc_linq.TabIndex = 0;
            this.csvc_linq.Text = "csvc_linq";
            this.csvc_linq.UseVisualStyleBackColor = true;
            this.csvc_linq.Click += new System.EventHandler(this.csvc_linq_Click);
            // 
            // bcsvc
            // 
            this.bcsvc.BackColor = System.Drawing.Color.Transparent;
            this.bcsvc.CausesValidation = false;
            this.bcsvc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcsvc.Dock = System.Windows.Forms.DockStyle.Top;
            this.bcsvc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcsvc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.bcsvc.ForeColor = System.Drawing.Color.White;
            this.bcsvc.Location = new System.Drawing.Point(0, 440);
            this.bcsvc.Margin = new System.Windows.Forms.Padding(2);
            this.bcsvc.Name = "bcsvc";
            this.bcsvc.Size = new System.Drawing.Size(173, 64);
            this.bcsvc.TabIndex = 10;
            this.bcsvc.Text = "Cơ sở vật chất";
            this.bcsvc.UseVisualStyleBackColor = false;
            this.bcsvc.Click += new System.EventHandler(this.cosovchat);
            this.bcsvc.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.bcsvc.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // a5hoadon
            // 
            this.a5hoadon.BackColor = System.Drawing.Color.Transparent;
            this.a5hoadon.CausesValidation = false;
            this.a5hoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a5hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.a5hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a5hoadon.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a5hoadon.ForeColor = System.Drawing.Color.White;
            this.a5hoadon.Location = new System.Drawing.Point(0, 376);
            this.a5hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.a5hoadon.Name = "a5hoadon";
            this.a5hoadon.Size = new System.Drawing.Size(173, 64);
            this.a5hoadon.TabIndex = 9;
            this.a5hoadon.Text = "Hoá đơn";
            this.a5hoadon.UseVisualStyleBackColor = false;
            this.a5hoadon.Click += new System.EventHandler(this.hoadon);
            this.a5hoadon.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.a5hoadon.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // sodiennuoc_panel
            // 
            this.sodiennuoc_panel.Controls.Add(this.sodiennuocsql);
            this.sodiennuoc_panel.Controls.Add(this.sodiennuoclinq);
            this.sodiennuoc_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sodiennuoc_panel.Location = new System.Drawing.Point(0, 316);
            this.sodiennuoc_panel.Name = "sodiennuoc_panel";
            this.sodiennuoc_panel.Size = new System.Drawing.Size(173, 60);
            this.sodiennuoc_panel.TabIndex = 14;
            this.sodiennuoc_panel.Visible = false;
            // 
            // sodiennuocsql
            // 
            this.sodiennuocsql.Dock = System.Windows.Forms.DockStyle.Top;
            this.sodiennuocsql.Location = new System.Drawing.Point(0, 28);
            this.sodiennuocsql.Name = "sodiennuocsql";
            this.sodiennuocsql.Size = new System.Drawing.Size(173, 28);
            this.sodiennuocsql.TabIndex = 1;
            this.sodiennuocsql.Text = "sodiennuocsql";
            this.sodiennuocsql.UseVisualStyleBackColor = true;
            this.sodiennuocsql.Click += new System.EventHandler(this.sodiennuocsql_Click);
            // 
            // sodiennuoclinq
            // 
            this.sodiennuoclinq.Dock = System.Windows.Forms.DockStyle.Top;
            this.sodiennuoclinq.Location = new System.Drawing.Point(0, 0);
            this.sodiennuoclinq.Name = "sodiennuoclinq";
            this.sodiennuoclinq.Size = new System.Drawing.Size(173, 28);
            this.sodiennuoclinq.TabIndex = 0;
            this.sodiennuoclinq.Text = "sodiennuoclinq";
            this.sodiennuoclinq.UseVisualStyleBackColor = true;
            this.sodiennuoclinq.Click += new System.EventHandler(this.sodiennuoclinq_Click);
            // 
            // a4sodiennuoc
            // 
            this.a4sodiennuoc.BackColor = System.Drawing.Color.Transparent;
            this.a4sodiennuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a4sodiennuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.a4sodiennuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a4sodiennuoc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a4sodiennuoc.ForeColor = System.Drawing.Color.White;
            this.a4sodiennuoc.Location = new System.Drawing.Point(0, 252);
            this.a4sodiennuoc.Margin = new System.Windows.Forms.Padding(2);
            this.a4sodiennuoc.Name = "a4sodiennuoc";
            this.a4sodiennuoc.Size = new System.Drawing.Size(173, 64);
            this.a4sodiennuoc.TabIndex = 6;
            this.a4sodiennuoc.Text = "Số điện nước";
            this.a4sodiennuoc.UseVisualStyleBackColor = false;
            this.a4sodiennuoc.Click += new System.EventHandler(this.sdn_Click);
            this.a4sodiennuoc.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.a4sodiennuoc.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // a3hopdong
            // 
            this.a3hopdong.BackColor = System.Drawing.Color.Transparent;
            this.a3hopdong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a3hopdong.Dock = System.Windows.Forms.DockStyle.Top;
            this.a3hopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a3hopdong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3hopdong.ForeColor = System.Drawing.Color.White;
            this.a3hopdong.Location = new System.Drawing.Point(0, 188);
            this.a3hopdong.Margin = new System.Windows.Forms.Padding(2);
            this.a3hopdong.Name = "a3hopdong";
            this.a3hopdong.Size = new System.Drawing.Size(173, 64);
            this.a3hopdong.TabIndex = 0;
            this.a3hopdong.Text = "Hợp đồng";
            this.a3hopdong.UseVisualStyleBackColor = false;
            this.a3hopdong.Click += new System.EventHandler(this.hopdong);
            this.a3hopdong.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.a3hopdong.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // a2nguoithue
            // 
            this.a2nguoithue.BackColor = System.Drawing.Color.Transparent;
            this.a2nguoithue.CausesValidation = false;
            this.a2nguoithue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a2nguoithue.Dock = System.Windows.Forms.DockStyle.Top;
            this.a2nguoithue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a2nguoithue.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a2nguoithue.ForeColor = System.Drawing.Color.White;
            this.a2nguoithue.Location = new System.Drawing.Point(0, 124);
            this.a2nguoithue.Margin = new System.Windows.Forms.Padding(2);
            this.a2nguoithue.Name = "a2nguoithue";
            this.a2nguoithue.Size = new System.Drawing.Size(173, 64);
            this.a2nguoithue.TabIndex = 1;
            this.a2nguoithue.Text = "Người thuê";
            this.a2nguoithue.UseVisualStyleBackColor = false;
            this.a2nguoithue.Click += new System.EventHandler(this.nguoithuetro);
            this.a2nguoithue.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.a2nguoithue.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // phongtro_panel
            // 
            this.phongtro_panel.Controls.Add(this.phongtrosql);
            this.phongtro_panel.Controls.Add(this.phongtrolinq);
            this.phongtro_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.phongtro_panel.Location = new System.Drawing.Point(0, 64);
            this.phongtro_panel.Name = "phongtro_panel";
            this.phongtro_panel.Size = new System.Drawing.Size(173, 60);
            this.phongtro_panel.TabIndex = 13;
            this.phongtro_panel.Visible = false;
            // 
            // phongtrosql
            // 
            this.phongtrosql.Dock = System.Windows.Forms.DockStyle.Top;
            this.phongtrosql.Location = new System.Drawing.Point(0, 28);
            this.phongtrosql.Name = "phongtrosql";
            this.phongtrosql.Size = new System.Drawing.Size(173, 28);
            this.phongtrosql.TabIndex = 0;
            this.phongtrosql.Text = "phongtrosql";
            this.phongtrosql.UseVisualStyleBackColor = true;
            this.phongtrosql.Click += new System.EventHandler(this.phongtrosql_Click);
            // 
            // phongtrolinq
            // 
            this.phongtrolinq.Dock = System.Windows.Forms.DockStyle.Top;
            this.phongtrolinq.Location = new System.Drawing.Point(0, 0);
            this.phongtrolinq.Name = "phongtrolinq";
            this.phongtrolinq.Size = new System.Drawing.Size(173, 28);
            this.phongtrolinq.TabIndex = 1;
            this.phongtrolinq.Text = "phongtrolinq";
            this.phongtrolinq.UseVisualStyleBackColor = true;
            this.phongtrolinq.Click += new System.EventHandler(this.phongtrolinq_Click);
            // 
            // a1phongtro
            // 
            this.a1phongtro.BackColor = System.Drawing.Color.Transparent;
            this.a1phongtro.CausesValidation = false;
            this.a1phongtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a1phongtro.Dock = System.Windows.Forms.DockStyle.Top;
            this.a1phongtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a1phongtro.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a1phongtro.ForeColor = System.Drawing.Color.White;
            this.a1phongtro.Location = new System.Drawing.Point(0, 0);
            this.a1phongtro.Margin = new System.Windows.Forms.Padding(2);
            this.a1phongtro.Name = "a1phongtro";
            this.a1phongtro.Size = new System.Drawing.Size(173, 64);
            this.a1phongtro.TabIndex = 0;
            this.a1phongtro.Text = "Phòng trọ";
            this.a1phongtro.UseVisualStyleBackColor = false;
            this.a1phongtro.Click += new System.EventHandler(this.phongtro);
            this.a1phongtro.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.a1phongtro.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_welcome);
            this.panel1.Controls.Add(this.CLOCK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 488);
            this.panel1.TabIndex = 0;
            // 
            // txt_welcome
            // 
            this.txt_welcome.AutoSize = true;
            this.txt_welcome.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_welcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_welcome.Location = new System.Drawing.Point(94, 27);
            this.txt_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_welcome.Name = "txt_welcome";
            this.txt_welcome.Size = new System.Drawing.Size(623, 37);
            this.txt_welcome.TabIndex = 1;
            this.txt_welcome.Text = "Chào mừng bạn đến với phần mềm quản lý nhà trọ";
            // 
            // CLOCK
            // 
            this.CLOCK.AutoSize = true;
            this.CLOCK.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOCK.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CLOCK.Location = new System.Drawing.Point(251, 350);
            this.CLOCK.Name = "CLOCK";
            this.CLOCK.Size = new System.Drawing.Size(311, 86);
            this.CLOCK.TabIndex = 0;
            this.CLOCK.Text = "hh:mm:ss";
            this.CLOCK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.changepass);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.logo_main);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 59);
            this.panel2.TabIndex = 9;
            // 
            // logout
            // 
            this.logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logout.Location = new System.Drawing.Point(857, 0);
            this.logout.Margin = new System.Windows.Forms.Padding(0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(89, 59);
            this.logout.TabIndex = 1;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // logo_main
            // 
            this.logo_main.BackColor = System.Drawing.Color.Transparent;
            this.logo_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo_main.ErrorImage = global::Doancs.Properties.Resources.QHL;
            this.logo_main.Image = ((System.Drawing.Image)(resources.GetObject("logo_main.Image")));
            this.logo_main.Location = new System.Drawing.Point(0, 0);
            this.logo_main.Margin = new System.Windows.Forms.Padding(0);
            this.logo_main.Name = "logo_main";
            this.logo_main.Size = new System.Drawing.Size(66, 59);
            this.logo_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_main.TabIndex = 0;
            this.logo_main.TabStop = false;
            this.logo_main.Click += new System.EventHandler(this.logo_main_Click);
            // 
            // TimerForMainClock
            // 
            this.TimerForMainClock.Interval = 80;
            this.TimerForMainClock.Tick += new System.EventHandler(this.TimerForMainClock_Tick);
            // 
            // changepass
            // 
            this.changepass.Dock = System.Windows.Forms.DockStyle.Right;
            this.changepass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.changepass.Location = new System.Drawing.Point(768, 0);
            this.changepass.Margin = new System.Windows.Forms.Padding(0);
            this.changepass.Name = "changepass";
            this.changepass.Size = new System.Drawing.Size(89, 59);
            this.changepass.TabIndex = 2;
            this.changepass.Text = "Đổi mật khẩu";
            this.changepass.UseVisualStyleBackColor = true;
            this.changepass.Click += new System.EventHandler(this.changepass_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.csvc_panel.ResumeLayout(false);
            this.sodiennuoc_panel.ResumeLayout(false);
            this.phongtro_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button a1phongtro;
        private System.Windows.Forms.Button a2nguoithue;
        private System.Windows.Forms.Button a3hopdong;
        private System.Windows.Forms.Button a4sodiennuoc;
        private System.Windows.Forms.Button a5hoadon;
        private System.Windows.Forms.Button bcsvc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CLOCK;
        private System.Windows.Forms.Timer TimerForMainClock;
        private System.Windows.Forms.PictureBox logo_main;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label txt_welcome;
        private System.Windows.Forms.Panel csvc_panel;
        private System.Windows.Forms.Button csvc_sqlclient;
        private System.Windows.Forms.Button csvc_linq;
        private System.Windows.Forms.Panel phongtro_panel;
        private System.Windows.Forms.Button phongtrolinq;
        private System.Windows.Forms.Button phongtrosql;
        private System.Windows.Forms.Panel sodiennuoc_panel;
        private System.Windows.Forms.Button sodiennuocsql;
        private System.Windows.Forms.Button sodiennuoclinq;
        private System.Windows.Forms.Button changepass;
    }
}

