namespace Doancs
{
    partial class Report_Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmaphong = new System.Windows.Forms.TextBox();
            this.tbgiadien = new System.Windows.Forms.TextBox();
            this.tbgianuoc = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá nước(vnđ)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá điện(vnđ)";
            // 
            // tbmaphong
            // 
            this.tbmaphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmaphong.Location = new System.Drawing.Point(175, 72);
            this.tbmaphong.Name = "tbmaphong";
            this.tbmaphong.Size = new System.Drawing.Size(204, 29);
            this.tbmaphong.TabIndex = 3;
            // 
            // tbgiadien
            // 
            this.tbgiadien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgiadien.Location = new System.Drawing.Point(175, 114);
            this.tbgiadien.Name = "tbgiadien";
            this.tbgiadien.Size = new System.Drawing.Size(204, 29);
            this.tbgiadien.TabIndex = 4;
            // 
            // tbgianuoc
            // 
            this.tbgianuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgianuoc.Location = new System.Drawing.Point(175, 161);
            this.tbgianuoc.Name = "tbgianuoc";
            this.tbgianuoc.Size = new System.Drawing.Size(204, 29);
            this.tbgianuoc.TabIndex = 5;
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(192, 229);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(151, 44);
            this.run.TabIndex = 6;
            this.run.Text = "Tạo hóa đơn";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // Report_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 346);
            this.Controls.Add(this.run);
            this.Controls.Add(this.tbgianuoc);
            this.Controls.Add(this.tbgiadien);
            this.Controls.Add(this.tbmaphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Report_Start";
            this.Text = "Report_Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmaphong;
        private System.Windows.Forms.TextBox tbgiadien;
        private System.Windows.Forms.TextBox tbgianuoc;
        private System.Windows.Forms.Button run;
    }
}