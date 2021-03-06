namespace library_automation.Pages
{
    partial class UserAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdd));
            this.pictureBtnBack = new System.Windows.Forms.PictureBox();
            this.userAddBtn = new System.Windows.Forms.Button();
            this.tbxUserAdress = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxUserMail = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxUserPhoneNo = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxUserSurname = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBtnBack
            // 
            this.pictureBtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBtnBack.Image")));
            this.pictureBtnBack.Location = new System.Drawing.Point(-6, 113);
            this.pictureBtnBack.Name = "pictureBtnBack";
            this.pictureBtnBack.Size = new System.Drawing.Size(63, 103);
            this.pictureBtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBtnBack.TabIndex = 48;
            this.pictureBtnBack.TabStop = false;
            this.pictureBtnBack.Click += new System.EventHandler(this.pictureBtnBack_Click);
            // 
            // userAddBtn
            // 
            this.userAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.userAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userAddBtn.FlatAppearance.BorderSize = 0;
            this.userAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userAddBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAddBtn.ForeColor = System.Drawing.Color.Transparent;
            this.userAddBtn.Location = new System.Drawing.Point(92, 263);
            this.userAddBtn.Name = "userAddBtn";
            this.userAddBtn.Size = new System.Drawing.Size(636, 31);
            this.userAddBtn.TabIndex = 47;
            this.userAddBtn.TabStop = false;
            this.userAddBtn.Text = "Üye Ekle";
            this.userAddBtn.UseVisualStyleBackColor = false;
            this.userAddBtn.Click += new System.EventHandler(this.userAddBtn_Click);
            // 
            // tbxUserAdress
            // 
            this.tbxUserAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserAdress.Location = new System.Drawing.Point(92, 201);
            this.tbxUserAdress.Name = "tbxUserAdress";
            this.tbxUserAdress.Size = new System.Drawing.Size(636, 50);
            this.tbxUserAdress.TabIndex = 46;
            this.tbxUserAdress.TabStop = false;
            this.tbxUserAdress.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label9.Location = new System.Drawing.Point(88, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 45;
            this.label9.Text = "Açık Adres";
            // 
            // tbxUserMail
            // 
            this.tbxUserMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserMail.Location = new System.Drawing.Point(428, 132);
            this.tbxUserMail.Multiline = false;
            this.tbxUserMail.Name = "tbxUserMail";
            this.tbxUserMail.Size = new System.Drawing.Size(300, 25);
            this.tbxUserMail.TabIndex = 44;
            this.tbxUserMail.TabStop = false;
            this.tbxUserMail.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label11.Location = new System.Drawing.Point(424, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 23);
            this.label11.TabIndex = 43;
            this.label11.Text = "E-Posta Adresi";
            // 
            // tbxUserPhoneNo
            // 
            this.tbxUserPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserPhoneNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserPhoneNo.Location = new System.Drawing.Point(92, 132);
            this.tbxUserPhoneNo.Multiline = false;
            this.tbxUserPhoneNo.Name = "tbxUserPhoneNo";
            this.tbxUserPhoneNo.Size = new System.Drawing.Size(300, 25);
            this.tbxUserPhoneNo.TabIndex = 42;
            this.tbxUserPhoneNo.TabStop = false;
            this.tbxUserPhoneNo.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label12.Location = new System.Drawing.Point(88, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 23);
            this.label12.TabIndex = 41;
            this.label12.Text = "Telefon Numarası";
            // 
            // tbxUserSurname
            // 
            this.tbxUserSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserSurname.Location = new System.Drawing.Point(428, 66);
            this.tbxUserSurname.Multiline = false;
            this.tbxUserSurname.Name = "tbxUserSurname";
            this.tbxUserSurname.Size = new System.Drawing.Size(300, 25);
            this.tbxUserSurname.TabIndex = 40;
            this.tbxUserSurname.TabStop = false;
            this.tbxUserSurname.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label13.Location = new System.Drawing.Point(424, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 23);
            this.label13.TabIndex = 39;
            this.label13.Text = "Soyadı";
            // 
            // tbxUserName
            // 
            this.tbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.Location = new System.Drawing.Point(92, 66);
            this.tbxUserName.Multiline = false;
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(300, 25);
            this.tbxUserName.TabIndex = 38;
            this.tbxUserName.TabStop = false;
            this.tbxUserName.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label14.Location = new System.Drawing.Point(88, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 23);
            this.label14.TabIndex = 37;
            this.label14.Text = "Adı";
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 336);
            this.Controls.Add(this.pictureBtnBack);
            this.Controls.Add(this.userAddBtn);
            this.Controls.Add(this.tbxUserAdress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxUserMail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxUserPhoneNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxUserSurname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.label14);
            this.Name = "UserAdd";
            this.Text = "UserAdd";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBtnBack;
        private System.Windows.Forms.Button userAddBtn;
        private System.Windows.Forms.RichTextBox tbxUserAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox tbxUserMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox tbxUserPhoneNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox tbxUserSurname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox tbxUserName;
        private System.Windows.Forms.Label label14;
    }
}