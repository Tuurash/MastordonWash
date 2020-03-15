using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllForms.EmployeeAndOrderView;
using AllForms.OrderGridView;

namespace AllForms.ManagerProfileForm
{
    public delegate void dgMgrVisible();
    public partial class ManagerForm : Form
    {
        dgVisible LoginVisibility { get; set; }
        private string MngrName { get; set; }
        private string ID { get; set; }
        private string Email { get; set; }
        private string Contact { get; set; }
        private string Address { get; set; }
        public ManagerForm()
        {
            InitializeComponent();
        }
        public ManagerForm(string id, string name, string email, string address, string contact, dgVisible temp)
        {
            InitializeComponent();
            this.MngrName = name;
            this.Email = email;
            this.Address = address;
            this.ID = id;
            this.Contact = contact;
            this.LoginVisibility = temp;
        }
        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Employee Details will be shown
            this.Visible = false;
            dgMgrVisible DDMV = new dgMgrVisible(Visibility);
            EmployeeOrderForm empOrder = new EmployeeOrderForm(DDMV);
            empOrder.Visible = true;
        }
        private void Visibility()
        {
            this.Visible = true;
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If Form is Closing LoginForm visibility should change
            LoginVisibility();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dgMgrVisible DDMV = new dgMgrVisible(Visibility);
            OrdersView odrView = new OrdersView(DDMV);
            odrView.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginVisibility();
            this.Close();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            //Show details when the form is loaded
            this.txtMngrAddress.Text = this.Address;
            this.txtMngrContact.Text = this.Contact;
            this.txtMngrEmail.Text = this.Email;
            this.txtMngrID.Text = this.ID;
            this.txtMngrName.Text = this.MngrName;
        }
    }
}
