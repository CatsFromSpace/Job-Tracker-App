

namespace JobTrackerApp
{
    partial class Form1 : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCompany = new TextBox();
            txtPosition = new TextBox();
            txtLocation = new TextBox();
            cmbStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lblCompany = new Label();
            lblPosition = new Label();
            lblLocation = new Label();
            lblStatus = new Label();
            lblDateApplied = new Label();
            lblInterviewDate = new Label();
            dateTimePicker2 = new DateTimePicker();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnAddJob = new Button();
            dvgJobs = new DataGridView();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgJobs).BeginInit();
            SuspendLayout();
            // 
            // txtCompany
            // 
            txtCompany.AccessibleName = "";
            txtCompany.BorderStyle = BorderStyle.FixedSingle;
            txtCompany.Location = new Point(41, 43);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(212, 25);
            txtCompany.TabIndex = 0;
            // 
            // txtPosition
            // 
            txtPosition.BorderStyle = BorderStyle.FixedSingle;
            txtPosition.Location = new Point(41, 104);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(212, 25);
            txtPosition.TabIndex = 1;
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Location = new Point(41, 166);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(212, 25);
            txtLocation.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Applied", "Interviewing", "Offered", "Rejected" });
            cmbStatus.Location = new Point(41, 227);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 25);
            cmbStatus.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(41, 289);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 4;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(41, 23);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(102, 17);
            lblCompany.TabIndex = 5;
            lblCompany.Text = "Company Name";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(41, 84);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(82, 17);
            lblPosition.TabIndex = 6;
            lblPosition.Text = "Position Title";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(41, 145);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(57, 17);
            lblLocation.TabIndex = 7;
            lblLocation.Text = "Location";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(41, 207);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(43, 17);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // lblDateApplied
            // 
            lblDateApplied.AutoSize = true;
            lblDateApplied.Location = new Point(41, 269);
            lblDateApplied.Name = "lblDateApplied";
            lblDateApplied.Size = new Size(84, 17);
            lblDateApplied.TabIndex = 9;
            lblDateApplied.Text = "Date Applied";
            // 
            // lblInterviewDate
            // 
            lblInterviewDate.AutoSize = true;
            lblInterviewDate.Location = new Point(41, 333);
            lblInterviewDate.Name = "lblInterviewDate";
            lblInterviewDate.Size = new Size(90, 17);
            lblInterviewDate.TabIndex = 10;
            lblInterviewDate.Text = "Interview Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(41, 354);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 25);
            dateTimePicker2.TabIndex = 12;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(41, 398);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(43, 17);
            lblNotes.TabIndex = 13;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Location = new Point(41, 419);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(212, 175);
            txtNotes.TabIndex = 14;
            // 
            // btnAddJob
            // 
            btnAddJob.BackColor = Color.LightSteelBlue;
            btnAddJob.FlatStyle = FlatStyle.Flat;
            btnAddJob.ForeColor = SystemColors.ControlText;
            btnAddJob.Location = new Point(41, 618);
            btnAddJob.Name = "btnAddJob";
            btnAddJob.Size = new Size(75, 26);
            btnAddJob.TabIndex = 16;
            btnAddJob.Text = "Add Job";
            btnAddJob.UseVisualStyleBackColor = false;
            btnAddJob.Click += btnAddJob_ClickAsync;
            // 
            // dvgJobs
            // 
            dvgJobs.BackgroundColor = SystemColors.Control;
            dvgJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgJobs.Location = new Point(309, 23);
            dvgJobs.Name = "dvgJobs";
            dvgJobs.Size = new Size(504, 571);
            dvgJobs.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightSteelBlue;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(309, 618);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 26);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_ClickAsync;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.LightSteelBlue;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Location = new Point(443, 618);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(103, 26);
            btnDeleteAll.TabIndex = 21;
            btnDeleteAll.Text = "Delete All";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_ClickAsync;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(849, 682);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(dvgJobs);
            Controls.Add(btnAddJob);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblInterviewDate);
            Controls.Add(lblDateApplied);
            Controls.Add(lblStatus);
            Controls.Add(lblLocation);
            Controls.Add(lblPosition);
            Controls.Add(lblCompany);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbStatus);
            Controls.Add(txtLocation);
            Controls.Add(txtPosition);
            Controls.Add(txtCompany);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Job Application Tracker";
            ((System.ComponentModel.ISupportInitialize)dvgJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompany;
        private TextBox txtPosition;
        private TextBox txtLocation;
        private ComboBox cmbStatus;
        private DateTimePicker dateTimePicker1;
        private Label lblCompany;
        private Label lblPosition;
        private Label lblLocation;
        private Label lblStatus;
        private Label lblDateApplied;
        private Label lblInterviewDate;
        private DateTimePicker dateTimePicker2;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnAddJob;
        private DataGridView dvgJobs;
        private Button btnDelete;
        private Button btnDeleteAll;
    }
}
