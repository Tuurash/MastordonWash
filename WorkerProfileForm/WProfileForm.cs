using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllForms.Repositories;
using AllForms.OrderDetailsForm;

namespace AllForms.WorkerProfileForm
{
    public delegate void dgWorker();
    public delegate string dgWkrID();
    public partial class WProfileForm : Form
    {
        //private DataSet Ds { get; set; }
        dgVisible LoginVisibility { get; set; }
        private string WkName { get; set; }
        private string ID { get; set; }
        private string Email { get; set; }
        private string Contact { get; set; }
        private string Address { get; set; }
        private string JobTitle { get; set; }
        public WProfileForm()
        {
            InitializeComponent();
        }
        public WProfileForm(string id, string name, string email, string address, string contact, string jobTitle, dgVisible temp)
        {
            InitializeComponent();
            this.WkName = name;
            this.Email = email;
            this.Address = address;
            this.ID = id;
            this.Contact = contact;
            this.JobTitle = jobTitle;
            this.LoginVisibility = temp;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Back Button
            this.Close();
            this.LoginVisibility();
        }

        private void WProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginVisibility();
        }

        private void WProfileForm_Load(object sender, EventArgs e)
        {
            //Show details when the form is loaded
            this.txtWorkerAddress.Text = this.Address;
            this.txtWorkerContact.Text = this.Contact;
            this.txtWorkerEmail.Text = this.Email;
            this.txtWorkerID.Text = this.ID;
            this.txtWorkerName.Text = this.WkName;
            this.txtJobTitle.Text = this.JobTitle;
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dgWorker wkrVisible = new dgWorker(Visibility);
            dgWkrID wkrId = new dgWkrID(GetWorkerID);
            OdrDetailsForm odrTemp = new OdrDetailsForm(wkrVisible, wkrId);
            odrTemp.Visible = true;
        }

        private void Visibility()
        {
            this.Visible = true;
        }
        private string GetWorkerID()
        {
            return this.ID;
        }
    }
}
