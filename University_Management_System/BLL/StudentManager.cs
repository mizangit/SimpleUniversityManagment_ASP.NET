using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University_Management_System.DAL;
using University_Management_System.Model;

namespace University_Management_System.BLL
{
    public class StudentManager
    {
        StudentGateway aStudentGateway = new StudentGateway();

        internal string SaveStudent(Model.Student aStudent)
        {

            int value = aStudentGateway.SaveStudent(aStudent);
            if (value > 0)
            {
                return "Student Information saved";
            }
            else
            {
                return "Student Information not save";
            }
           
        }

        internal List<Student> GetAllStudent()
        {
            return aStudentGateway.GetAllStudent();
        }

        internal List<Student> SearchStudent(string p1, string p2)
        {
            return aStudentGateway.SearchStudent(p1, p2);
        }
    }
}