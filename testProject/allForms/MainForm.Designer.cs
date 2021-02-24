namespace testProject.allForms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaryActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResignation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCRR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPromotion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.masterMaintenanceToolStripMenuItem,
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmployees,
            this.mnuPA,
            this.mnuAttendance,
            this.mnuPromotion,
            this.mnuCRR,
            this.mnuResignation});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.employeesToolStripMenuItem.Text = "Transactions";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // masterMaintenanceToolStripMenuItem
            // 
            this.masterMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.sectionsToolStripMenuItem,
            this.teamsToolStripMenuItem,
            this.designationsToolStripMenuItem,
            this.leaveToolStripMenuItem,
            this.disciplinaryActionsToolStripMenuItem});
            this.masterMaintenanceToolStripMenuItem.Name = "masterMaintenanceToolStripMenuItem";
            this.masterMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.masterMaintenanceToolStripMenuItem.Text = "Master Maintenance";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // sectionsToolStripMenuItem
            // 
            this.sectionsToolStripMenuItem.Name = "sectionsToolStripMenuItem";
            this.sectionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sectionsToolStripMenuItem.Text = "Sections";
            // 
            // designationsToolStripMenuItem
            // 
            this.designationsToolStripMenuItem.Name = "designationsToolStripMenuItem";
            this.designationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.designationsToolStripMenuItem.Text = "Designations";
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // mnuEmployees
            // 
            this.mnuEmployees.Name = "mnuEmployees";
            this.mnuEmployees.Size = new System.Drawing.Size(198, 22);
            this.mnuEmployees.Text = "Employees";
            this.mnuEmployees.Click += new System.EventHandler(this.mnuEmployees_Click);
            // 
            // mnuPA
            // 
            this.mnuPA.Name = "mnuPA";
            this.mnuPA.Size = new System.Drawing.Size(198, 22);
            this.mnuPA.Text = "Perfect Attendance";
            // 
            // mnuAttendance
            // 
            this.mnuAttendance.Name = "mnuAttendance";
            this.mnuAttendance.Size = new System.Drawing.Size(198, 22);
            this.mnuAttendance.Text = "Attendance Monitoring";
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.leaveToolStripMenuItem.Text = "Leave";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // disciplinaryActionsToolStripMenuItem
            // 
            this.disciplinaryActionsToolStripMenuItem.Name = "disciplinaryActionsToolStripMenuItem";
            this.disciplinaryActionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disciplinaryActionsToolStripMenuItem.Text = "CRR";
            // 
            // mnuResignation
            // 
            this.mnuResignation.Name = "mnuResignation";
            this.mnuResignation.Size = new System.Drawing.Size(198, 22);
            this.mnuResignation.Text = "Resignation Records";
            // 
            // mnuCRR
            // 
            this.mnuCRR.Name = "mnuCRR";
            this.mnuCRR.Size = new System.Drawing.Size(198, 22);
            this.mnuCRR.Text = "CRR Violators";
            // 
            // mnuPromotion
            // 
            this.mnuPromotion.Name = "mnuPromotion";
            this.mnuPromotion.Size = new System.Drawing.Size(198, 22);
            this.mnuPromotion.Text = "Promotion Records";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 598);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuPA;
        private System.Windows.Forms.ToolStripMenuItem masterMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAttendance;
        private System.Windows.Forms.ToolStripMenuItem mnuPromotion;
        private System.Windows.Forms.ToolStripMenuItem mnuCRR;
        private System.Windows.Forms.ToolStripMenuItem mnuResignation;
        private System.Windows.Forms.ToolStripMenuItem leaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaryActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;

    }
}