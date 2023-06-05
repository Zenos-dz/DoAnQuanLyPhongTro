namespace Doancs
{
    partial class form_doimatkhau
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
            this.tboldpass = new System.Windows.Forms.TextBox();
            this.tbnewpass2 = new System.Windows.Forms.TextBox();
            this.tbnewpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.lbnewpass = new System.Windows.Forms.Label();
            this.lbnewpassmatch = new System.Windows.Forms.Label();
            this.lboldpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboldpass
            // 
            this.tboldpass.Location = new System.Drawing.Point(265, 135);
            this.tboldpass.Name = "tboldpass";
            this.tboldpass.Size = new System.Drawing.Size(178, 20);
            this.tboldpass.TabIndex = 1;
            // 
            // tbnewpass2
            // 
            this.tbnewpass2.Location = new System.Drawing.Point(265, 205);
            this.tbnewpass2.Name = "tbnewpass2";
            this.tbnewpass2.Size = new System.Drawing.Size(178, 20);
            this.tbnewpass2.TabIndex = 3;
            this.tbnewpass2.TextChanged += new System.EventHandler(this.tbnewpass2_TextChanged);
            // 
            // tbnewpass
            // 
            this.tbnewpass.Location = new System.Drawing.Point(265, 169);
            this.tbnewpass.Name = "tbnewpass";
            this.tbnewpass.Size = new System.Drawing.Size(178, 20);
            this.tbnewpass.TabIndex = 2;
            this.tbnewpass.TextChanged += new System.EventHandler(this.tbnewpass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(282, 260);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(133, 47);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Lưu";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lbnewpass
            // 
            this.lbnewpass.AutoSize = true;
            this.lbnewpass.Location = new System.Drawing.Point(461, 176);
            this.lbnewpass.Name = "lbnewpass";
            this.lbnewpass.Size = new System.Drawing.Size(10, 13);
            this.lbnewpass.TabIndex = 8;
            this.lbnewpass.Text = " ";
            // 
            // lbnewpassmatch
            // 
            this.lbnewpassmatch.AutoSize = true;
            this.lbnewpassmatch.Location = new System.Drawing.Point(461, 212);
            this.lbnewpassmatch.Name = "lbnewpassmatch";
            this.lbnewpassmatch.Size = new System.Drawing.Size(10, 13);
            this.lbnewpassmatch.TabIndex = 9;
            this.lbnewpassmatch.Text = " \r\n";
            // 
            // lboldpass
            // 
            this.lboldpass.AutoSize = true;
            this.lboldpass.Location = new System.Drawing.Point(461, 142);
            this.lboldpass.Name = "lboldpass";
            this.lboldpass.Size = new System.Drawing.Size(10, 13);
            this.lboldpass.TabIndex = 10;
            this.lboldpass.Text = " ";
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 467);
            this.Controls.Add(this.lboldpass);
            this.Controls.Add(this.lbnewpassmatch);
            this.Controls.Add(this.lbnewpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbnewpass2);
            this.Controls.Add(this.tbnewpass);
            this.Controls.Add(this.tboldpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboldpass;
        private System.Windows.Forms.TextBox tbnewpass2;
        private System.Windows.Forms.TextBox tbnewpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lbnewpass;
        private System.Windows.Forms.Label lbnewpassmatch;
        private System.Windows.Forms.Label lboldpass;
    }
}