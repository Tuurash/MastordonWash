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

namespace AllForms.UserRegisterForm
{
    public partial class RegisterForm : Form
    {
        dgVisible LoginVisibility { get; set; }
        private DataSet Ds { get; set; }
        private string RegID { get; set; }
        public RegisterForm()
        {
            InitializeComponent();
        }
        public RegisterForm(dgVisible temp)
        {
            InitializeComponent();
            this.LoginVisibility = temp;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Back Button
            this.Close();
            LoginVisibility();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If Form is Closing LoginForm visibility should change
            LoginVisibility();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Save the user info
            if (this.txtRegPass.Text.Equals(this.txtRegConfirmPass.Text))
            {
                EmployeeRepository repTemp = new EmployeeRepository(this.txtRegID.Text, this.txtRegName.Text, this.txtRegContact.Text, this.txtRegEmail.Text, this.txtRegAddress.Text, this.txtRegJobTitle.Text, this.txtRegPass.Text);
                repTemp.Insert();
                this.Close();
                LoginVisibility();
            }
            else
            {
                MessageBox.Show("Incorrect Password.");
            }
            //If someone registers then he will be directed to login Form.
            //Employee details is stored in database
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            EmployeeRepository repTemp = new EmployeeRepository();
            this.Ds = repTemp.ReturnGridView();
            int temp = this.Ds.Tables[0].Rows.Count;
            this.RegID = "Emp-" + ++temp;
            this.txtRegID.Text = this.RegID;
        }
       
        
    }
}
