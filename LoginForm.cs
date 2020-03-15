using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllForms.UserRegisterForm;
using AllForms.WorkerProfileForm;
using AllForms.ManagerProfileForm;
using AllForms.Repositories;

namespace AllForms
{
    public delegate void dgVisible();
    
    public partial class LoginForm : Form
    {
        private DataSet Ds { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            EmployeeRepository repTemp = new EmployeeRepository();
            //repTemp.Populate();
            this.Ds = repTemp.SearchLoginData(this.txtLoginID.Text, this.txtLoginPass.Text);

            // Needs to add password and title to employee table
            
            if(this.Ds.Tables[0].Rows.Count == 1)
            {
                string id = this.Ds.Tables[0].Rows[0]["EmpId"].ToString();
                string name = this.Ds.Tables[0].Rows[0]["EmpName"].ToString();
                string email = this.Ds.Tables[0].Rows[0]["EmpEmail"].ToString();
                string address = this.Ds.Tables[0].Rows[0]["EmpAddress"].ToString();
                string contact = this.Ds.Tables[0].Rows[0]["EmpContactNumber"].ToString();
                string jobTitle = this.Ds.Tables[0].Rows[0]["EmpJobTitle"].ToString();

                if(this.Ds.Tables[0].Rows[0]["EmpJobTitle"].ToString() == "Manager" )
                {
                    
                    this.Visible = false;
                    dgVisible visibility = new dgVisible(Visibility_Changing);
                    ManagerForm mgrTemp = new ManagerForm(id, name, email, address, contact, visibility);
                    mgrTemp.Visible = true;
                    
                }
                else
                {
                    this.Visible = false;
                    dgVisible visibility = new dgVisible(Visibility_Changing);
                    WProfileForm wpTemp = new WProfileForm(id, name, email, address, contact, jobTitle, visibility);
                    wpTemp.Visible = true;
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password!");
            }

            /*this.Visible = false;
            dgVisible visibility = new dgVisible(Visibility_Changing);
            /*WProfileForm wpTemp = new WProfileForm(visibility);
            wpTemp.Visible = true;
            ManagerForm mgrTemp = new ManagerForm(visibility);
            mgrTemp.Visible = true;*/
        }
        private void Visibility_Changing()
        {
            this.Visible = true;
            this.txtLoginID.Text = "";
            this.txtLoginPass.Text = "";
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //Register Button
            this.Visible = false;
            //using deligates
            dgVisible visibility = new dgVisible(Visibility_Changing);
            RegisterForm rfTemp = new RegisterForm(visibility);
            rfTemp.Visible = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
