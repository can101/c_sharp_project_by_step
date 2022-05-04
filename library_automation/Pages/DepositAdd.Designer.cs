namespace library_automation
{
    partial class DepositAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositAdd));
            this.btnGiveDepositBookBtn = new System.Windows.Forms.Button();
            this.rchtbxDepositNote = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBtnBack = new System.Windows.Forms.PictureBox();
            this.tbxBookNo = new System.Windows.Forms.NumericUpDown();
            this.dtpbxBackDate = new System.Windows.Forms.DateTimePicker();
            this.tbxUserNo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBookNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUserNo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiveDepositBookBtn
            // 
            this.btnGiveDepositBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnGiveDepositBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiveDepositBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiveDepositBookBtn.FlatAppearance.BorderSize = 0;
            this.btnGiveDepositBookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGiveDepositBookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGiveDepositBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveDepositBookBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveDepositBookBtn.ForeColor = System.Drawing.Color.Transparent;
            this.btnGiveDepositBookBtn.Location = new System.Drawing.Point(75, 279);
            this.btnGiveDepositBookBtn.Name = "btnGiveDepositBookBtn";
            this.btnGiveDepositBookBtn.Size = new System.Drawing.Size(630, 31);
            this.btnGiveDepositBookBtn.TabIndex = 25;
            this.btnGiveDepositBookBtn.TabStop = false;
            this.btnGiveDepositBookBtn.Text = "Emanet Kitap Ver";
            this.btnGiveDepositBookBtn.UseVisualStyleBackColor = false;
            this.btnGiveDepositBookBtn.Click += new System.EventHandler(this.btnGiveDepositBookBtn_Click);
            // 
            // rchtbxDepositNote
            // 
            this.rchtbxDepositNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchtbxDepositNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rchtbxDepositNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.rchtbxDepositNote.Location = new System.Drawing.Point(75, 190);
            this.rchtbxDepositNote.Name = "rchtbxDepositNote";
            this.rchtbxDepositNote.Size = new System.Drawing.Size(630, 77);
            this.rchtbxDepositNote.TabIndex = 24;
            this.rchtbxDepositNote.TabStop = false;
            this.rchtbxDepositNote.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label10.Location = new System.Drawing.Point(71, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Emanet Not";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label15.Location = new System.Drawing.Point(71, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 23);
            this.label15.TabIndex = 22;
            this.label15.Text = "Emanet Teslim Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label16.Location = new System.Drawing.Point(401, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 23);
            this.label16.TabIndex = 20;
            this.label16.Text = "Kitap No";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label17.Location = new System.Drawing.Point(71, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 23);
            this.label17.TabIndex = 18;
            this.label17.Text = "Üye No";
            // 
            // pictureBtnBack
            // 
            this.pictureBtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBtnBack.Image")));
            this.pictureBtnBack.Location = new System.Drawing.Point(-8, 122);
            this.pictureBtnBack.Name = "pictureBtnBack";
            this.pictureBtnBack.Size = new System.Drawing.Size(63, 103);
            this.pictureBtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBtnBack.TabIndex = 36;
            this.pictureBtnBack.TabStop = false;
            this.pictureBtnBack.Click += new System.EventHandler(this.pictureBtnBack_Click);
            // 
            // tbxBookNo
            // 
            this.tbxBookNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbxBookNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxBookNo.Location = new System.Drawing.Point(405, 64);
            this.tbxBookNo.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.tbxBookNo.Name = "tbxBookNo";
            this.tbxBookNo.Size = new System.Drawing.Size(300, 24);
            this.tbxBookNo.TabIndex = 37;
            // 
            // dtpbxBackDate
            // 
            this.dtpbxBackDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.dtpbxBackDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.dtpbxBackDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.dtpbxBackDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpbxBackDate.Location = new System.Drawing.Point(75, 127);
            this.dtpbxBackDate.Name = "dtpbxBackDate";
            this.dtpbxBackDate.Size = new System.Drawing.Size(630, 24);
            this.dtpbxBackDate.TabIndex = 38;
            // 
            // tbxUserNo
            // 
            this.tbxUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbxUserNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxUserNo.Location = new System.Drawing.Point(75, 64);
            this.tbxUserNo.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.tbxUserNo.Name = "tbxUserNo";
            this.tbxUserNo.Size = new System.Drawing.Size(300, 24);
            this.tbxUserNo.TabIndex = 39;
            // 
            // DepositAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 346);
            this.Controls.Add(this.tbxUserNo);
            this.Controls.Add(this.dtpbxBackDate);
            this.Controls.Add(this.tbxBookNo);
            this.Controls.Add(this.pictureBtnBack);
            this.Controls.Add(this.btnGiveDepositBookBtn);
            this.Controls.Add(this.rchtbxDepositNote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Name = "DepositAdd";
            this.Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBookNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUserNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGiveDepositBookBtn;
        private System.Windows.Forms.RichTextBox rchtbxDepositNote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBtnBack;
        private System.Windows.Forms.NumericUpDown tbxBookNo;
        private System.Windows.Forms.DateTimePicker dtpbxBackDate;
        private System.Windows.Forms.NumericUpDown tbxUserNo;
    }
}