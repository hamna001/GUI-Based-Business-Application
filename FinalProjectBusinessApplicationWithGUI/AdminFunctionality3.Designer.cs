
namespace FinalProjectBusinessApplicationWithGUI
{
    partial class AdminFunctionality3
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
            this.lblAdminFunctionality3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnenterdelete = new System.Windows.Forms.Button();
            this.lblupdate = new System.Windows.Forms.Label();
            this.lblAdminFunctionality3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminFunctionality3
            // 
            this.lblAdminFunctionality3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdminFunctionality3.ColumnCount = 3;
            this.lblAdminFunctionality3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.12741F));
            this.lblAdminFunctionality3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.87259F));
            this.lblAdminFunctionality3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.lblAdminFunctionality3.Controls.Add(this.button1, 0, 2);
            this.lblAdminFunctionality3.Controls.Add(this.dataGridView1, 1, 1);
            this.lblAdminFunctionality3.Controls.Add(this.btnenterdelete, 2, 2);
            this.lblAdminFunctionality3.Controls.Add(this.lblupdate, 1, 0);
            this.lblAdminFunctionality3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminFunctionality3.Location = new System.Drawing.Point(0, 0);
            this.lblAdminFunctionality3.Name = "lblAdminFunctionality3";
            this.lblAdminFunctionality3.RowCount = 3;
            this.lblAdminFunctionality3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.73726F));
            this.lblAdminFunctionality3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.26273F));
            this.lblAdminFunctionality3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.lblAdminFunctionality3.Size = new System.Drawing.Size(886, 450);
            this.lblAdminFunctionality3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(3, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(104, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 271);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnenterdelete
            // 
            this.btnenterdelete.BackColor = System.Drawing.Color.Black;
            this.btnenterdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenterdelete.ForeColor = System.Drawing.Color.Purple;
            this.btnenterdelete.Location = new System.Drawing.Point(779, 376);
            this.btnenterdelete.Name = "btnenterdelete";
            this.btnenterdelete.Size = new System.Drawing.Size(96, 62);
            this.btnenterdelete.TabIndex = 0;
            this.btnenterdelete.Text = "Enter";
            this.btnenterdelete.UseVisualStyleBackColor = false;
            this.btnenterdelete.Click += new System.EventHandler(this.btnbackdelete_Click);
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Font = new System.Drawing.Font("Snap ITC", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdate.ForeColor = System.Drawing.Color.Purple;
            this.lblupdate.Location = new System.Drawing.Point(261, 40);
            this.lblupdate.Margin = new System.Windows.Forms.Padding(160, 40, 3, 0);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(413, 43);
            this.lblupdate.TabIndex = 3;
            this.lblupdate.Text = "Select any Product ";
            this.lblupdate.Click += new System.EventHandler(this.lblupdate_Click);
            // 
            // AdminFunctionality3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.lblAdminFunctionality3);
            this.Name = "AdminFunctionality3";
            this.Text = "AdminFunctionality3";
            this.Load += new System.EventHandler(this.AdminFunctionality3_Load);
            this.lblAdminFunctionality3.ResumeLayout(false);
            this.lblAdminFunctionality3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lblAdminFunctionality3;
        private System.Windows.Forms.Button btnenterdelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblupdate;
    }
}