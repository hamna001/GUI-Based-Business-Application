
namespace FinalProjectBusinessApplicationWithGUI
{
    partial class AdminFunctionality4
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
            this.btnnextupdate = new System.Windows.Forms.Button();
            this.btnbackupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblupdate = new System.Windows.Forms.Label();
            this.lblvewcarsadmin = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.lblvewcarsadmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnextupdate
            // 
            this.btnnextupdate.BackColor = System.Drawing.Color.Black;
            this.btnnextupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnextupdate.ForeColor = System.Drawing.Color.Purple;
            this.btnnextupdate.Location = new System.Drawing.Point(814, 415);
            this.btnnextupdate.Name = "btnnextupdate";
            this.btnnextupdate.Size = new System.Drawing.Size(103, 60);
            this.btnnextupdate.TabIndex = 3;
            this.btnnextupdate.Text = "Next";
            this.btnnextupdate.UseVisualStyleBackColor = false;
            this.btnnextupdate.Click += new System.EventHandler(this.btnnextupdate_Click);
            // 
            // btnbackupdate
            // 
            this.btnbackupdate.BackColor = System.Drawing.Color.Black;
            this.btnbackupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackupdate.ForeColor = System.Drawing.Color.Purple;
            this.btnbackupdate.Location = new System.Drawing.Point(3, 415);
            this.btnbackupdate.Name = "btnbackupdate";
            this.btnbackupdate.Size = new System.Drawing.Size(120, 60);
            this.btnbackupdate.TabIndex = 2;
            this.btnbackupdate.Text = "Back";
            this.btnbackupdate.UseVisualStyleBackColor = false;
            this.btnbackupdate.Click += new System.EventHandler(this.btnbackupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdate.ForeColor = System.Drawing.Color.Purple;
            this.lblupdate.Location = new System.Drawing.Point(176, 20);
            this.lblupdate.Margin = new System.Windows.Forms.Padding(50, 20, 3, 0);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(558, 39);
            this.lblupdate.TabIndex = 1;
            this.lblupdate.Text = "Select any Product To Update";
            // 
            // lblvewcarsadmin
            // 
            this.lblvewcarsadmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblvewcarsadmin.ColumnCount = 3;
            this.lblvewcarsadmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.56757F));
            this.lblvewcarsadmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.43243F));
            this.lblvewcarsadmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.lblvewcarsadmin.Controls.Add(this.lblupdate, 1, 0);
            this.lblvewcarsadmin.Controls.Add(this.dataGridView1, 1, 1);
            this.lblvewcarsadmin.Controls.Add(this.btnbackupdate, 0, 3);
            this.lblvewcarsadmin.Controls.Add(this.btnnextupdate, 2, 3);
            this.lblvewcarsadmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblvewcarsadmin.Location = new System.Drawing.Point(0, 0);
            this.lblvewcarsadmin.Name = "lblvewcarsadmin";
            this.lblvewcarsadmin.RowCount = 4;
            this.lblvewcarsadmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.45188F));
            this.lblvewcarsadmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.54812F));
            this.lblvewcarsadmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.lblvewcarsadmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.lblvewcarsadmin.Size = new System.Drawing.Size(925, 480);
            this.lblvewcarsadmin.TabIndex = 0;
            this.lblvewcarsadmin.Paint += new System.Windows.Forms.PaintEventHandler(this.lblvewcarsadmin_Paint);
            // 
            // AdminFunctionality4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 480);
            this.Controls.Add(this.lblvewcarsadmin);
            this.Name = "AdminFunctionality4";
            this.Text = "AdminFunctionality4";
            this.Load += new System.EventHandler(this.AdminFunctionality4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.lblvewcarsadmin.ResumeLayout(false);
            this.lblvewcarsadmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnextupdate;
        private System.Windows.Forms.Button btnbackupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblupdate;
        private System.Windows.Forms.TableLayoutPanel lblvewcarsadmin;
    }
}