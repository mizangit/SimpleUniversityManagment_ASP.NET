using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using University_Management_System.Model;
using University_Management_System.BLL;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace University_Management_System
{
    public partial class Department_Entry : System.Web.UI.Page
    {
        DepartmentManager aDepartemntManager = new DepartmentManager();
        Department aDepartment = new Department();

        protected void Page_Load(object sender, EventArgs e)
        {
          
                GetAllDepartment();

             
          
     
         
            
        }


        public void GetAllDepartment()
        {
           
            departmentGridView.DataSource = aDepartemntManager.GetallDepartment();
            departmentGridView.DataBind();
        }

        protected void insertButton_Click(object sender, EventArgs e)
        {
            SaveData();
          
        }

        public void SaveData()
        {
            if (departmentNameTextBox.Text == string.Empty)
            {
                System.Threading.Thread.Sleep(2000);
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Enter Department Name')", true);
            }
            else
            {
                aDepartment.DepartmentName = departmentNameTextBox.Text;

                string mess = aDepartemntManager.SaveDepartment(aDepartment);
                System.Threading.Thread.Sleep(2000);

                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + mess + "')", true);

                GetAllDepartment();
                departmentNameTextBox.Text = String.Empty;
            }
        }

        protected void departmentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveData();
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void studentEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Entry.aspx");
        }

       

       

  

      
    }
}