namespace Doancs
{
    partial class HopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HopDong));
            this.ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.ngaythue = new System.Windows.Forms.DateTimePicker();
            this.tbmanguoithue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmaphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.banghopdong = new System.Windows.Forms.DataGridView();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.banghopdong)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayketthuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayketthuc.Location = new System.Drawing.Point(165, 350);
            this.ngayketthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Size = new System.Drawing.Size(215, 27);
            this.ngayketthuc.TabIndex = 4;
            // 
            // ngaythue
            // 
            this.ngaythue.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaythue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaythue.Location = new System.Drawing.Point(165, 271);
            this.ngaythue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngaythue.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.ngaythue.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ngaythue.Name = "ngaythue";
            this.ngaythue.Size = new System.Drawing.Size(215, 27);
            this.ngaythue.TabIndex = 3;
            // 
            // tbmanguoithue
            // 
            this.tbmanguoithue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmanguoithue.Location = new System.Drawing.Point(165, 194);
            this.tbmanguoithue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmanguoithue.Name = "tbmanguoithue";
            this.tbmanguoithue.Size = new System.Drawing.Size(215, 30);
            this.tbmanguoithue.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(18, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(45, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã người thuê";
            // 
            // tbmaphong
            // 
            this.tbmaphong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmaphong.Location = new System.Drawing.Point(165, 124);
            this.tbmaphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmaphong.Name = "tbmaphong";
            this.tbmaphong.Size = new System.Drawing.Size(215, 30);
            this.tbmaphong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Phòng";
            // 
            // tbmahd
            // 
            this.tbmahd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmahd.Location = new System.Drawing.Point(165, 54);
            this.tbmahd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmahd.Name = "tbmahd";
            this.tbmahd.Size = new System.Drawing.Size(215, 30);
            this.tbmahd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hợp đồng";
            // 
            // banghopdong
            // 
            this.banghopdong.AllowUserToAddRows = false;
            this.banghopdong.AllowUserToDeleteRows = false;
            this.banghopdong.AllowUserToOrderColumns = true;
            this.banghopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banghopdong.Location = new System.Drawing.Point(429, 38);
            this.banghopdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banghopdong.Name = "banghopdong";
            this.banghopdong.ReadOnly = true;
            this.banghopdong.RowHeadersWidth = 51;
            this.banghopdong.RowTemplate.Height = 24;
            this.banghopdong.Size = new System.Drawing.Size(563, 500);
            this.banghopdong.TabIndex = 5;
            this.banghopdong.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.banghopdong_CellEnter);
            // 
            // bCancel
            // 
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(37, 490);
            this.bCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(96, 30);
            this.bCancel.TabIndex = 23;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(37, 436);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(96, 30);
            this.bAdd.TabIndex = 20;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.Location = new System.Drawing.Point(165, 436);
            this.bEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(96, 30);
            this.bEdit.TabIndex = 21;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bFind
            // 
            this.bFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFind.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFind.Location = new System.Drawing.Point(291, 490);
            this.bFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(96, 30);
            this.bFind.TabIndex = 25;
            this.bFind.Text = "Find";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // bDelete
            // 
            this.bDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(165, 490);
            this.bDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(96, 30);
            this.bDelete.TabIndex = 24;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(291, 436);
            this.bSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(96, 30);
            this.bSave.TabIndex = 22;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 574);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.ngayketthuc);
            this.Controls.Add(this.ngaythue);
            this.Controls.Add(this.tbmahd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbmanguoithue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbmaphong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.banghopdong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.HopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banghopdong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView banghopdong;
        private System.Windows.Forms.TextBox tbmaphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmahd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker ngaythue;
        private System.Windows.Forms.TextBox tbmanguoithue;
        private System.Windows.Forms.DateTimePicker ngayketthuc;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
    }
}