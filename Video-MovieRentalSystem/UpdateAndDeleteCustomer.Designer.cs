namespace Video_MovieRentalSystem
{
    partial class UpdateAndDeleteCustomer
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
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDaleteCustomer = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.Red;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(215, 329);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(97, 64);
            this.btnUpdateCustomer.TabIndex = 35;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(280, 261);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(319, 20);
            this.txtPhoneNo.TabIndex = 34;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(280, 177);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(319, 50);
            this.txtAddress.TabIndex = 33;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(280, 130);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(319, 20);
            this.txtLastName.TabIndex = 32;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(280, 87);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(319, 20);
            this.txtFirstName.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(201, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(201, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(201, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(201, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "First Name";
            // 
            // btnDaleteCustomer
            // 
            this.btnDaleteCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDaleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaleteCustomer.ForeColor = System.Drawing.Color.Red;
            this.btnDaleteCustomer.Location = new System.Drawing.Point(492, 329);
            this.btnDaleteCustomer.Name = "btnDaleteCustomer";
            this.btnDaleteCustomer.Size = new System.Drawing.Size(97, 64);
            this.btnDaleteCustomer.TabIndex = 36;
            this.btnDaleteCustomer.Text = "Delete Customer";
            this.btnDaleteCustomer.UseVisualStyleBackColor = false;
            this.btnDaleteCustomer.Click += new System.EventHandler(this.btnDaleteCustomer_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(280, 41);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(319, 20);
            this.txtCustID.TabIndex = 38;
            this.txtCustID.Visible = false;
            // 
            // UpdateAndDeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.btnDaleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UpdateAndDeleteCustomer";
            this.Text = "UpdateAndDeleteCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDaleteCustomer;
        public System.Windows.Forms.TextBox txtPhoneNo;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCustID;
    }
}