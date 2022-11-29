namespace WaterBillCalculator
{
    partial class Customers
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
            this.txtwateramount = new System.Windows.Forms.TextBox();
            this.txtusertype = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtplotnumber = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtwateramount
            // 
            this.txtwateramount.Location = new System.Drawing.Point(349, 326);
            this.txtwateramount.Name = "txtwateramount";
            this.txtwateramount.Size = new System.Drawing.Size(220, 23);
            this.txtwateramount.TabIndex = 24;
            // 
            // txtusertype
            // 
            this.txtusertype.Location = new System.Drawing.Point(349, 277);
            this.txtusertype.Name = "txtusertype";
            this.txtusertype.Size = new System.Drawing.Size(220, 23);
            this.txtusertype.TabIndex = 23;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(349, 229);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(220, 23);
            this.txtlocation.TabIndex = 22;
            // 
            // txtplotnumber
            // 
            this.txtplotnumber.Location = new System.Drawing.Point(349, 189);
            this.txtplotnumber.Name = "txtplotnumber";
            this.txtplotnumber.Size = new System.Drawing.Size(220, 23);
            this.txtplotnumber.TabIndex = 21;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(349, 140);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(220, 23);
            this.txtsurname.TabIndex = 20;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(349, 102);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(220, 23);
            this.txtfirstname.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Water Amount(KL)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter User Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter Plot Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter First Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtwateramount);
            this.Controls.Add(this.txtusertype);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtplotnumber);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtwateramount;
        private TextBox txtusertype;
        private TextBox txtlocation;
        private TextBox txtplotnumber;
        private TextBox txtsurname;
        private TextBox txtfirstname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}