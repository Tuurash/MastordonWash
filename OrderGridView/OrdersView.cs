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

namespace AllForms.OrderGridView
{
    public partial class OrdersView : Form
    {
        dgMgrVisible DDMgrV { get; set; }
        //ddg ddShow { get; set; }
        private DataSet Ds { get; set; }

        public OrdersView()
        {
            InitializeComponent();
        }
        public OrdersView(dgMgrVisible temp)
        {
            InitializeComponent();
            this.DDMgrV = temp;
        }

        private void OrdersView_FormClosed(object sender, FormClosedEventArgs e)
        {
            DDMgrV();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DDMgrV();
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OrderRepository ordrGrid = new OrderRepository();
            this.Ds = ordrGrid.ReturnGridView();
            this.orderGridView.AutoGenerateColumns = false;
            this.orderGridView.DataSource = this.Ds.Tables[0];
        }
    }
}
