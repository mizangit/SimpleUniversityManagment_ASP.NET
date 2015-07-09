using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University_Management_System.DAL;
using University_Management_System.Model;


namespace University_Management_System.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway aDepartmentGatway = new DepartmentGateway();
        internal List<Model.Department> GetallDepartment()
        {
            return aDepartmentGatway.GetAllDepartment();
        }

       

        public string SaveDepartment(Model.Department aDepartment)
        {
            Department checkValue = aDepartmentGatway.CheckDepartment(aDepartment);




            if (checkValue!=null)
            {
                return "Data already exiest ";
            }
            else
            {
                int value = aDepartmentGatway.SaveDepartment(aDepartment);

                if (value > 0)
                {
                    return "Data is saved";
                }
                else
                {
                    return "Data not saved";
                }
            }
            
        }

        internal List<Department> GetAllDepartment()
        {
            return aDepartmentGatway.GetAllDepartment();
        }

        
    }
}