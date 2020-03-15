namespace AllForms.ManagerProfileForm
{
    partial class ManagerForm
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
            this.MngrPanel = new System.Windows.Forms.Panel();
            this.txtMngrAddress = new System.Windows.Forms.TextBox();
            this.LblMngrAddress = new System.Windows.Forms.Label();
            this.txtMngrID = new System.Windows.Forms.TextBox();
            this.LblMngrID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblMngrProfile = new System.Windows.Forms.Label();
            this.txtMngrContact = new System.Windows.Forms.TextBox();
            this.txtMngrEmail = new System.Windows.Forms.TextBox();
            this.txtMngrName = new System.Windows.Forms.TextBox();
            this.lblMngrContact = new System.Windows.Forms.Label();
            this.lblMngrEmail = new System.Windows.Forms.Label();
            this.lblMngrName = new System.Windows.Forms.Label();
            this.ManagerMenu = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MngrPanel.SuspendLayout();
            this.ManagerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.Location = new System.Drawing.Point(12, 12);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(551, 81);
            this.LogoPanel.TabIndex = 0;
            // 
            // MngrPanel
            // 
            this.MngrPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MngrPanel.Controls.Add(this.txtMngrAddress);
            this.MngrPanel.Controls.Add(this.LblMngrAddress);
            this.MngrPanel.Controls.Add(this.txtMngrID);
            this.MngrPanel.Controls.Add(this.LblMngrID);
            this.MngrPanel.Controls.Add(this.btnBack);
            this.MngrPanel.Controls.Add(this.lblMngrProfile);
            this.MngrPanel.Controls.Add(this.txtMngrContact);
            this.MngrPanel.Controls.Add(this.txtMngrEmail);
            this.MngrPanel.Controls.Add(this.txtMngrName);
            this.MngrPanel.Controls.Add(this.lblMngrContact);
            this.MngrPanel.Controls.Add(this.lblMngrEmail);
            this.MngrPanel.Controls.Add(this.lblMngrName);
            this.MngrPanel.Controls.Add(this.ManagerMenu);
            this.MngrPanel.Location = new System.Drawing.Point(12, 99);
            this.MngrPanel.Name = "MngrPanel";
            this.MngrPanel.Size = new System.Drawing.Size(551, 557);
            this.MngrPanel.TabIndex = 1;
            // 
            // txtMngrAddress
            // 
            this.txtMngrAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMngrAddress.Location = new System.Drawing.Point(175, 418);
            this.txtMngrAddress.Name = "txtMngrAddress";
            this.txtMngrAddress.ReadOnly = true;
            this.txtMngrAddress.Size = new System.Drawing.Size(258, 26);
            this.txtMngrAddress.TabIndex = 14;
            // 
            // LblMngrAddress
            // 
            this.LblMngrAddress.AutoSize = true;
            this.LblMngrAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMngrAddress.Location = new System.Drawing.Point(33, 417);
            this.LblMngrAddress.Name = "LblMngrAddress";
            this.LblMngrAddress.Size = new System.Drawing.Size(112, 25);
            this.LblMngrAddress.TabIndex = 13;
            this.LblMngrAddress.Text = "Address :";
            // 
            // txtMngrID
            // 
            this.txtMngrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMngrID.Location = new System.Drawing.Point(175, 133);
            this.txtMngrID.Name = "txtMngrID";
            this.txtMngrID.ReadOnly = true;
            this.txtMngrID.Size = new System.Drawing.Size(258, 26);
            this.txtMngrID.TabIndex = 12;
            // 
            // LblMngrID
            // 
            this.LblMngrID.AutoSize = true;
            this.LblMngrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMngrID.Location = new System.Drawing.Point(97, 132);
            this.LblMngrID.Name = "LblMngrID";
            this.LblMngrID.Size = new System.Drawing.Size(48, 25);
            this.LblMngrID.TabIndex = 11;
            this.LblMngrID.Text = "ID :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(235, 514);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblMngrProfile
            // 
            this.lblMngrProfile.AutoSize = true;
            this.lblMngrProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMngrProfile.Location = new System.Drawing.Point(147, 52);
            this.lblMngrProfile.Name = "lblMngrProfile";
            this.lblMngrProfile.Size = new System.Drawing.Size(255, 29);
            this.lblMngrProfile.TabIndex = 8;
            this.lblMngrProfile.Text = "MANAGER PROFILE";
            // 
            // txtMngrContact
            // 
            this.txtMngrContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMngrContact.Location = new System.Drawing.Point(175, 245);
            this.txtMngrContact.Name = "txtMngrContact";
            this.txtMngrContact.ReadOnly = true;
            this.txtMngrContact.Size = new System.Drawing.Size(258, 26);
            this.txtMngrContact.TabIndex = 5;
            // 
            // txtMngrEmail
            // 
            this.txtMngrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMngrEmail.Location = new System.Drawing.Point(175, 304);
            this.txtMngrEmail.Name = "txtMngrEmail";
            this.txtMngrEmail.ReadOnly = true;
            this.txtMngrEmail.Size = new System.Drawing.Size(258, 26);
            this.txtMngrEmail.TabIndex = 4;
            // 
            // txtMngrName
            // 
            this.txtMngrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMngrName.Location = new System.Drawing.Point(175, 187);
            this.txtMngrName.Name = "txtMngrName";
            this.txtMngrName.ReadOnly = true;
            this.txtMngrName.Size = new System.Drawing.Size(258, 26);
            this.txtMngrName.TabIndex = 3;
            // 
            // lblMngrContact
            // 
            this.lblMngrContact.AutoSize = true;
            this.lblMngrContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMngrContact.Location = new System.Drawing.Point(38, 244);
            this.lblMngrContact.Name = "lblMngrContact";
            this.lblMngrContact.Size = new System.Drawing.Size(107, 25);
            this.lblMngrContact.TabIndex = 2;
            this.lblMngrContact.Text = "Contact :";
            // 
            // lblMngrEmail
            // 
            this.lblMngrEmail.AutoSize = true;
            this.lblMngrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMngrEmail.Location = new System.Drawing.Point(61, 303);
            this.lblMngrEmail.Name = "lblMngrEmail";
            this.lblMngrEmail.Size = new System.Drawing.Size(84, 25);
            this.lblMngrEmail.TabIndex = 1;
            this.lblMngrEmail.Text = "Email :";
            // 
            // lblMngrName
            // 
            this.lblMngrName.AutoSize = true;
            this.lblMngrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMngrName.Location = new System.Drawing.Point(59, 186);
            this.lblMngrName.Name = "lblMngrName";
            this.lblMngrName.Size = new System.Drawing.Size(86, 25);
            this.lblMngrName.TabIndex = 0;
            this.lblMngrName.Text = "Name :";
            // 
            // ManagerMenu
            // 
            this.ManagerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.ManagerMenu.Location = new System.Drawing.Point(0, 0);
            this.ManagerMenu.Name = "ManagerMenu";
            this.ManagerMenu.Size = new System.Drawing.Size(551, 24);
            this.ManagerMenu.TabIndex = 9;
            this.ManagerMenu.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeDetailsToolStripMenuItem,
            this.orderDetailsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details";
            this.employeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailsToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 668);
            this.Controls.Add(this.MngrPanel);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.ManagerMenu;
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.MngrPanel.ResumeLayout(false);
            this.MngrPanel.PerformLayout();
            this.ManagerMenu.ResumeLayout(false);
            this.ManagerMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel MngrPanel;
        private System.Windows.Forms.Label lblMngrProfile;
        private System.Windows.Forms.TextBox txtMngrContact;
        private System.Windows.Forms.TextBox txtMngrEmail;
        private System.Windows.Forms.TextBox txtMngrName;
        private System.Windows.Forms.Label lblMngrContact;
        private System.Windows.Forms.Label lblMngrEmail;
        private System.Windows.Forms.Label lblMngrName;
        private System.Windows.Forms.MenuStrip ManagerMenu;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtMngrAddress;
        private System.Windows.Forms.Label LblMngrAddress;
        private System.Windows.Forms.TextBox txtMngrID;
        private System.Windows.Forms.Label LblMngrID;
    }
}