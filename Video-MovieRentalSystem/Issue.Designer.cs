namespace Video_MovieRentalSystem
{
    partial class Issue
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
            this.btnIssue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rentedMoviesDataSet1 = new Video_MovieRentalSystem.RentedMoviesDataSet1();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new Video_MovieRentalSystem.RentedMoviesDataSet1TableAdapters.MoviesTableAdapter();
            this.rentedMoviesDataSet2 = new Video_MovieRentalSystem.RentedMoviesDataSet2();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Video_MovieRentalSystem.RentedMoviesDataSet2TableAdapters.CustomerTableAdapter();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.Blue;
            this.btnIssue.Location = new System.Drawing.Point(206, 276);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(89, 47);
            this.btnIssue.TabIndex = 47;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Movie";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.moviesBindingSource;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.ValueMember = "MovieID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.customerBindingSource;
            this.comboBox2.DisplayMember = "FirstName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(206, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 49;
            this.comboBox2.ValueMember = "CustID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Issue Date";
            // 
            // rentedMoviesDataSet1
            // 
            this.rentedMoviesDataSet1.DataSetName = "RentedMoviesDataSet1";
            this.rentedMoviesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.rentedMoviesDataSet1;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // rentedMoviesDataSet2
            // 
            this.rentedMoviesDataSet2.DataSetName = "RentedMoviesDataSet2";
            this.rentedMoviesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.rentedMoviesDataSet2;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // phoneno
            // 
            this.phoneno.Enabled = false;
            this.phoneno.Location = new System.Drawing.Point(206, 239);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(200, 20);
            this.phoneno.TabIndex = 55;
            // 
            // address
            // 
            this.address.Enabled = false;
            this.address.Location = new System.Drawing.Point(206, 172);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 61);
            this.address.TabIndex = 54;
            // 
            // lastname
            // 
            this.lastname.Enabled = false;
            this.lastname.Location = new System.Drawing.Point(206, 146);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(200, 20);
            this.lastname.TabIndex = 53;
            // 
            // firstname
            // 
            this.firstname.Enabled = false;
            this.firstname.Location = new System.Drawing.Point(206, 120);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(200, 20);
            this.firstname.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "First Name";
            // 
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 348);
            this.Controls.Add(this.phoneno);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Issue";
            this.Text = "Issue";
            this.Load += new System.EventHandler(this.Issue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private RentedMoviesDataSet1 rentedMoviesDataSet1;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private RentedMoviesDataSet1TableAdapters.MoviesTableAdapter moviesTableAdapter;
        private RentedMoviesDataSet2 rentedMoviesDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private RentedMoviesDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}