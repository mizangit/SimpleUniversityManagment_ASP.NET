using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using University_Management_System.Model;
using University_Management_System.BLL;

namespace University_Management_System
{
    public partial class Student_Entry : System.Web.UI.Page
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
        StudentManager aStudentManager = new StudentManager();
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList();
            }
            
            GridViewData();
        }

        public void DropDownList()
        {
            List<Department> aDepartment = aDepartmentManager.GetAllDepartment();

            departmentDropDownList.DataSource = aDepartment;
            departmentDropDownList.DataTextField = "DepartmentName";
            departmentDropDownList.DataValueField = "DepartmentID";
            departmentDropDownList.DataBind();

        }

        public void GridViewData()
        {
            searchGridView.DataSource = aStudentManager.GetAllStudent();
            searchGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (departmentDropDownList.SelectedValue=="" || nameTextBox.Text == string.Empty || regNoTextBox.Text == string.Empty || addressTextBox.Text == string.Empty)
            {
                if (departmentDropDownList.SelectedValue=="")
                {
                    //  ClientScript.RegisterStartupScript(this.GetType(), "", "alert='Enter Student Address'", true);
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('DropDown list is Empty')", true);
                }
                else if (nameTextBox.Text == string.Empty)
                {
                    //ClientScript.RegisterStartupScript(this.GetType(), "", "alert='Enter Student Name'", true);
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Enter Student Name')", true);
                }
               
                else if (regNoTextBox.Text == string.Empty)
                {
                    //ClientScript.RegisterStartupScript(this.GetType(), "", "alert='Enter Reg No '", true);
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Enter Reg No')", true);
                }
                else if (addressTextBox.Text == string.Empty)
                {
                  //  ClientScript.RegisterStartupScript(this.GetType(), "", "alert='Enter Student Address'", true);
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Enter Student Address')", true);
                }
                

            }
            
           else
            {
                Student aStudent = new Student();

                aStudent.StudentName = nameTextBox.Text;
                aStudent.StudentRegNo = regNoTextBox.Text;
                aStudent.StudentAddress = addressTextBox.Text;
                aStudent.DepartmentID = int.Parse(departmentDropDownList.SelectedValue.ToString());
                string mess = aStudentManager.SaveStudent(aStudent);
                System.Threading.Thread.Sleep(2000);
               
             //   ClientScript.RegisterStartupScript(this.GetType(), "", "alert='" + mess + "'", true);
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('"+mess+"')", true);
                nameTextBox.Text = string.Empty;
                addressTextBox.Text = string.Empty;
                regNoTextBox.Text = string.Empty;
            }
            GridViewData();

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.StudentName = searchNameTextBox.Text;
            aStudent.StudentRegNo = searchrRegNoTextBox.Text;
            searchGridView.DataSource = aStudentManager.SearchStudent(aStudent.StudentName, aStudent.StudentRegNo);
            System.Threading.Thread.Sleep(2000);
            searchGridView.DataBind();
        
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void departmentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Department_Entry.aspx");
        }

       

    }
}