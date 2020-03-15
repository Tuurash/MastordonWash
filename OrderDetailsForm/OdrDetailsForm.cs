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
using AllForms.WorkerProfileForm;
using AllForms.TakeOrderForm;


namespace AllForms.OrderDetailsForm
{
    public delegate void odrFormVisible();
    public partial class OdrDetailsForm : Form
    {
        dgWorker wkrVisiblity { get; set; }
        dgWkrID getWkrID { get; set; }
        bool dc = true;
        private DataSet Ds { get; set; }

        private string CustomerName { get; set; }
        private string CustomerContact { get; set; }
        private string OrderID { get; set; }
        private string CarModel { get; set; }
        private string EmployeeID { get; set; }
        private int OrderPrice { get; set; }

        public OdrDetailsForm(dgWorker temp, dgWkrID tempID)
        {
            InitializeComponent();
            this.wkrVisiblity = temp;
            this.getWkrID = tempID;
            this.OrderPrice = 0;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.GetValue();
            string discount = this.txtDiscount.Text;
            if (int.Parse(discount) > 0 && this.dc)
            {
                this.OrderPrice = this.OrderPrice - int.Parse(discount);
                this.dc = false;
            }
            OrderRepository odrTemp = new OrderRepository();
            odrTemp.InsertOrder(this.OrderID, this.EmployeeID, this.CustomerName, this.CustomerContact, this.CarModel, this.OrderPrice);
        }

        private void GetValue()
        {
            this.CustomerContact = this.txtCusContact.Text;
            this.CustomerName = this.txtCusName.Text;
            //this.OrderID = this.txtOdrID.Text;
            this.CarModel = this.txtCarModel.Text;

        }

        private void btnWash_Click(object sender, EventArgs e)
        {
            this.OrderPrice += 1000;
            string discount = this.txtDiscount.Text;
            if (int.Parse(discount) > 0 && this.dc)
            {
                this.OrderPrice = this.OrderPrice - int.Parse(discount);
                this.dc = false;
            }
            this.btnWash.Enabled = false;
            this.txtTotalCost.Text = this.OrderPrice.ToString();
            
        }

        private void btnPolish_Click(object sender, EventArgs e)
        {
            this.OrderPrice += 500;
            string discount = this.txtDiscount.Text;
            if (int.Parse(discount) > 0 && this.dc)
            {
                this.OrderPrice = this.OrderPrice - int.Parse(discount);
                this.dc = false;
            }
            this.btnPolish.Enabled = false;
            this.txtTotalCost.Text = this.OrderPrice.ToString();
        }

        private void btnInterior_Click(object sender, EventArgs e)
        {
            this.OrderPrice += 500;
            string discount = this.txtDiscount.Text;
            if (int.Parse(discount) > 0 && this.dc)
            {
                this.OrderPrice = this.OrderPrice - int.Parse(discount);
                this.dc = false;
            }
            this.btnInterior.Enabled = false;
            this.txtTotalCost.Text = this.OrderPrice.ToString();
        }

        
        private void OdrDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.wkrVisiblity();
        }

        private void OdrDetailsForm_Load(object sender, EventArgs e)
        {
            this.EmployeeID = getWkrID();
            this.txtEmpId.Text = this.EmployeeID;
            OrderRepository ordrGrid = new OrderRepository();
            this.Ds = ordrGrid.ReturnGridView();
            int temp = this.Ds.Tables[0].Rows.Count;
            this.OrderID = "Odr-" + ++temp ;
            this.txtOdrID.Text = this.OrderID;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.wkrVisiblity();
        }

        private void VisibilityForm()
        {
            this.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.GetValue();
            int discount = int.Parse(this.txtDiscount.Text);
            odrFormVisible visibility = new odrFormVisible(this.VisibilityForm);
            ShowOrderForm showOrder = new ShowOrderForm(this.CustomerName, this.CarModel, this.CustomerContact, discount, this.OrderPrice, visibility);
            showOrder.Visible = true;
        }
        
    }
}
