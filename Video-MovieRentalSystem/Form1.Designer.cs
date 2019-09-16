namespace Video_MovieRentalSystem
{
    partial class mainForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTopCustomer = new System.Windows.Forms.Button();
            this.btnRerurnMovie = new System.Windows.Forms.Button();
            this.btnViewMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(482, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 57);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTopCustomer
            // 
            this.btnTopCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTopCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopCustomer.ForeColor = System.Drawing.Color.White;
            this.btnTopCustomer.Location = new System.Drawing.Point(172, 289);
            this.btnTopCustomer.Name = "btnTopCustomer";
            this.btnTopCustomer.Size = new System.Drawing.Size(233, 74);
            this.btnTopCustomer.TabIndex = 14;
            this.btnTopCustomer.Text = "Top Movies/Customers";
            this.btnTopCustomer.UseVisualStyleBackColor = false;
            this.btnTopCustomer.Click += new System.EventHandler(this.btnTopCustomer_Click);
            // 
            // btnRerurnMovie
            // 
            this.btnRerurnMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRerurnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRerurnMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRerurnMovie.Location = new System.Drawing.Point(506, 182);
            this.btnRerurnMovie.Name = "btnRerurnMovie";
            this.btnRerurnMovie.Size = new System.Drawing.Size(122, 71);
            this.btnRerurnMovie.TabIndex = 13;
            this.btnRerurnMovie.Text = "Return Movie";
            this.btnRerurnMovie.UseVisualStyleBackColor = false;
            this.btnRerurnMovie.Click += new System.EventHandler(this.btnRerurnMovie_Click);
            // 
            // btnViewMovie
            // 
            this.btnViewMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewMovie.Location = new System.Drawing.Point(327, 182);
            this.btnViewMovie.Name = "btnViewMovie";
            this.btnViewMovie.Size = new System.Drawing.Size(136, 71);
            this.btnViewMovie.TabIndex = 12;
            this.btnViewMovie.Text = "View Movie";
            this.btnViewMovie.UseVisualStyleBackColor = false;
            this.btnViewMovie.Click += new System.EventHandler(this.btnViewMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.Lime;
            this.btnAddMovie.Location = new System.Drawing.Point(172, 182);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(129, 71);
            this.btnAddMovie.TabIndex = 11;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Aqua;
            this.btnIssueMovie.Location = new System.Drawing.Point(482, 87);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(146, 69);
            this.btnIssueMovie.TabIndex = 10;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomer.ForeColor = System.Drawing.Color.Yellow;
            this.btnViewCustomer.Location = new System.Drawing.Point(335, 87);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(128, 69);
            this.btnViewCustomer.TabIndex = 9;
            this.btnViewCustomer.Text = "View Customer";
            this.btnViewCustomer.UseVisualStyleBackColor = false;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Red;
            this.btnAddCustomer.Location = new System.Drawing.Point(172, 87);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(129, 69);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTopCustomer);
            this.Controls.Add(this.btnRerurnMovie);
            this.Controls.Add(this.btnViewMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.btnViewCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTopCustomer;
        private System.Windows.Forms.Button btnRerurnMovie;
        private System.Windows.Forms.Button btnViewMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
    }
}

