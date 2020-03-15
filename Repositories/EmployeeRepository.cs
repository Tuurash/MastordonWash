using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using AllForms.EmployeeAndOrderView;

namespace AllForms.Repositories
{
    class EmployeeRepository
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private string Name { get; set; }
        private string Contact { get; set; }
        private string Email { get; set; }
        private string Address { get; set; }
        private string Id { get; set;}
        private string Password { get; set; }
        private string JobTitle { get; set; }
        //EmployeeOrderForm oTemp = new EmployeeOrderForm();
        //private int Nid { get; set; }

        internal EmployeeRepository()
        {
            this.Da = new DataAccess();
        }


        internal EmployeeRepository(string id, string name, string contact, string email, string address, string jobTitle)
        {
            this.Da = new DataAccess();
            this.Name = name;
            this.Contact = contact;
            this.Email = email;
            this.Address = address;
            this.Id = id;
            this.JobTitle = jobTitle;
            //this.Password = password;
        }


        public DataSet ReturnGridView(string sql = "select * from Employee;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
        }

        public DataSet SearchLoginData(string id, string password)
        {
            string sql = "select * from Employee where EmpId = '"+ id +"'  AND EmpPassword = '"+ password +"';";
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
        }

        public DataSet SearchUser(string name)
        {
            string sql = "select * from Employee where EmpName = '" + name + "';";
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
        }

        
        public void Insert()
        {
            string sql = "select * from Employee where EmpId ='" + this.Id + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update Employee
                set EmpName = '" + this.Name + @"',
                EmpAddress = '" + this.Address + @"',
                EmpEmail = '" + this.Email + @"',
                EmpJobTitle = '" + this.JobTitle + @"',
                EmpContactNumber = '" + this.Contact + @"'
                where EmpId = '" + this.Id + "';";

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
                sql = @"insert into Employee
                values ('" + this.Id + "', '" + this.Name + "', '" + this.Address + "', '" + this.Email + @"'
                , '" + this.Contact + "', '" + this.JobTitle + "', '" + this.Password + "');";
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

        public void DeleteEmployee()
        {
            string sql = "delete from Employee where EmpId = '"+ this.Id +"';";
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
