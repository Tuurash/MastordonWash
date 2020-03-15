namespace AllForms.EmployeeAndOrderView
{
    partial class EmployeeOrderForm
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
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.EmpOrdrPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpContact = new System.Windows.Forms.TextBox();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpAddress = new System.Windows.Forms.Label();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.lblEmpContact = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvEmpOrdrDetails = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpJobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.EmpOrdrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpOrdrDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.Location = new System.Drawing.Point(12, 12);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(503, 84);
            this.LogoPanel.TabIndex = 0;
            // 
            // EmpOrdrPanel
            // 
            this.EmpOrdrPanel.Controls.Add(this.txtSearch);
            this.EmpOrdrPanel.Controls.Add(this.btnSearch);
            this.EmpOrdrPanel.Controls.Add(this.btnDelete);
            this.EmpOrdrPanel.Controls.Add(this.txtJobTitle);
            this.EmpOrdrPanel.Controls.Add(this.lblJobTitle);
            this.EmpOrdrPanel.Controls.Add(this.btnSave);
            this.EmpOrdrPanel.Controls.Add(this.lblEmpID);
            this.EmpOrdrPanel.Controls.Add(this.txtEmpID);
            this.EmpOrdrPanel.Controls.Add(this.txtEmpContact);
            this.EmpOrdrPanel.Controls.Add(this.txtEmpAddress);
            this.EmpOrdrPanel.Controls.Add(this.txtEmpEmail);
            this.EmpOrdrPanel.Controls.Add(this.txtEmpName);
            this.EmpOrdrPanel.Controls.Add(this.lblEmpAddress);
            this.EmpOrdrPanel.Controls.Add(this.lblEmpEmail);
            this.EmpOrdrPanel.Controls.Add(this.lblEmpContact);
            this.EmpOrdrPanel.Controls.Add(this.lblEmpName);
            this.EmpOrdrPanel.Controls.Add(this.btnShow);
            this.EmpOrdrPanel.Controls.Add(this.btnBack);
            this.EmpOrdrPanel.Controls.Add(this.btnEdit);
            this.EmpOrdrPanel.Controls.Add(this.dgvEmpOrdrDetails);
            this.EmpOrdrPanel.Location = new System.Drawing.Point(12, 102);
            this.EmpOrdrPanel.Name = "EmpOrdrPanel";
            this.EmpOrdrPanel.Size = new System.Drawing.Size(503, 711);
            this.EmpOrdrPanel.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(91, 657);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.Location = new System.Drawing.Point(135, 264);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(287, 26);
            this.txtJobTitle.TabIndex = 25;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(7, 263);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(117, 25);
            this.lblJobTitle.TabIndex = 24;
            this.lblJobTitle.Text = "Job Title :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(17, 9);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(48, 25);
            this.lblEmpID.TabIndex = 22;
            this.lblEmpID.Text = "ID :";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(135, 8);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(287, 26);
            this.txtEmpID.TabIndex = 21;
            // 
            // txtEmpContact
            // 
            this.txtEmpContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpContact.Location = new System.Drawing.Point(135, 115);
            this.txtEmpContact.Name = "txtEmpContact";
            this.txtEmpContact.Size = new System.Drawing.Size(287, 26);
            this.txtEmpContact.TabIndex = 20;
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpAddress.Location = new System.Drawing.Point(133, 213);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(287, 26);
            this.txtEmpAddress.TabIndex = 19;
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpEmail.Location = new System.Drawing.Point(135, 164);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(287, 26);
            this.txtEmpEmail.TabIndex = 18;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(135, 60);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(287, 26);
            this.txtEmpName.TabIndex = 17;
            // 
            // lblEmpAddress
            // 
            this.lblEmpAddress.AutoSize = true;
            this.lblEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpAddress.Location = new System.Drawing.Point(15, 212);
            this.lblEmpAddress.Name = "lblEmpAddress";
            this.lblEmpAddress.Size = new System.Drawing.Size(112, 25);
            this.lblEmpAddress.TabIndex = 16;
            this.lblEmpAddress.Text = "Address :";
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.Location = new System.Drawing.Point(17, 165);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(84, 25);
            this.lblEmpEmail.TabIndex = 15;
            this.lblEmpEmail.Text = "Email :";
            // 
            // lblEmpContact
            // 
            this.lblEmpContact.AutoSize = true;
            this.lblEmpContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpContact.Location = new System.Drawing.Point(17, 114);
            this.lblEmpContact.Name = "lblEmpContact";
            this.lblEmpContact.Size = new System.Drawing.Size(107, 25);
            this.lblEmpContact.TabIndex = 14;
            this.lblEmpContact.Text = "Contact :";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(17, 61);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(86, 25);
            this.lblEmpName.TabIndex = 13;
            this.lblEmpName.Text = "Name :";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(390, 340);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Details";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(302, 657);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(192, 657);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvEmpOrdrDetails
            // 
            this.dgvEmpOrdrDetails.AllowUserToAddRows = false;
            this.dgvEmpOrdrDetails.AllowUserToDeleteRows = false;
            this.dgvEmpOrdrDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpOrdrDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.EmpJobTitle,
            this.EmpContact,
            this.EmpEmail,
            this.EmpAddress});
            this.dgvEmpOrdrDetails.Location = new System.Drawing.Point(6, 369);
            this.dgvEmpOrdrDetails.Name = "dgvEmpOrdrDetails";
            this.dgvEmpOrdrDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpOrdrDetails.Size = new System.Drawing.Size(497, 273);
            this.dgvEmpOrdrDetails.TabIndex = 0;
            this.dgvEmpOrdrDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpOrdrDetails_CellDoubleClick);
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpId";
            this.EmpID.FillWeight = 103.9698F;
            this.EmpID.HeaderText = "ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.Width = 50;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "EmployeeName";
            this.EmpName.Name = "EmpName";
            // 
            // EmpJobTitle
            // 
            this.EmpJobTitle.DataPropertyName = "EmpJobTitle";
            this.EmpJobTitle.HeaderText = "JobTitle";
            this.EmpJobTitle.Name = "EmpJobTitle";
            this.EmpJobTitle.Width = 70;
            // 
            // EmpContact
            // 
            this.EmpContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpContact.DataPropertyName = "EmpContactNumber";
            this.EmpContact.HeaderText = "Contact";
            this.EmpContact.Name = "EmpContact";
            // 
            // EmpEmail
            // 
            this.EmpEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpEmail.DataPropertyName = "EmpEmail";
            this.EmpEmail.HeaderText = "Email";
            this.EmpEmail.Name = "EmpEmail";
            // 
            // EmpAddress
            // 
            this.EmpAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpAddress.DataPropertyName = "EmpAddress";
            this.EmpAddress.HeaderText = "Address";
            this.EmpAddress.Name = "EmpAddress";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(302, 340);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(192, 340);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 28;
            // 
            // EmployeeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 825);
            this.Controls.Add(this.EmpOrdrPanel);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EmployeeOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeOrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeOrderForm_FormClosed);
            this.EmpOrdrPanel.ResumeLayout(false);
            this.EmpOrdrPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpOrdrDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel EmpOrdrPanel;
        private System.Windows.Forms.DataGridView dgvEmpOrdrDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpContact;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpAddress;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.Label lblEmpContact;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}