namespace Doancs
{
    partial class sqlclient_cosovatchat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sqlclient_cosovatchat));
            this.bangcosovatchat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmaphong = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.dieuhoa = new System.Windows.Forms.ComboBox();
            this.quatdien = new System.Windows.Forms.ComboBox();
            this.binhnonglanh = new System.Windows.Forms.ComboBox();
            this.tulanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bangcosovatchat)).BeginInit();
            this.SuspendLayout();
            // 
            // bangcosovatchat
            // 
            this.bangcosovatchat.AllowUserToAddRows = false;
            this.bangcosovatchat.AllowUserToDeleteRows = false;
            this.bangcosovatchat.AllowUserToOrderColumns = true;
            this.bangcosovatchat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangcosovatchat.Location = new System.Drawing.Point(429, 38);
            this.bangcosovatchat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bangcosovatchat.Name = "bangcosovatchat";
            this.bangcosovatchat.ReadOnly = true;
            this.bangcosovatchat.RowHeadersWidth = 51;
            this.bangcosovatchat.RowTemplate.Height = 24;
            this.bangcosovatchat.Size = new System.Drawing.Size(563, 500);
            this.bangcosovatchat.TabIndex = 0;
            this.bangcosovatchat.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangcosovatchat_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(67, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điều hoà";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(60, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quạt điện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(79, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tủ lạnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bình nóng lạnh";
            // 
            // tbmaphong
            // 
            this.tbmaphong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmaphong.Location = new System.Drawing.Point(168, 49);
            this.tbmaphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmaphong.Name = "tbmaphong";
            this.tbmaphong.Size = new System.Drawing.Size(220, 30);
            this.tbmaphong.TabIndex = 0;
            // 
            // bCancel
            // 
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(27, 486);
            this.bCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(96, 30);
            this.bCancel.TabIndex = 17;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(27, 431);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(96, 30);
            this.bAdd.TabIndex = 14;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.Location = new System.Drawing.Point(168, 431);
            this.bEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(96, 30);
            this.bEdit.TabIndex = 15;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bFind
            // 
            this.bFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFind.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFind.Location = new System.Drawing.Point(306, 486);
            this.bFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(96, 30);
            this.bFind.TabIndex = 19;
            this.bFind.Text = "Find";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // bDelete
            // 
            this.bDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(168, 486);
            this.bDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(96, 30);
            this.bDelete.TabIndex = 18;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(306, 431);
            this.bSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(96, 30);
            this.bSave.TabIndex = 16;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dieuhoa
            // 
            this.dieuhoa.FormattingEnabled = true;
            this.dieuhoa.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.dieuhoa.Location = new System.Drawing.Point(168, 127);
            this.dieuhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dieuhoa.Name = "dieuhoa";
            this.dieuhoa.Size = new System.Drawing.Size(220, 24);
            this.dieuhoa.TabIndex = 21;
            this.dieuhoa.Text = "Lựa chọn";
            // 
            // quatdien
            // 
            this.quatdien.FormattingEnabled = true;
            this.quatdien.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.quatdien.Location = new System.Drawing.Point(168, 197);
            this.quatdien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quatdien.Name = "quatdien";
            this.quatdien.Size = new System.Drawing.Size(220, 24);
            this.quatdien.TabIndex = 22;
            this.quatdien.Text = "Lựa chọn";
            // 
            // binhnonglanh
            // 
            this.binhnonglanh.FormattingEnabled = true;
            this.binhnonglanh.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.binhnonglanh.Location = new System.Drawing.Point(168, 335);
            this.binhnonglanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.binhnonglanh.Name = "binhnonglanh";
            this.binhnonglanh.Size = new System.Drawing.Size(220, 24);
            this.binhnonglanh.TabIndex = 24;
            this.binhnonglanh.Text = "Lựa chọn";
            // 
            // tulanh
            // 
            this.tulanh.FormattingEnabled = true;
            this.tulanh.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.tulanh.Location = new System.Drawing.Point(168, 265);
            this.tulanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tulanh.Name = "tulanh";
            this.tulanh.Size = new System.Drawing.Size(220, 24);
            this.tulanh.TabIndex = 23;
            this.tulanh.Text = "Lựa chọn";
            // 
            // cosovatchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 575);
            this.Controls.Add(this.binhnonglanh);
            this.Controls.Add(this.tulanh);
            this.Controls.Add(this.quatdien);
            this.Controls.Add(this.dieuhoa);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbmaphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bangcosovatchat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cosovatchat";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cosovatchat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangcosovatchat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bangcosovatchat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbmaphong;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ComboBox dieuhoa;
        private System.Windows.Forms.ComboBox quatdien;
        private System.Windows.Forms.ComboBox binhnonglanh;
        private System.Windows.Forms.ComboBox tulanh;
    }
}