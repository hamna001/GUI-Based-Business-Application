
namespace FinalProjectBusinessApplicationWithGUI
{
    partial class SignInScreen
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
            this.lblsignInpassword = new System.Windows.Forms.Label();
            this.lblsignIn = new System.Windows.Forms.Label();
            this.lblsignInName = new System.Windows.Forms.Label();
            this.txtSignInName = new System.Windows.Forms.TextBox();
            this.txtSignInpassword = new System.Windows.Forms.TextBox();
            this.btnNextSignIn = new System.Windows.Forms.Button();
            this.btnbackSignIn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.5F));
            this.tableLayoutPanel1.Controls.Add(this.lblsignInpassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblsignIn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblsignInName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSignInName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSignInpassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNextSignIn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnbackSignIn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1027, 599);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblsignInpassword
            // 
            this.lblsignInpassword.AutoSize = true;
            this.lblsignInpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignInpassword.ForeColor = System.Drawing.Color.Purple;
            this.lblsignInpassword.Location = new System.Drawing.Point(100, 450);
            this.lblsignInpassword.Margin = new System.Windows.Forms.Padding(100, 50, 3, 0);
            this.lblsignInpassword.Name = "lblsignInpassword";
            this.lblsignInpassword.Size = new System.Drawing.Size(168, 64);
            this.lblsignInpassword.TabIndex = 3;
            this.lblsignInpassword.Text = "Enter Your Password:";
            // 
            // lblsignIn
            // 
            this.lblsignIn.AutoSize = true;
            this.lblsignIn.Font = new System.Drawing.Font("Snap ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignIn.ForeColor = System.Drawing.Color.Purple;
            this.lblsignIn.Location = new System.Drawing.Point(454, 60);
            this.lblsignIn.Margin = new System.Windows.Forms.Padding(100, 60, 3, 0);
            this.lblsignIn.Name = "lblsignIn";
            this.lblsignIn.Size = new System.Drawing.Size(418, 55);
            this.lblsignIn.TabIndex = 1;
            this.lblsignIn.Text = "SIGN IN HERE";
            // 
            // lblsignInName
            // 
            this.lblsignInName.AutoSize = true;
            this.lblsignInName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignInName.ForeColor = System.Drawing.Color.Purple;
            this.lblsignInName.Location = new System.Drawing.Point(100, 250);
            this.lblsignInName.Margin = new System.Windows.Forms.Padding(100, 50, 3, 0);
            this.lblsignInName.Name = "lblsignInName";
            this.lblsignInName.Size = new System.Drawing.Size(168, 64);
            this.lblsignInName.TabIndex = 2;
            this.lblsignInName.Text = "Enter Your Name:";
            // 
            // txtSignInName
            // 
            this.txtSignInName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignInName.ForeColor = System.Drawing.Color.Purple;
            this.txtSignInName.Location = new System.Drawing.Point(454, 250);
            this.txtSignInName.Margin = new System.Windows.Forms.Padding(100, 50, 3, 3);
            this.txtSignInName.Name = "txtSignInName";
            this.txtSignInName.Size = new System.Drawing.Size(264, 30);
            this.txtSignInName.TabIndex = 7;
            // 
            // txtSignInpassword
            // 
            this.txtSignInpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignInpassword.ForeColor = System.Drawing.Color.Purple;
            this.txtSignInpassword.Location = new System.Drawing.Point(454, 450);
            this.txtSignInpassword.Margin = new System.Windows.Forms.Padding(100, 50, 3, 3);
            this.txtSignInpassword.Name = "txtSignInpassword";
            this.txtSignInpassword.Size = new System.Drawing.Size(264, 30);
            this.txtSignInpassword.TabIndex = 8;
            this.txtSignInpassword.TextChanged += new System.EventHandler(this.txtSignInpassword_TextChanged);
            // 
            // btnNextSignIn
            // 
            this.btnNextSignIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNextSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSignIn.ForeColor = System.Drawing.Color.Purple;
            this.btnNextSignIn.Location = new System.Drawing.Point(854, 526);
            this.btnNextSignIn.Margin = new System.Windows.Forms.Padding(500, 3, 3, 3);
            this.btnNextSignIn.Name = "btnNextSignIn";
            this.btnNextSignIn.Size = new System.Drawing.Size(145, 61);
            this.btnNextSignIn.TabIndex = 9;
            this.btnNextSignIn.Text = "Next";
            this.btnNextSignIn.UseVisualStyleBackColor = false;
            this.btnNextSignIn.Click += new System.EventHandler(this.btnNextSignIn_Click);
            // 
            // btnbackSignIn
            // 
            this.btnbackSignIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbackSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackSignIn.ForeColor = System.Drawing.Color.Purple;
            this.btnbackSignIn.Location = new System.Drawing.Point(3, 526);
            this.btnbackSignIn.Name = "btnbackSignIn";
            this.btnbackSignIn.Size = new System.Drawing.Size(115, 57);
            this.btnbackSignIn.TabIndex = 14;
            this.btnbackSignIn.Text = "Back";
            this.btnbackSignIn.UseVisualStyleBackColor = false;
            this.btnbackSignIn.Click += new System.EventHandler(this.btnbackSignIn_Click);
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SignInScreen";
            this.Text = "SignInScreen";
            this.Load += new System.EventHandler(this.SignInScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblsignIn;
        private System.Windows.Forms.Label lblsignInName;
        private System.Windows.Forms.Label lblsignInpassword;
        private System.Windows.Forms.TextBox txtSignInName;
        private System.Windows.Forms.TextBox txtSignInpassword;
        private System.Windows.Forms.Button btnNextSignIn;
        private System.Windows.Forms.Button btnbackSignIn;
    }
}