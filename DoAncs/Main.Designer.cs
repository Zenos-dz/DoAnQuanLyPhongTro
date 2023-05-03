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
            this.bcsvc = new System.Windows.Forms.Button();
            this.a1phongtro = new System.Windows.Forms.Button();
            this.a5hoadon = new System.Windows.Forms.Button();
            this.a4sodiennuoc = new System.Windows.Forms.Button();
            this.a3hopdong = new System.Windows.Forms.Button();
            this.a2nguoithue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CLOCK = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.logo_main = new System.Windows.Forms.PictureBox();
            this.TimerForMainClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_main)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.bcsvc);
            this.splitContainer1.Panel1.Controls.Add(this.a5hoadon);
            this.splitContainer1.Panel1.Controls.Add(this.a4sodiennuoc);
            this.splitContainer1.Panel1.Controls.Add(this.a3hopdong);
            this.splitContainer1.Panel1.Controls.Add(this.a2nguoithue);
            this.splitContainer1.Panel1.Controls.Add(this.a1phongtro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(946, 467);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 8;
            // 
            // bcsvc
            // 
            this.bcsvc.BackColor = System.Drawing.Color.Snow;
            this.bcsvc.CausesValidation = false;
            this.bcsvc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcsvc.Dock = System.Windows.Forms.DockStyle.Top;
            this.bcsvc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.bcsvc.Location = new System.Drawing.Point(0, 320);
            this.bcsvc.Margin = new System.Windows.Forms.Padding(2);
            this.bcsvc.Name = "bcsvc";
            this.bcsvc.Size = new System.Drawing.Size(176, 64);
            this.bcsvc.TabIndex = 10;
            this.bcsvc.Text = "Cơ sở vật chất";
            this.bcsvc.UseVisualStyleBackColor = false;
            this.bcsvc.Click += new System.EventHandler(this.cosovchat);
            // 
            // a1phongtro
            // 
            this.a1phongtro.BackColor = System.Drawing.Color.Snow;
            this.a1phongtro.CausesValidation = false;
            this.a1phongtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a1phongtro.Dock = System.Windows.Forms.DockStyle.Top;
            this.a1phongtro.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a1phongtro.Location = new System.Drawing.Point(0, 0);
            this.a1phongtro.Margin = new System.Windows.Forms.Padding(2);
            this.a1phongtro.Name = "a1phongtro";
            this.a1phongtro.Size = new System.Drawing.Size(176, 64);
            this.a1phongtro.TabIndex = 0;
            this.a1phongtro.Text = "Phòng trọ";
            this.a1phongtro.UseVisualStyleBackColor = false;
            this.a1phongtro.Click += new System.EventHandler(this.phongtro);
            // 
            // a5hoadon
            // 
            this.a5hoadon.BackColor = System.Drawing.Color.Snow;
            this.a5hoadon.CausesValidation = false;
            this.a5hoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a5hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.a5hoadon.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a5hoadon.Location = new System.Drawing.Point(0, 256);
            this.a5hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.a5hoadon.Name = "a5hoadon";
            this.a5hoadon.Size = new System.Drawing.Size(176, 64);
            this.a5hoadon.TabIndex = 9;
            this.a5hoadon.Text = "Hoá đơn";
            this.a5hoadon.UseVisualStyleBackColor = false;
            this.a5hoadon.Click += new System.EventHandler(this.hoadon);
            // 
            // a4sodiennuoc
            // 
            this.a4sodiennuoc.BackColor = System.Drawing.Color.Snow;
            this.a4sodiennuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a4sodiennuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.a4sodiennuoc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a4sodiennuoc.Location = new System.Drawing.Point(0, 192);
            this.a4sodiennuoc.Margin = new System.Windows.Forms.Padding(2);
            this.a4sodiennuoc.Name = "a4sodiennuoc";
            this.a4sodiennuoc.Size = new System.Drawing.Size(176, 64);
            this.a4sodiennuoc.TabIndex = 6;
            this.a4sodiennuoc.Text = "Số điện nước";
            this.a4sodiennuoc.UseVisualStyleBackColor = false;
            this.a4sodiennuoc.Click += new System.EventHandler(this.sdn_Click);
            // 
            // a3hopdong
            // 
            this.a3hopdong.BackColor = System.Drawing.Color.Snow;
            this.a3hopdong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a3hopdong.Dock = System.Windows.Forms.DockStyle.Top;
            this.a3hopdong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3hopdong.Location = new System.Drawing.Point(0, 128);
            this.a3hopdong.Margin = new System.Windows.Forms.Padding(2);
            this.a3hopdong.Name = "a3hopdong";
            this.a3hopdong.Size = new System.Drawing.Size(176, 64);
            this.a3hopdong.TabIndex = 0;
            this.a3hopdong.Text = "Hợp đồng";
            this.a3hopdong.UseVisualStyleBackColor = false;
            this.a3hopdong.Click += new System.EventHandler(this.hopdong);
            // 
            // a2nguoithue
            // 
            this.a2nguoithue.BackColor = System.Drawing.Color.Snow;
            this.a2nguoithue.CausesValidation = false;
            this.a2nguoithue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a2nguoithue.Dock = System.Windows.Forms.DockStyle.Top;
            this.a2nguoithue.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a2nguoithue.Location = new System.Drawing.Point(0, 64);
            this.a2nguoithue.Margin = new System.Windows.Forms.Padding(2);
            this.a2nguoithue.Name = "a2nguoithue";
            this.a2nguoithue.Size = new System.Drawing.Size(176, 64);
            this.a2nguoithue.TabIndex = 1;
            this.a2nguoithue.Text = "Người thuê";
            this.a2nguoithue.UseVisualStyleBackColor = false;
            this.a2nguoithue.Click += new System.EventHandler(this.nguoithuetro);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CLOCK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 467);
            this.panel1.TabIndex = 0;
            // 
            // CLOCK
            // 
            this.CLOCK.AutoSize = true;
            this.CLOCK.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOCK.Location = new System.Drawing.Point(228, 274);
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
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.logo_main);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 80);
            this.panel2.TabIndex = 9;
            // 
            // logout
            // 
            this.logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logout.Location = new System.Drawing.Point(817, 0);
            this.logout.Margin = new System.Windows.Forms.Padding(0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(129, 80);
            this.logout.TabIndex = 1;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // logo_main
            // 
            this.logo_main.BackColor = System.Drawing.Color.Transparent;
            this.logo_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo_main.ErrorImage = global::Doancs.Properties.Resources.QHL;
            this.logo_main.Image = global::Doancs.Properties.Resources.QHL;
            this.logo_main.Location = new System.Drawing.Point(0, 0);
            this.logo_main.Margin = new System.Windows.Forms.Padding(0);
            this.logo_main.Name = "logo_main";
            this.logo_main.Size = new System.Drawing.Size(177, 80);
            this.logo_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_main.TabIndex = 0;
            this.logo_main.TabStop = false;
            // 
            // TimerForMainClock
            // 
            this.TimerForMainClock.Tick += new System.EventHandler(this.TimerForMainClock_Tick);
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
    }
}

