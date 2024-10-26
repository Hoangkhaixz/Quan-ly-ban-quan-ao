namespace Quan_ly_ban_quan_ao
{
    partial class FormUser
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtB_searchSP = new System.Windows.Forms.TextBox();
            this.GrView_spUser = new System.Windows.Forms.DataGridView();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_idSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_nameSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB_idUser = new System.Windows.Forms.TextBox();
            this.txtB_sizeSP = new System.Windows.Forms.TextBox();
            this.txtB_sellSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtB_inventorySP = new System.Windows.Forms.TextBox();
            this.txtB_Quantity = new System.Windows.Forms.TextBox();
            this.picB_imageProduct = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtB_nameUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrView_spUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_imageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "FORM USER";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(185, 147);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 22);
            this.textBox2.TabIndex = 11;
            // 
            // txtB_searchSP
            // 
            this.txtB_searchSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_searchSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_searchSP.ForeColor = System.Drawing.SystemColors.Info;
            this.txtB_searchSP.Location = new System.Drawing.Point(512, 78);
            this.txtB_searchSP.Multiline = true;
            this.txtB_searchSP.Name = "txtB_searchSP";
            this.txtB_searchSP.Size = new System.Drawing.Size(274, 28);
            this.txtB_searchSP.TabIndex = 12;
            // 
            // GrView_spUser
            // 
            this.GrView_spUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrView_spUser.Location = new System.Drawing.Point(-2, 112);
            this.GrView_spUser.Name = "GrView_spUser";
            this.GrView_spUser.RowHeadersWidth = 51;
            this.GrView_spUser.Size = new System.Drawing.Size(569, 511);
            this.GrView_spUser.TabIndex = 13;
            this.GrView_spUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrView_spUser_CellClick);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(626, 575);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(87, 38);
            this.btn_pay.TabIndex = 33;
            this.btn_pay.Text = "PAY";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(803, 78);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 28);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "IDProduct:";
            // 
            // txtB_idSP
            // 
            this.txtB_idSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_idSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_idSP.ForeColor = System.Drawing.SystemColors.Info;
            this.txtB_idSP.Location = new System.Drawing.Point(687, 127);
            this.txtB_idSP.Multiline = true;
            this.txtB_idSP.Name = "txtB_idSP";
            this.txtB_idSP.Size = new System.Drawing.Size(132, 24);
            this.txtB_idSP.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Name:";
            // 
            // txtB_nameSP
            // 
            this.txtB_nameSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_nameSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_nameSP.ForeColor = System.Drawing.SystemColors.Info;
            this.txtB_nameSP.Location = new System.Drawing.Point(687, 172);
            this.txtB_nameSP.Multiline = true;
            this.txtB_nameSP.Name = "txtB_nameSP";
            this.txtB_nameSP.Size = new System.Drawing.Size(132, 24);
            this.txtB_nameSP.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Selling:";
            // 
            // txtB_idUser
            // 
            this.txtB_idUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtB_idUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_idUser.Location = new System.Drawing.Point(12, 78);
            this.txtB_idUser.Multiline = true;
            this.txtB_idUser.Name = "txtB_idUser";
            this.txtB_idUser.Size = new System.Drawing.Size(194, 28);
            this.txtB_idUser.TabIndex = 42;
            // 
            // txtB_sizeSP
            // 
            this.txtB_sizeSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_sizeSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_sizeSP.ForeColor = System.Drawing.SystemColors.Info;
            this.txtB_sizeSP.Location = new System.Drawing.Point(687, 436);
            this.txtB_sizeSP.Multiline = true;
            this.txtB_sizeSP.Name = "txtB_sizeSP";
            this.txtB_sizeSP.Size = new System.Drawing.Size(132, 24);
            this.txtB_sizeSP.TabIndex = 43;
            // 
            // txtB_sellSP
            // 
            this.txtB_sellSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_sellSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_sellSP.ForeColor = System.Drawing.SystemColors.Info;
            this.txtB_sellSP.Location = new System.Drawing.Point(687, 486);
            this.txtB_sellSP.Multiline = true;
            this.txtB_sellSP.Name = "txtB_sellSP";
            this.txtB_sellSP.Size = new System.Drawing.Size(132, 24);
            this.txtB_sellSP.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(587, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Inventory: ";
            // 
            // txtB_inventorySP
            // 
            this.txtB_inventorySP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_inventorySP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_inventorySP.ForeColor = System.Drawing.SystemColors.Info;
            this.txtB_inventorySP.Location = new System.Drawing.Point(687, 540);
            this.txtB_inventorySP.Multiline = true;
            this.txtB_inventorySP.Name = "txtB_inventorySP";
            this.txtB_inventorySP.Size = new System.Drawing.Size(132, 24);
            this.txtB_inventorySP.TabIndex = 46;
            // 
            // txtB_Quantity
            // 
            this.txtB_Quantity.Location = new System.Drawing.Point(736, 580);
            this.txtB_Quantity.Multiline = true;
            this.txtB_Quantity.Name = "txtB_Quantity";
            this.txtB_Quantity.Size = new System.Drawing.Size(100, 28);
            this.txtB_Quantity.TabIndex = 47;
            // 
            // picB_imageProduct
            // 
            this.picB_imageProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picB_imageProduct.Location = new System.Drawing.Point(593, 217);
            this.picB_imageProduct.Name = "picB_imageProduct";
            this.picB_imageProduct.Size = new System.Drawing.Size(260, 205);
            this.picB_imageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_imageProduct.TabIndex = 37;
            this.picB_imageProduct.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(915, 72);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // txtB_nameUser
            // 
            this.txtB_nameUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtB_nameUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_nameUser.Location = new System.Drawing.Point(195, 78);
            this.txtB_nameUser.Multiline = true;
            this.txtB_nameUser.Name = "txtB_nameUser";
            this.txtB_nameUser.Size = new System.Drawing.Size(194, 28);
            this.txtB_nameUser.TabIndex = 48;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 620);
            this.Controls.Add(this.txtB_nameUser);
            this.Controls.Add(this.txtB_Quantity);
            this.Controls.Add(this.txtB_inventorySP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtB_sellSP);
            this.Controls.Add(this.txtB_sizeSP);
            this.Controls.Add(this.txtB_idUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB_nameSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picB_imageProduct);
            this.Controls.Add(this.txtB_idSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.GrView_spUser);
            this.Controls.Add(this.txtB_searchSP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrView_spUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_imageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtB_searchSP;
        private System.Windows.Forms.DataGridView GrView_spUser;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_idSP;
        private System.Windows.Forms.PictureBox picB_imageProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_nameSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtB_idUser;
        private System.Windows.Forms.TextBox txtB_sizeSP;
        private System.Windows.Forms.TextBox txtB_sellSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtB_inventorySP;
        private System.Windows.Forms.TextBox txtB_Quantity;
        private System.Windows.Forms.TextBox txtB_nameUser;
    }
}