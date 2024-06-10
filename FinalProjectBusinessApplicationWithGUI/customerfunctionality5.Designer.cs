
namespace FinalProjectBusinessApplicationWithGUI
{
    partial class customerfunctionality5
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
            this.lblfeedbackcust = new System.Windows.Forms.Label();
            this.lblnamefeedback = new System.Windows.Forms.Label();
            this.txtnamefeedback = new System.Windows.Forms.TextBox();
            this.lblfeedback = new System.Windows.Forms.Label();
            this.txtfeedback = new System.Windows.Forms.TextBox();
            this.btnNextfeedback = new System.Windows.Forms.Button();
            this.btnbackfeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfeedbackcust
            // 
            this.lblfeedbackcust.AutoSize = true;
            this.lblfeedbackcust.Font = new System.Drawing.Font("Snap ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedbackcust.ForeColor = System.Drawing.Color.Purple;
            this.lblfeedbackcust.Location = new System.Drawing.Point(152, 28);
            this.lblfeedbackcust.Name = "lblfeedbackcust";
            this.lblfeedbackcust.Size = new System.Drawing.Size(554, 57);
            this.lblfeedbackcust.TabIndex = 1;
            this.lblfeedbackcust.Text = "Give Your FeedBack";
            // 
            // lblnamefeedback
            // 
            this.lblnamefeedback.AutoSize = true;
            this.lblnamefeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamefeedback.ForeColor = System.Drawing.Color.Purple;
            this.lblnamefeedback.Location = new System.Drawing.Point(28, 134);
            this.lblnamefeedback.Name = "lblnamefeedback";
            this.lblnamefeedback.Size = new System.Drawing.Size(329, 36);
            this.lblnamefeedback.TabIndex = 2;
            this.lblnamefeedback.Text = "Enter Your Username:";
            // 
            // txtnamefeedback
            // 
            this.txtnamefeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamefeedback.ForeColor = System.Drawing.Color.Purple;
            this.txtnamefeedback.Location = new System.Drawing.Point(475, 143);
            this.txtnamefeedback.Name = "txtnamefeedback";
            this.txtnamefeedback.Size = new System.Drawing.Size(214, 30);
            this.txtnamefeedback.TabIndex = 3;
            // 
            // lblfeedback
            // 
            this.lblfeedback.AllowDrop = true;
            this.lblfeedback.AutoSize = true;
            this.lblfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedback.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblfeedback.Location = new System.Drawing.Point(30, 258);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(327, 36);
            this.lblfeedback.TabIndex = 4;
            this.lblfeedback.Text = "Enter Your FeedBack:";
            // 
            // txtfeedback
            // 
            this.txtfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeedback.ForeColor = System.Drawing.Color.Purple;
            this.txtfeedback.Location = new System.Drawing.Point(475, 258);
            this.txtfeedback.Name = "txtfeedback";
            this.txtfeedback.Size = new System.Drawing.Size(214, 30);
            this.txtfeedback.TabIndex = 5;
            // 
            // btnNextfeedback
            // 
            this.btnNextfeedback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNextfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextfeedback.ForeColor = System.Drawing.Color.Purple;
            this.btnNextfeedback.Location = new System.Drawing.Point(659, 377);
            this.btnNextfeedback.Name = "btnNextfeedback";
            this.btnNextfeedback.Size = new System.Drawing.Size(113, 49);
            this.btnNextfeedback.TabIndex = 6;
            this.btnNextfeedback.Text = "Submit";
            this.btnNextfeedback.UseVisualStyleBackColor = false;
            this.btnNextfeedback.Click += new System.EventHandler(this.btnNextfeedback_Click);
            // 
            // btnbackfeedback
            // 
            this.btnbackfeedback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbackfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackfeedback.ForeColor = System.Drawing.Color.Purple;
            this.btnbackfeedback.Location = new System.Drawing.Point(34, 377);
            this.btnbackfeedback.Name = "btnbackfeedback";
            this.btnbackfeedback.Size = new System.Drawing.Size(113, 49);
            this.btnbackfeedback.TabIndex = 7;
            this.btnbackfeedback.Text = "Back";
            this.btnbackfeedback.UseVisualStyleBackColor = false;
            this.btnbackfeedback.Click += new System.EventHandler(this.btnbackfeedback_Click);
            // 
            // customerfunctionality5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbackfeedback);
            this.Controls.Add(this.btnNextfeedback);
            this.Controls.Add(this.txtfeedback);
            this.Controls.Add(this.lblfeedback);
            this.Controls.Add(this.txtnamefeedback);
            this.Controls.Add(this.lblnamefeedback);
            this.Controls.Add(this.lblfeedbackcust);
            this.Name = "customerfunctionality5";
            this.Text = "customerfunctionality5";
            this.Load += new System.EventHandler(this.customerfunctionality5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfeedbackcust;
        private System.Windows.Forms.Label lblnamefeedback;
        private System.Windows.Forms.TextBox txtnamefeedback;
        private System.Windows.Forms.Label lblfeedback;
        private System.Windows.Forms.TextBox txtfeedback;
        private System.Windows.Forms.Button btnNextfeedback;
        private System.Windows.Forms.Button btnbackfeedback;
    }
}