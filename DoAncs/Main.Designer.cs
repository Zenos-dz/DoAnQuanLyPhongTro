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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bcsvc = new System.Windows.Forms.Button();
            this.a1phongtro = new System.Windows.Forms.Button();
            this.a5hoadon = new System.Windows.Forms.Button();
            this.a2nguoithue = new System.Windows.Forms.Button();
            this.a4sodiennuoc = new System.Windows.Forms.Button();
            this.a3hopdong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CLOCK = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TimerForMainClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DarkCyan;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1261, 98);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 98);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.bcsvc);
            this.splitContainer1.Panel1.Controls.Add(this.a1phongtro);
            this.splitContainer1.Panel1.Controls.Add(this.a5hoadon);
            this.splitContainer1.Panel1.Controls.Add(this.a2nguoithue);
            this.splitContainer1.Panel1.Controls.Add(this.a4sodiennuoc);
            this.splitContainer1.Panel1.Controls.Add(this.a3hopdong);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1261, 575);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 8;
            // 
            // bcsvc
            // 
            this.bcsvc.BackColor = System.Drawing.Color.Snow;
            this.bcsvc.CausesValidation = false;
            this.bcsvc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcsvc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.bcsvc.Location = new System.Drawing.Point(1, 171);
            this.bcsvc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bcsvc.Name = "bcsvc";
            this.bcsvc.Size = new System.Drawing.Size(233, 79);
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
            this.a1phongtro.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a1phongtro.Location = new System.Drawing.Point(1, 5);
            this.a1phongtro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a1phongtro.Name = "a1phongtro";
            this.a1phongtro.Size = new System.Drawing.Size(233, 79);
            this.a1phongtro.TabIndex = 5;
            this.a1phongtro.Text = "Phòng trọ";
            this.a1phongtro.UseVisualStyleBackColor = false;
            this.a1phongtro.Click += new System.EventHandler(this.phongtro);
            // 
            // a5hoadon
            // 
            this.a5hoadon.BackColor = System.Drawing.Color.Snow;
            this.a5hoadon.CausesValidation = false;
            this.a5hoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a5hoadon.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a5hoadon.Location = new System.Drawing.Point(1, 337);
            this.a5hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a5hoadon.Name = "a5hoadon";
            this.a5hoadon.Size = new System.Drawing.Size(233, 79);
            this.a5hoadon.TabIndex = 9;
            this.a5hoadon.Text = "Hoá đơn";
            this.a5hoadon.UseVisualStyleBackColor = false;
            this.a5hoadon.Click += new System.EventHandler(this.hoadon);
            // 
            // a2nguoithue
            // 
            this.a2nguoithue.BackColor = System.Drawing.Color.Snow;
            this.a2nguoithue.CausesValidation = false;
            this.a2nguoithue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a2nguoithue.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a2nguoithue.Location = new System.Drawing.Point(1, 89);
            this.a2nguoithue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a2nguoithue.Name = "a2nguoithue";
            this.a2nguoithue.Size = new System.Drawing.Size(233, 79);
            this.a2nguoithue.TabIndex = 8;
            this.a2nguoithue.Text = "Người thuê";
            this.a2nguoithue.UseVisualStyleBackColor = false;
            this.a2nguoithue.Click += new System.EventHandler(this.nguoithuetro);
            // 
            // a4sodiennuoc
            // 
            this.a4sodiennuoc.BackColor = System.Drawing.Color.Snow;
            this.a4sodiennuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a4sodiennuoc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a4sodiennuoc.Location = new System.Drawing.Point(1, 254);
            this.a4sodiennuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a4sodiennuoc.Name = "a4sodiennuoc";
            this.a4sodiennuoc.Size = new System.Drawing.Size(233, 79);
            this.a4sodiennuoc.TabIndex = 6;
            this.a4sodiennuoc.Text = "Số điện nước";
            this.a4sodiennuoc.UseVisualStyleBackColor = false;
            this.a4sodiennuoc.Click += new System.EventHandler(this.sdn_Click);
            // 
            // a3hopdong
            // 
            this.a3hopdong.BackColor = System.Drawing.Color.Snow;
            this.a3hopdong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a3hopdong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3hopdong.Location = new System.Drawing.Point(1, 420);
            this.a3hopdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a3hopdong.Name = "a3hopdong";
            this.a3hopdong.Size = new System.Drawing.Size(233, 79);
            this.a3hopdong.TabIndex = 0;
            this.a3hopdong.Text = "Hợp đồng";
            this.a3hopdong.UseVisualStyleBackColor = false;
            this.a3hopdong.Click += new System.EventHandler(this.hopdong);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CLOCK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 575);
            this.panel1.TabIndex = 0;
            // 
            // CLOCK
            // 
            this.CLOCK.AutoSize = true;
            this.CLOCK.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOCK.Location = new System.Drawing.Point(304, 337);
            this.CLOCK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CLOCK.Name = "CLOCK";
            this.CLOCK.Size = new System.Drawing.Size(387, 106);
            this.CLOCK.TabIndex = 0;
            this.CLOCK.Text = "hh:mm:ss";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 98);
            this.panel2.TabIndex = 9;
            // 
            // TimerForMainClock
            // 
            this.TimerForMainClock.Tick += new System.EventHandler(this.TimerForMainClock_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Main";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bcsvc;
        private System.Windows.Forms.Button a5hoadon;
        private System.Windows.Forms.Button a2nguoithue;
        private System.Windows.Forms.Button a4sodiennuoc;
        private System.Windows.Forms.Button a3hopdong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button a1phongtro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CLOCK;
        private System.Windows.Forms.Timer TimerForMainClock;
    }
}

