namespace Video_MovieRentalSystem
{
    partial class AddMovie
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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddMovie.Location = new System.Drawing.Point(320, 317);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(125, 71);
            this.btnAddMovie.TabIndex = 34;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(229, 258);
            this.txtGenre.Multiline = true;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(411, 53);
            this.txtGenre.TabIndex = 33;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(229, 199);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(411, 53);
            this.txtPlot.TabIndex = 32;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(229, 173);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(411, 20);
            this.txtCopies.TabIndex = 31;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(229, 147);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(411, 20);
            this.txtYear.TabIndex = 30;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(229, 62);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(411, 53);
            this.txtTitle.TabIndex = 28;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(229, 121);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(411, 20);
            this.txtRating.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(160, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(160, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Plot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(160, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Copies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(160, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(160, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(160, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Rating";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}