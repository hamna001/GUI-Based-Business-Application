
namespace FinalProjectBusinessApplicationWithGUI
{
    partial class AdminFunctionality6
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
            this.lblshowusers = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backbuttonviewusers = new System.Windows.Forms.Button();
            this.lblshowusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblshowusers
            // 
            this.lblshowusers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblshowusers.ColumnCount = 3;
            this.lblshowusers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.875F));
            this.lblshowusers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.125F));
            this.lblshowusers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.lblshowusers.Controls.Add(this.dataGridView1, 1, 1);
            this.lblshowusers.Controls.Add(this.backbuttonviewusers, 0, 2);
            this.lblshowusers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblshowusers.Location = new System.Drawing.Point(0, 0);
            this.lblshowusers.Name = "lblshowusers";
            this.lblshowusers.RowCount = 3;
            this.lblshowusers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.18881F));
            this.lblshowusers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.81119F));
            this.lblshowusers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.lblshowusers.Size = new System.Drawing.Size(800, 450);
            this.lblshowusers.TabIndex = 0;
            this.lblshowusers.Paint += new System.Windows.Forms.PaintEventHandler(this.lblshowusers_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backbuttonviewusers
            // 
            this.backbuttonviewusers.BackColor = System.Drawing.Color.Black;
            this.backbuttonviewusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbuttonviewusers.ForeColor = System.Drawing.Color.Violet;
            this.backbuttonviewusers.Location = new System.Drawing.Point(3, 397);
            this.backbuttonviewusers.Name = "backbuttonviewusers";
            this.backbuttonviewusers.Size = new System.Drawing.Size(73, 50);
            this.backbuttonviewusers.TabIndex = 1;
            this.backbuttonviewusers.Text = "Back";
            this.backbuttonviewusers.UseVisualStyleBackColor = false;
            this.backbuttonviewusers.Click += new System.EventHandler(this.backbuttonviewusers_Click);
            // 
            // AdminFunctionality6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblshowusers);
            this.Name = "AdminFunctionality6";
            this.Text = "AdminFunctionality6";
            this.Load += new System.EventHandler(this.AdminFunctionality6_Load);
            this.lblshowusers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lblshowusers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backbuttonviewusers;
    }
}