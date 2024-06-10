
namespace FinalProjectBusinessApplicationWithGUI
{
    partial class AdminInterfaceScreen
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
            this.btnAdminAddcar = new System.Windows.Forms.Button();
            this.btnAdminAdd = new System.Windows.Forms.Button();
            this.btnAdminUpdate = new System.Windows.Forms.Button();
            this.btnAdminViewCars = new System.Windows.Forms.Button();
            this.btnAdminListOfOrders = new System.Windows.Forms.Button();
            this.btnAdminfeedback = new System.Windows.Forms.Button();
            this.btnbackAdminInterface = new System.Windows.Forms.Button();
            this.btnAdminSeeListOfCustomers = new System.Windows.Forms.Button();
            this.lblAdmininterface = new System.Windows.Forms.Label();
            this.btnAdminDeleteCar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.BackgroundImage = global::FinalProjectBusinessApplicationWithGUI.Properties.Resources._360_F_580869182_hJJHRrFhdPizxUFwaxNZeycWKhZQ4Pyb;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.69021F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.30979F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdminAddcar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminAdd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminUpdate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminViewCars, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminListOfOrders, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminfeedback, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnbackAdminInterface, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminSeeListOfCustomers, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblAdmininterface, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminDeleteCar, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.93443F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.06557F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1057, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnAdminAddcar
            // 
            this.btnAdminAddcar.BackColor = System.Drawing.Color.Black;
            this.btnAdminAddcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAddcar.ForeColor = System.Drawing.Color.Purple;
            this.btnAdminAddcar.Location = new System.Drawing.Point(450, 105);
            this.btnAdminAddcar.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnAdminAddcar.Name = "btnAdminAddcar";
            this.btnAdminAddcar.Size = new System.Drawing.Size(387, 52);
            this.btnAdminAddcar.TabIndex = 1;
            this.btnAdminAddcar.Text = "Creat A List Of Car";
            this.btnAdminAddcar.UseVisualStyleBackColor = false;
            this.btnAdminAddcar.Click += new System.EventHandler(this.btnAdminAddcar_Click);
            // 
            // btnAdminAdd
            // 
            this.btnAdminAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdminAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAdd.ForeColor = System.Drawing.Color.Purple;
            this.btnAdminAdd.Location = new System.Drawing.Point(450, 163);
            this.btnAdminAdd.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnAdminAdd.Name = "btnAdminAdd";
            this.btnAdminAdd.Size = new System.Drawing.Size(387, 44);
            this.btnAdminAdd.TabIndex = 2;
            this.btnAdminAdd.Text = "Add A Car To List";
            this.btnAdminAdd.UseVisualStyleBackColor = false;
            this.btnAdminAdd.Click += new System.EventHandler(this.btnAdminAdd_Click);
            // 
            // btnAdminUpdate
            // 
            this.btnAdminUpdate.BackColor = System.Drawing.Color.Black;
            this.btnAdminUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUpdate.ForeColor = System.Drawing.Color.Purple;
            this.btnAdminUpdate.Location = new System.Drawing.Point(450, 270);
            this.btnAdminUpdate.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnAdminUpdate.Name = "btnAdminUpdate";
            this.btnAdminUpdate.Size = new System.Drawing.Size(387, 47);
            this.btnAdminUpdate.TabIndex = 4;
            this.btnAdminUpdate.Text = "Update Price Of Car";
            this.btnAdminUpdate.UseVisualStyleBackColor = false;
            this.btnAdminUpdate.Click += new System.EventHandler(this.btnAdminUpdate_Click);
            // 
            // btnAdminViewCars
            // 
            this.btnAdminViewCars.BackColor = System.Drawing.Color.Black;
            this.btnAdminViewCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminViewCars.ForeColor = System.Drawing.Color.Purple;
            this.btnAdminViewCars.Location = new System.Drawing.Point(450, 323);
            this.btnAdminViewCars.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnAdminViewCars.Name = "btnAdminViewCars";
            this.btnAdminViewCars.Size = new System.Drawing.Size(387, 47);
            this.btnAdminViewCars.TabIndex = 5;
            this.btnAdminViewCars.Text = "View The List of Cars";
            this.btnAdminViewCars.UseVisualStyleBackColor = false;
            this.btnAdminViewCars.Click += new System.EventHandler(this.btnAdminViewCars_Click);
            // 
            // btnAdminListOfOrders
            // 
            this.btnAdminListOfOrders.BackColor = System.Drawing.Color.Black;
            this.btnAdminListOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminListOfOrders.ForeColor = System.Drawing.Color.Purple;
            this.btnAdminListOfOrders.Location = new System.Drawing.Point(450, 449);
            this.btnAdminListOfOrders.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnAdminListOfOrders.Name = "btnAdminListOfOrders";
            this.btnAdminListOfOrders.Size = new System.Drawing.Size(387, 47);
            this.btnAdminListOfOrders.TabIndex = 7;
            this.btnAdminListOfOrders.Text = "View The List of Orders";
            this.btnAdminListOfOrders.UseVisualStyleBackColor = false;
            this.btnAdminListOfOrders.Click += new System.EventHandler(this.btnAdminListOfOrders_Click);
            // 
            // btnAdminfeedback
            // 
            this.btnAdminfeedback.BackColor = System.Drawing.Color.Black;
            this.btnAdminfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminfeedback.ForeColor = System.Drawing.Color.Purple;
            this.btnAdminfeedback.Location = new System.Drawing.Point(450, 517);
            this.btnAdminfeedback.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnAdminfeedback.Name = "btnAdminfeedback";
            this.btnAdminfeedback.Size = new System.Drawing.Size(387, 47);
            this.btnAdminfeedback.TabIndex = 8;
            this.btnAdminfeedback.Text = "View The FeedBack";
            this.btnAdminfeedback.UseVisualStyleBackColor = false;
            this.btnAdminfeedback.Click += new System.EventHandler(this.btnAdminfeedback_Click);
            // 
            // btnbackAdminInterface
            // 
            this.btnbackAdminInterface.BackColor = System.Drawing.Color.Black;
            this.btnbackAdminInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackAdminInterface.ForeColor = System.Drawing.Color.Purple;
            this.btnbackAdminInterface.Location = new System.Drawing.Point(3, 517);
            this.btnbackAdminInterface.Name = "btnbackAdminInterface";
            this.btnbackAdminInterface.Size = new System.Drawing.Size(203, 88);
            this.btnbackAdminInterface.TabIndex = 9;
            this.btnbackAdminInterface.Text = "Back";
            this.btnbackAdminInterface.UseVisualStyleBackColor = false;
            this.btnbackAdminInterface.Click += new System.EventHandler(this.btnbackAdminInterface_Click);
            // 
            // btnAdminSeeListOfCustomers
            // 
            this.btnAdminSeeListOfCustomers.BackColor = System.Drawing.Color.Black;
            this.btnAdminSeeListOfCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSeeListOfCustomers.ForeColor = System.Drawing.Color.Purple;
            this.btnAdminSeeListOfCustomers.Location = new System.Drawing.Point(450, 384);
            this.btnAdminSeeListOfCustomers.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnAdminSeeListOfCustomers.Name = "btnAdminSeeListOfCustomers";
            this.btnAdminSeeListOfCustomers.Size = new System.Drawing.Size(387, 47);
            this.btnAdminSeeListOfCustomers.TabIndex = 6;
            this.btnAdminSeeListOfCustomers.Text = "View The List of Users";
            this.btnAdminSeeListOfCustomers.UseVisualStyleBackColor = false;
            this.btnAdminSeeListOfCustomers.Click += new System.EventHandler(this.btnAdminSeeListOfCustomers_Click);
            // 
            // lblAdmininterface
            // 
            this.lblAdmininterface.AutoSize = true;
            this.lblAdmininterface.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmininterface.ForeColor = System.Drawing.Color.Purple;
            this.lblAdmininterface.Location = new System.Drawing.Point(410, 45);
            this.lblAdmininterface.Margin = new System.Windows.Forms.Padding(160, 45, 30, 0);
            this.lblAdmininterface.Name = "lblAdmininterface";
            this.lblAdmininterface.Size = new System.Drawing.Size(464, 51);
            this.lblAdmininterface.TabIndex = 0;
            this.lblAdmininterface.Text = "WELCOME ADMIN";
            // 
            // btnAdminDeleteCar
            // 
            this.btnAdminDeleteCar.BackColor = System.Drawing.Color.Black;
            this.btnAdminDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDeleteCar.ForeColor = System.Drawing.Color.Purple;
            this.btnAdminDeleteCar.Location = new System.Drawing.Point(450, 213);
            this.btnAdminDeleteCar.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnAdminDeleteCar.Name = "btnAdminDeleteCar";
            this.btnAdminDeleteCar.Size = new System.Drawing.Size(387, 47);
            this.btnAdminDeleteCar.TabIndex = 3;
            this.btnAdminDeleteCar.Text = "Delete A Car";
            this.btnAdminDeleteCar.UseVisualStyleBackColor = false;
            this.btnAdminDeleteCar.Click += new System.EventHandler(this.btnAdminDeleteCar_Click);
            // 
            // AdminInterfaceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "AdminInterfaceScreen";
            this.Text = "AdminInterfaceScreen";
            this.Load += new System.EventHandler(this.AdminInterfaceScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAdmininterface;
        private System.Windows.Forms.Button btnAdminAddcar;
        private System.Windows.Forms.Button btnAdminAdd;
        private System.Windows.Forms.Button btnAdminDeleteCar;
        private System.Windows.Forms.Button btnAdminUpdate;
        private System.Windows.Forms.Button btnAdminViewCars;
        private System.Windows.Forms.Button btnAdminSeeListOfCustomers;
        private System.Windows.Forms.Button btnAdminListOfOrders;
        private System.Windows.Forms.Button btnAdminfeedback;
        private System.Windows.Forms.Button btnbackAdminInterface;
    }
}