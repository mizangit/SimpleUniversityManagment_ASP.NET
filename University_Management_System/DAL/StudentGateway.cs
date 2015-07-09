using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University_Management_System.DAL;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using University_Management_System.Model;

namespace University_Management_System.DAL
{
    public class StudentGateway
    {

        String connectionDB = ConfigurationManager.ConnectionStrings["DepartmentConnectionDb"].ConnectionString; 
        public int SaveStudent(Model.Student aStudent)
        {
            SqlConnection connection = new SqlConnection(connectionDB);
            //string query = "INSERT INTO Students VALUES('" + aStudent.StudentName + "','" + aStudent.StudentRegNo + "','" + aStudent.StudentAddress + "','" + aStudent.DepartmentID + "',)";
            //SqlCommand acommand = new SqlCommand(query, connection);
            //connection.Open();
            //int affectedRow = acommand.ExecuteNonQuery();
            //connection.Close();
            //return affectedRow;

            string query = "INSERT INTO Students VALUES('" + aStudent.StudentName + "', '" + aStudent.StudentRegNo + "', '" + aStudent.StudentAddress + "', '" + aStudent.DepartmentID + "')";
            //insert student
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        
        }

        internal List<Model.Student> GetAllStudent()
        {
            SqlConnection connection = new SqlConnection(connectionDB);
            string query = "Select * From Students";

            SqlCommand aCommand = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Student> aStudentList = new List<Student>();
            while (aReader.Read())
            {
                Student aStudent = new Student();
                aStudent.StudentName = aReader["Name"].ToString();
                aStudent.StudentRegNo = aReader["RegNo"].ToString();
                aStudent.StudentAddress = aReader["Address"].ToString();
                aStudent.DepartmentID = int.Parse(aReader["DepartmentId"].ToString());
                aStudentList.Add(aStudent);

            }
            aReader.Close();
            connection.Close();
            return aStudentList;
        
        }
        
        internal List<Student> SearchStudent(string p1, string p2)
        {
            SqlConnection connection = new SqlConnection(connectionDB);

            string query = "Select * From Students";

            //if(p1=="" && p2=="")
            //{
            //     query = "Select * From Students";
            //}
            if(p1 != "" && p2 != "")
            {
                 query = "Select * From Students Where Name='" +p1+ "' And RegNo='"+p2+"'";
            }
            else if (p1 != "" )
            {
                query = "Select * From Students Where Name='" + p1 + "'";
            }
            else if (p2!="")
            {
                 query = "Select * From Students Where RegNo='"+p2+"'";
            }
            
           

            SqlCommand aCommand = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Student> aStudentList = new List<Student>();
            while (aReader.Read())
            {
                Student aStudent = new Student();
                aStudent.StudentName= aReader["Name"].ToString();
                aStudent.StudentRegNo = aReader["RegNo"].ToString();
                aStudent.StudentAddress = aReader["Address"].ToString();
                aStudent.DepartmentID = int.Parse(aReader["DepartmentId"].ToString());
                aStudentList.Add(aStudent);
            }
            aReader.Close();
            connection.Close();
            return aStudentList;
        }
    }
}