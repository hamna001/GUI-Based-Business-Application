
namespace FinalProjectBusinessApplicationWithGUI
{
    partial class SignUpScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSignUpName = new System.Windows.Forms.TextBox();
            this.lblsignUp = new System.Windows.Forms.Label();
            this.lblsignUpName = new System.Windows.Forms.Label();
            this.txtSignInpassword = new System.Windows.Forms.TextBox();
            this.rdnAdmin = new System.Windows.Forms.RadioButton();
            this.rdnCustomer = new System.Windows.Forms.RadioButton();
            this.btnNextSignUp = new System.Windows.Forms.Button();
            this.btnbackSignUp = new System.Windows.Forms.Button();
            this.lblsignUppassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.83334F));
            this.tableLayoutPanel1.Controls.Add(this.txtSignUpName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblsignUp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblsignUpName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSignInpassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdnAdmin, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rdnCustomer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNextSignUp, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnbackSignUp, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblsignUppassword, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 658);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtSignUpName
            // 
            this.txtSignUpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpName.ForeColor = System.Drawing.Color.Purple;
            this.txtSignUpName.Location = new System.Drawing.Point(435, 237);
            this.txtSignUpName.Margin = new System.Windows.Forms.Padding(100, 50, 3, 3);
            this.txtSignUpName.Name = "txtSignUpName";
            this.txtSignUpName.Size = new System.Drawing.Size(264, 30);
            this.txtSignUpName.TabIndex = 8;
            // 
            // lblsignUp
            // 
            this.lblsignUp.AutoSize = true;
            this.lblsignUp.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignUp.ForeColor = System.Drawing.Color.Purple;
            this.lblsignUp.Location = new System.Drawing.Point(435, 60);
            this.lblsignUp.Margin = new System.Windows.Forms.Padding(100, 60, 3, 0);
            this.lblsignUp.Name = "lblsignUp";
            this.lblsignUp.Size = new System.Drawing.Size(329, 43);
            this.lblsignUp.TabIndex = 2;
            this.lblsignUp.Text = "SIGN UP HERE";
            // 
            // lblsignUpName
            // 
            this.lblsignUpName.AutoSize = true;
            this.lblsignUpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignUpName.ForeColor = System.Drawing.Color.Purple;
            this.lblsignUpName.Location = new System.Drawing.Point(100, 237);
            this.lblsignUpName.Margin = new System.Windows.Forms.Padding(100, 50, 3, 0);
            this.lblsignUpName.Name = "lblsignUpName";
            this.lblsignUpName.Size = new System.Drawing.Size(168, 64);
            this.lblsignUpName.TabIndex = 3;
            this.lblsignUpName.Text = "Enter Your Name:";
            // 
            // txtSignInpassword
            // 
            this.txtSignInpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignInpassword.ForeColor = System.Drawing.Color.Purple;
            this.txtSignInpassword.Location = new System.Drawing.Point(435, 424);
            this.txtSignInpassword.Margin = new System.Windows.Forms.Padding(100, 50, 3, 3);
            this.txtSignInpassword.Name = "txtSignInpassword";
            this.txtSignInpassword.Size = new System.Drawing.Size(264, 30);
            this.txtSignInpassword.TabIndex = 9;
            // 
            // rdnAdmin
            // 
            this.rdnAdmin.AutoSize = true;
            this.rdnAdmin.BackColor = System.Drawing.Color.Black;
            this.rdnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnAdmin.ForeColor = System.Drawing.Color.Purple;
            this.rdnAdmin.Location = new System.Drawing.Point(100, 542);
            this.rdnAdmin.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.rdnAdmin.Name = "rdnAdmin";
            this.rdnAdmin.Size = new System.Drawing.Size(130, 36);
            this.rdnAdmin.TabIndex = 10;
            this.rdnAdmin.TabStop = true;
            this.rdnAdmin.Text = "ADMIN";
            this.rdnAdmin.UseVisualStyleBackColor = false;
            // 
            // rdnCustomer
            // 
            this.rdnCustomer.AutoSize = true;
            this.rdnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnCustomer.ForeColor = System.Drawing.Color.Purple;
            this.rdnCustomer.Location = new System.Drawing.Point(435, 542);
            this.rdnCustomer.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.rdnCustomer.Name = "rdnCustomer";
            this.rdnCustomer.Size = new System.Drawing.Size(166, 36);
            this.rdnCustomer.TabIndex = 11;
            this.rdnCustomer.TabStop = true;
            this.rdnCustomer.Text = "Customer";
            this.rdnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnNextSignUp
            // 
            this.btnNextSignUp.BackColor = System.Drawing.Color.Black;
            this.btnNextSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSignUp.ForeColor = System.Drawing.Color.Purple;
            this.btnNextSignUp.Location = new System.Drawing.Point(835, 589);
            this.btnNextSignUp.Margin = new System.Windows.Forms.Padding(500, 3, 3, 3);
            this.btnNextSignUp.Name = "btnNextSignUp";
            this.btnNextSignUp.Size = new System.Drawing.Size(126, 57);
            this.btnNextSignUp.TabIndex = 12;
            this.btnNextSignUp.Text = "Next";
            this.btnNextSignUp.UseVisualStyleBackColor = false;
            this.btnNextSignUp.Click += new System.EventHandler(this.btnNextSignUp_Click);
            // 
            // btnbackSignUp
            // 
            this.btnbackSignUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbackSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackSignUp.ForeColor = System.Drawing.Color.Purple;
            this.btnbackSignUp.Location = new System.Drawing.Point(3, 589);
            this.btnbackSignUp.Name = "btnbackSignUp";
            this.btnbackSignUp.Size = new System.Drawing.Size(115, 57);
            this.btnbackSignUp.TabIndex = 13;
            this.btnbackSignUp.Text = "Back";
            this.btnbackSignUp.UseVisualStyleBackColor = false;
            this.btnbackSignUp.Click += new System.EventHandler(this.btnbackSignUp_Click);
            // 
            // lblsignUppassword
            // 
            this.lblsignUppassword.AutoSize = true;
            this.lblsignUppassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignUppassword.ForeColor = System.Drawing.Color.Purple;
            this.lblsignUppassword.Location = new System.Drawing.Point(100, 424);
            this.lblsignUppassword.Margin = new System.Windows.Forms.Padding(100, 50, 3, 0);
            this.lblsignUppassword.Name = "lblsignUppassword";
            this.lblsignUppassword.Size = new System.Drawing.Size(168, 64);
            this.lblsignUppassword.TabIndex = 4;
            this.lblsignUppassword.Text = "Enter Your Password:";
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 658);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SignUpScreen";
            this.Text = "SignUpScreen";
            this.Load += new System.EventHandler(this.SignUpScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblsignUp;
        private System.Windows.Forms.Label lblsignUpName;
        private System.Windows.Forms.Label lblsignUppassword;
        private System.Windows.Forms.TextBox txtSignUpName;
        private System.Windows.Forms.TextBox txtSignInpassword;
        private System.Windows.Forms.RadioButton rdnAdmin;
        private System.Windows.Forms.RadioButton rdnCustomer;
        private System.Windows.Forms.Button btnNextSignUp;
        private System.Windows.Forms.Button btnbackSignUp;
    }
}