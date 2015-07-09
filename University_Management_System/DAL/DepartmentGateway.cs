using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University_Management_System.Model;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace University_Management_System.DAL
{
    public class DepartmentGateway
    {
        string connectionDB = ConfigurationManager.ConnectionStrings["DepartmentConnectionDb"].ConnectionString;
        public List<Model.Department> GetAllDepartment()
        {
            SqlConnection connection = new SqlConnection(connectionDB);
            String query = "SELECT * FROM Departments";
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Department>  aDepartmentList = new List<Model.Department>();

            while (aReader.Read())
            {
                Department aDeparetmet = new Model.Department();

                aDeparetmet.DepartmentID = int.Parse(aReader["Id"].ToString());
                aDeparetmet.DepartmentName = aReader["Name"].ToString();

                aDepartmentList.Add(aDeparetmet);

            }
            aReader.Close();
            connection.Close();
            return aDepartmentList;

        }

       

        public int SaveDepartment(Model.Department aDepartment)
        {
            SqlConnection connection = new SqlConnection(connectionDB);

            string query2 = "INSERT INTO Departments VALUES('" + aDepartment.DepartmentName + "')";

            SqlCommand command = new SqlCommand(query2, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;




        }

        internal Department CheckDepartment(Model.Department aDepartment)
        {
            SqlConnection connection = new SqlConnection(connectionDB);

            string query2 = "Select * From Departments where Name='"+aDepartment.DepartmentName+"'";
            connection.Open();
            SqlCommand aCommand = new SqlCommand(query2, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();

            Department adepartmentdata = null;

            while (aReader.Read())
            {
                if (adepartmentdata == null)
                {
                    adepartmentdata = new Model.Department();
                }
                adepartmentdata.DepartmentName = aReader["Name"].ToString();

            }
            aReader.Close();
            connection.Close();
            return adepartmentdata;

        }
    }
}