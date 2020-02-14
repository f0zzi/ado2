namespace Task_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.lbAge = new System.Windows.Forms.Label();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.gbHobby = new System.Windows.Forms.GroupBox();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.cbMovies = new System.Windows.Forms.CheckBox();
            this.cbBooks = new System.Windows.Forms.CheckBox();
            this.cbTourism = new System.Windows.Forms.CheckBox();
            this.cbSport = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbWarning = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbFoto = new System.Windows.Forms.Label();
            this.btLoadPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.gbSex.SuspendLayout();
            this.gbHobby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(29, 36);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(272, 22);
            this.tbName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(29, 83);
            this.tbLastName.MaxLength = 30;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(272, 22);
            this.tbLastName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(29, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(29, 64);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(70, 17);
            this.lbLastname.TabIndex = 3;
            this.lbLastname.Text = "Lastname";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(29, 132);
            this.dateOfBirth.MaxDate = new System.DateTime(2020, 1, 25, 0, 0, 0, 0);
            this.dateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.dateOfBirth.TabIndex = 4;
            this.dateOfBirth.Value = new System.DateTime(2020, 1, 25, 0, 0, 0, 0);
            this.dateOfBirth.ValueChanged += new System.EventHandler(this.DateOfBirth_ValueChanged);
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(29, 112);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(69, 17);
            this.lbBirthday.TabIndex = 5;
            this.lbBirthday.Text = "Birth date";
            // 
            // Age
            // 
            this.Age.Enabled = false;
            this.Age.Location = new System.Drawing.Point(246, 132);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(55, 22);
            this.Age.TabIndex = 6;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(246, 112);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(33, 17);
            this.lbAge.TabIndex = 7;
            this.lbAge.Text = "Age";
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rbFemale);
            this.gbSex.Controls.Add(this.rbMale);
            this.gbSex.Location = new System.Drawing.Point(29, 162);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(272, 78);
            this.gbSex.TabIndex = 8;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Sex";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(7, 48);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(71, 21);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(7, 21);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // gbHobby
            // 
            this.gbHobby.Controls.Add(this.tbOther);
            this.gbHobby.Controls.Add(this.cbOther);
            this.gbHobby.Controls.Add(this.cbMovies);
            this.gbHobby.Controls.Add(this.cbBooks);
            this.gbHobby.Controls.Add(this.cbTourism);
            this.gbHobby.Controls.Add(this.cbSport);
            this.gbHobby.Location = new System.Drawing.Point(524, 20);
            this.gbHobby.Name = "gbHobby";
            this.gbHobby.Size = new System.Drawing.Size(200, 192);
            this.gbHobby.TabIndex = 9;
            this.gbHobby.TabStop = false;
            this.gbHobby.Text = "Hobby";
            // 
            // tbOther
            // 
            this.tbOther.Enabled = false;
            this.tbOther.Location = new System.Drawing.Point(7, 161);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(187, 22);
            this.tbOther.TabIndex = 5;
            this.tbOther.Visible = false;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(7, 133);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(66, 21);
            this.cbOther.TabIndex = 4;
            this.cbOther.Text = "Other";
            this.cbOther.UseVisualStyleBackColor = true;
            this.cbOther.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // cbMovies
            // 
            this.cbMovies.AutoSize = true;
            this.cbMovies.Location = new System.Drawing.Point(7, 105);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(74, 21);
            this.cbMovies.TabIndex = 3;
            this.cbMovies.Text = "Movies";
            this.cbMovies.UseVisualStyleBackColor = true;
            // 
            // cbBooks
            // 
            this.cbBooks.AutoSize = true;
            this.cbBooks.Location = new System.Drawing.Point(7, 77);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(69, 21);
            this.cbBooks.TabIndex = 2;
            this.cbBooks.Text = "Books";
            this.cbBooks.UseVisualStyleBackColor = true;
            // 
            // cbTourism
            // 
            this.cbTourism.AutoSize = true;
            this.cbTourism.Location = new System.Drawing.Point(7, 49);
            this.cbTourism.Name = "cbTourism";
            this.cbTourism.Size = new System.Drawing.Size(81, 21);
            this.cbTourism.TabIndex = 1;
            this.cbTourism.Text = "Tourism";
            this.cbTourism.UseVisualStyleBackColor = true;
            // 
            // cbSport
            // 
            this.cbSport.AutoSize = true;
            this.cbSport.Location = new System.Drawing.Point(7, 21);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(64, 21);
            this.cbSport.TabIndex = 0;
            this.cbSport.Text = "Sport";
            this.cbSport.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(524, 219);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(609, 224);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 17);
            this.lbWarning.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 270);
            this.dataGridView1.TabIndex = 15;
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(344, 18);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(36, 17);
            this.lbFoto.TabIndex = 18;
            this.lbFoto.Text = "Foto";
            // 
            // btLoadPhoto
            // 
            this.btLoadPhoto.Location = new System.Drawing.Point(344, 219);
            this.btLoadPhoto.Name = "btLoadPhoto";
            this.btLoadPhoto.Size = new System.Drawing.Size(93, 23);
            this.btLoadPhoto.TabIndex = 17;
            this.btLoadPhoto.Text = "Load Photo";
            this.btLoadPhoto.UseVisualStyleBackColor = true;
            this.btLoadPhoto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(649, 219);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 19;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 557);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbFoto);
            this.Controls.Add(this.btLoadPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbHobby);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            this.gbHobby.ResumeLayout(false);
            this.gbHobby.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox gbHobby;
        private System.Windows.Forms.CheckBox cbMovies;
        private System.Windows.Forms.CheckBox cbBooks;
        private System.Windows.Forms.CheckBox cbTourism;
        private System.Windows.Forms.CheckBox cbSport;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.Button btLoadPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSave;
    }
}

