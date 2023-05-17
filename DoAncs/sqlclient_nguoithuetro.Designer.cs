namespace Doancs
{
    partial class sqlclient_nguoithuetro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sqlclient_nguoithuetro));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbmanguoithue = new System.Windows.Forms.TextBox();
            this.tbcmnd = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbgioitinh = new System.Windows.Forms.TextBox();
            this.tbtennguoithue = new System.Windows.Forms.TextBox();
            this.bangnguoithuetro = new System.Windows.Forms.DataGridView();
            this.bAdd = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bangnguoithuetro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã người thuê:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(68, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cmnd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(83, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sđt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(45, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(53, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(16, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên người thuê:";
            // 
            // tbmanguoithue
            // 
            this.tbmanguoithue.BackColor = System.Drawing.Color.Azure;
            this.tbmanguoithue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmanguoithue.Location = new System.Drawing.Point(122, 28);
            this.tbmanguoithue.Name = "tbmanguoithue";
            this.tbmanguoithue.Size = new System.Drawing.Size(173, 26);
            this.tbmanguoithue.TabIndex = 0;
            // 
            // tbcmnd
            // 
            this.tbcmnd.BackColor = System.Drawing.Color.Azure;
            this.tbcmnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcmnd.Location = new System.Drawing.Point(122, 295);
            this.tbcmnd.Name = "tbcmnd";
            this.tbcmnd.Size = new System.Drawing.Size(173, 26);
            this.tbcmnd.TabIndex = 5;
            // 
            // tbsdt
            // 
            this.tbsdt.BackColor = System.Drawing.Color.Azure;
            this.tbsdt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsdt.Location = new System.Drawing.Point(122, 241);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(173, 26);
            this.tbsdt.TabIndex = 4;
            // 
            // tbgioitinh
            // 
            this.tbgioitinh.BackColor = System.Drawing.Color.Azure;
            this.tbgioitinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgioitinh.Location = new System.Drawing.Point(122, 133);
            this.tbgioitinh.Name = "tbgioitinh";
            this.tbgioitinh.Size = new System.Drawing.Size(173, 26);
            this.tbgioitinh.TabIndex = 2;
            // 
            // tbtennguoithue
            // 
            this.tbtennguoithue.BackColor = System.Drawing.Color.Azure;
            this.tbtennguoithue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtennguoithue.Location = new System.Drawing.Point(122, 77);
            this.tbtennguoithue.Name = "tbtennguoithue";
            this.tbtennguoithue.Size = new System.Drawing.Size(173, 26);
            this.tbtennguoithue.TabIndex = 1;
            // 
            // bangnguoithuetro
            // 
            this.bangnguoithuetro.AllowUserToAddRows = false;
            this.bangnguoithuetro.AllowUserToDeleteRows = false;
            this.bangnguoithuetro.AllowUserToOrderColumns = true;
            this.bangnguoithuetro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangnguoithuetro.Location = new System.Drawing.Point(322, 31);
            this.bangnguoithuetro.Name = "bangnguoithuetro";
            this.bangnguoithuetro.ReadOnly = true;
            this.bangnguoithuetro.RowHeadersWidth = 51;
            this.bangnguoithuetro.Size = new System.Drawing.Size(422, 406);
            this.bangnguoithuetro.TabIndex = 14;
            this.bangnguoithuetro.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangnguoithuetro_CellEnter);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Azure;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAdd.Location = new System.Drawing.Point(40, 358);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(60, 23);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bFind
            // 
            this.bFind.BackColor = System.Drawing.Color.Transparent;
            this.bFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFind.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bFind.Location = new System.Drawing.Point(234, 417);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(60, 23);
            this.bFind.TabIndex = 12;
            this.bFind.Text = "Find";
            this.bFind.UseVisualStyleBackColor = false;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bCancel.Location = new System.Drawing.Point(138, 417);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(60, 23);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Transparent;
            this.bDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bDelete.Location = new System.Drawing.Point(40, 417);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(60, 23);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Transparent;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSave.Location = new System.Drawing.Point(234, 358);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(60, 23);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.Transparent;
            this.bEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bEdit.Location = new System.Drawing.Point(140, 358);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(60, 23);
            this.bEdit.TabIndex = 8;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(122, 187);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(173, 20);
            this.ngaysinh.TabIndex = 15;
            // 
            // sqlclient_nguoithuetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(764, 467);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bangnguoithuetro);
            this.Controls.Add(this.tbtennguoithue);
            this.Controls.Add(this.tbgioitinh);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.tbcmnd);
            this.Controls.Add(this.tbmanguoithue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sqlclient_nguoithuetro";
            this.Text = "sqlclient_nguoithuetro";
            this.Load += new System.EventHandler(this.nguoithuetro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangnguoithuetro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbmanguoithue;
        private System.Windows.Forms.TextBox tbcmnd;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbgioitinh;
        private System.Windows.Forms.TextBox tbtennguoithue;
        private System.Windows.Forms.DataGridView bangnguoithuetro;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEdit;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker ngaysinh;
    }
}