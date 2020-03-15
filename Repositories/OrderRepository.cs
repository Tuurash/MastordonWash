using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AllForms.Repositories
{
    //delegate DataSet ddg();
    class OrderRepository
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        internal OrderRepository()
        {
            this.Da = new DataAccess();
            //ddg ddGrid = new ddg(this.ReturnGridView);
            //ddg ddSearch = new ddg(this.SearchOrder);
        }

        public DataSet ReturnGridView()
        {
            string sql = "select * from customerOrder;";
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
        }
        
       
        /*public DataSet SearchOrder()
        {
            string sql = "select OdrPrice from customerOrder where ordrID = '" + this.OdrPrice + "';";
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
        }*/


        public void InsertOrder(string odrId, string empID, string cusName, string phone, string carModel, int odrPrice)
        {
            string sql = "select * from customerOrder where ordrID ='" + odrId + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update customerOrder
                set ordrID = '" + odrId + @"', 
                empID = '" + empID + @"',
                cusName = '" + cusName + @"',
                phone = '" + phone + @"',
                carModel = '" + carModel + @"',
                odrPrice = " + odrPrice + @"
                where ordrID = '" + odrId + "';";

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Upgradation Done.");
                    //this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            
            } 
            else
            {
                sql = @"insert into customerOrder
                    values ('" + odrId + "', '" + empID + "', '" + cusName + @"'
                    , '" + phone + "', '" + carModel + "', " + odrPrice + ");";
                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Insertion Done.");
                    //this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            
           
            
        }

        public void Delete(string id)
        {
            //string id = this.dgvMain.CurrentRow.Cells["id"].Value.ToString();
            string sql = "delete from customerOrder where ordrID = '" + id + "';";
            try
            {
                 this.Da.ExecuteUpdateQuery(sql);
                 MessageBox.Show("Deletion Done.");
                 //this.PopulateGridView();
            }
            catch (Exception exc)
            {
                 MessageBox.Show("Error: " + exc.Message);
            }
        }
    }
}
