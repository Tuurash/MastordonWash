using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllForms.OrderDetailsForm;

namespace AllForms.TakeOrderForm
{
    public partial class ShowOrderForm : Form
    {
        odrFormVisible ddOrderFormVisible { get; set; }
        private string CustomerName { get; set; }
        private string CarModel { get; set; }
        private string CustomerContact { get; set; }
        private int Discount { get; set; }
        private int TotalCost { get; set; }

        public ShowOrderForm()
        {
            InitializeComponent();
        }
        public ShowOrderForm(string name, string cModel, string contact, int discount, int totalCost, odrFormVisible temp)
        {
            InitializeComponent();
            this.CustomerName = name;
            this.CustomerContact = contact;
            this.CarModel = cModel;
            this.Discount = discount;
            this.TotalCost = totalCost;
            this.ddOrderFormVisible = temp;
        }

        private void ShowOrderForm_Load(object sender, EventArgs e)
        {
            this.txtTkCarModel.Text = this.CarModel;
            this.txtTkCusName.Text = this.CustomerName;
            this.txtTkCusContact.Text = this.CustomerContact;
            this.txtDiscount.Text = this.Discount.ToString();
            this.txtTotalCost.Text = this.TotalCost.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ddOrderFormVisible();
        }
    }
}
