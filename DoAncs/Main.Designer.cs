﻿namespace Doancs
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
            this.button4 = new System.Windows.Forms.Button();
            this.a1phongtro = new System.Windows.Forms.Button();
            this.a5hoadon = new System.Windows.Forms.Button();
            this.a2nguoithue = new System.Windows.Forms.Button();
            this.a4sodiennuoc = new System.Windows.Forms.Button();
            this.a3hopdong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CLOCK = new System.Windows.Forms.Label();
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
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(946, 80);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.a1phongtro);
            this.splitContainer1.Panel1.Controls.Add(this.a5hoadon);
            this.splitContainer1.Panel1.Controls.Add(this.a2nguoithue);
            this.splitContainer1.Panel1.Controls.Add(this.a4sodiennuoc);
            this.splitContainer1.Panel1.Controls.Add(this.a3hopdong);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(946, 467);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.CausesValidation = false;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.button4.Location = new System.Drawing.Point(1, 139);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 64);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cơ sở vật chất";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // a1phongtro
            // 
            this.a1phongtro.BackColor = System.Drawing.Color.Snow;
            this.a1phongtro.CausesValidation = false;
            this.a1phongtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a1phongtro.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a1phongtro.Location = new System.Drawing.Point(1, 4);
            this.a1phongtro.Margin = new System.Windows.Forms.Padding(2);
            this.a1phongtro.Name = "a1phongtro";
            this.a1phongtro.Size = new System.Drawing.Size(175, 64);
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
            this.a5hoadon.Location = new System.Drawing.Point(1, 274);
            this.a5hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.a5hoadon.Name = "a5hoadon";
            this.a5hoadon.Size = new System.Drawing.Size(175, 64);
            this.a5hoadon.TabIndex = 9;
            this.a5hoadon.Text = "Hoá đơn";
            this.a5hoadon.UseVisualStyleBackColor = false;
            this.a5hoadon.Click += new System.EventHandler(this.button6_Click);
            // 
            // a2nguoithue
            // 
            this.a2nguoithue.BackColor = System.Drawing.Color.Snow;
            this.a2nguoithue.CausesValidation = false;
            this.a2nguoithue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a2nguoithue.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.a2nguoithue.Location = new System.Drawing.Point(1, 72);
            this.a2nguoithue.Margin = new System.Windows.Forms.Padding(2);
            this.a2nguoithue.Name = "a2nguoithue";
            this.a2nguoithue.Size = new System.Drawing.Size(175, 64);
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
            this.a4sodiennuoc.Location = new System.Drawing.Point(1, 206);
            this.a4sodiennuoc.Margin = new System.Windows.Forms.Padding(2);
            this.a4sodiennuoc.Name = "a4sodiennuoc";
            this.a4sodiennuoc.Size = new System.Drawing.Size(175, 64);
            this.a4sodiennuoc.TabIndex = 6;
            this.a4sodiennuoc.Text = "Số điện nước";
            this.a4sodiennuoc.UseVisualStyleBackColor = false;
            this.a4sodiennuoc.Click += new System.EventHandler(this.button3_Click);
            // 
            // a3hopdong
            // 
            this.a3hopdong.BackColor = System.Drawing.Color.Snow;
            this.a3hopdong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a3hopdong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3hopdong.Location = new System.Drawing.Point(1, 341);
            this.a3hopdong.Margin = new System.Windows.Forms.Padding(2);
            this.a3hopdong.Name = "a3hopdong";
            this.a3hopdong.Size = new System.Drawing.Size(175, 64);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 467);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 80);
            this.panel2.TabIndex = 9;
            // 
            // CLOCK
            // 
            this.CLOCK.AutoSize = true;
            this.CLOCK.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOCK.Location = new System.Drawing.Point(257, 274);
            this.CLOCK.Name = "CLOCK";
            this.CLOCK.Size = new System.Drawing.Size(311, 86);
            this.CLOCK.TabIndex = 0;
            this.CLOCK.Text = "hh:mm:ss";
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
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
        private System.Windows.Forms.Button button4;
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

