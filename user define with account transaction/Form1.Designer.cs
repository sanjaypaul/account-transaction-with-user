namespace user_define_with_account_transaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acc_numbertextBox = new System.Windows.Forms.TextBox();
            this.acc_nametextBox = new System.Windows.Forms.TextBox();
            this.balancetextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.dipositeButton = new System.Windows.Forms.Button();
            this.withdrewButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.acc_nametextBox);
            this.groupBox1.Controls.Add(this.acc_numbertextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Acc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.withdrewButton);
            this.groupBox2.Controls.Add(this.dipositeButton);
            this.groupBox2.Controls.Add(this.balancetextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acc Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acc Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // acc_numbertextBox
            // 
            this.acc_numbertextBox.Location = new System.Drawing.Point(106, 31);
            this.acc_numbertextBox.Name = "acc_numbertextBox";
            this.acc_numbertextBox.Size = new System.Drawing.Size(201, 20);
            this.acc_numbertextBox.TabIndex = 2;
            // 
            // acc_nametextBox
            // 
            this.acc_nametextBox.Location = new System.Drawing.Point(106, 70);
            this.acc_nametextBox.Name = "acc_nametextBox";
            this.acc_nametextBox.Size = new System.Drawing.Size(201, 20);
            this.acc_nametextBox.TabIndex = 3;
            // 
            // balancetextBox
            // 
            this.balancetextBox.Location = new System.Drawing.Point(106, 27);
            this.balancetextBox.Name = "balancetextBox";
            this.balancetextBox.Size = new System.Drawing.Size(201, 20);
            this.balancetextBox.TabIndex = 4;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(313, 70);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // dipositeButton
            // 
            this.dipositeButton.Location = new System.Drawing.Point(77, 79);
            this.dipositeButton.Name = "dipositeButton";
            this.dipositeButton.Size = new System.Drawing.Size(75, 23);
            this.dipositeButton.TabIndex = 5;
            this.dipositeButton.Text = "Diposite";
            this.dipositeButton.UseVisualStyleBackColor = true;
            this.dipositeButton.Click += new System.EventHandler(this.dipositeButton_Click);
            // 
            // withdrewButton
            // 
            this.withdrewButton.Location = new System.Drawing.Point(251, 79);
            this.withdrewButton.Name = "withdrewButton";
            this.withdrewButton.Size = new System.Drawing.Size(75, 23);
            this.withdrewButton.TabIndex = 6;
            this.withdrewButton.Text = "Withdrew";
            this.withdrewButton.UseVisualStyleBackColor = true;
            this.withdrewButton.Click += new System.EventHandler(this.withdrewButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(182, 301);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 5;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 336);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox acc_nametextBox;
        private System.Windows.Forms.TextBox acc_numbertextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button withdrewButton;
        private System.Windows.Forms.Button dipositeButton;
        private System.Windows.Forms.TextBox balancetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reportButton;
    }
}

