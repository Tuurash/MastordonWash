using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllForms.ManagerProfileForm;
using AllForms.Repositories;

namespace AllForms.EmployeeAndOrderView
{
    public partial class EmployeeOrderForm : Form
    {
        dgMgrVisible DDMgrV { get; set; }
        //private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public EmployeeOrderForm()
        {
            InitializeComponent();
            //this.Da = new DataAccess();
        }
        public EmployeeOrderForm(dgMgrVisible temp)
        {
            InitializeComponent();
            this.DDMgrV = temp;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DDMgrV();
            this.Close();
        }

        private void EmployeeOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DDMgrV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.EditDetails();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.ShowGrid();
        }

        private void dgvEmpOrdrDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeRepository repTemp = new EmployeeRepository(this.txtEmpID.Text, this.txtEmpName.Text, this.txtEmpContact.Text, this.txtEmpEmail.Text, this.txtEmpAddress.Text, this.txtJobTitle.Text);
            repTemp.Insert();
            this.ShowGrid();
        }
        private void ShowGrid()
        {
            EmployeeRepository repTemp = new EmployeeRepository();
            //repTemp.Populate();
            this.Ds = repTemp.ReturnGridView();
            this.dgvEmpOrdrDetails.AutoGenerateColumns = false;
            this.dgvEmpOrdrDetails.DataSource = this.Ds.Tables[0];
        }

        private void EditDetails()
        {
            this.txtEmpID.Text = this.dgvEmpOrdrDetails.CurrentRow.Cells["EmpID"].Value.ToString();
            this.txtEmpName.Text = this.dgvEmpOrdrDetails.CurrentRow.Cells["EmpName"].Value.ToString();
            this.txtEmpContact.Text = this.dgvEmpOrdrDetails.CurrentRow.Cells["EmpContact"].Value.ToString();
            this.txtEmpEmail.Text = this.dgvEmpOrdrDetails.CurrentRow.Cells["EmpEmail"].Value.ToString();
            this.txtEmpAddress.Text = this.dgvEmpOrdrDetails.CurrentRow.Cells["EmpAddress"].Value.ToString();
            this.txtJobTitle.Text = this.dgvEmpOrdrDetails.CurrentRow.Cells["EmpJobTitle"].Value.ToString();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeRepository repTemp = new EmployeeRepository(this.txtEmpID.Text, this.txtEmpName.Text, this.txtEmpContact.Text, this.txtEmpEmail.Text, this.txtEmpAddress.Text, this.txtJobTitle.Text);
            repTemp.DeleteEmployee();
            this.ShowGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeRepository repSearch = new EmployeeRepository();
            this.Ds = repSearch.SearchUser(this.txtSearch.Text);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                this.dgvEmpOrdrDetails.AutoGenerateColumns = false;
                this.dgvEmpOrdrDetails.DataSource = this.Ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Employee Name!");
            }
        }
    }
}
