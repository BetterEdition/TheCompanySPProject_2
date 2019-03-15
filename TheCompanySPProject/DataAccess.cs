using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCompanySPProject.Model;
using Dapper;
using System.Data;
using System.Diagnostics;

namespace TheCompanySPProject
{
    class DataAccess
    {
        public List<Department> getDepartment(string depNum)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompanyDB")))
            {
                //var output = connection.Query<Department>($"select * from Department where DNumber = '{ depNum }'").ToList();
                var output = connection.Query<Department>($"dbo.uspGetDepartment @DNumber", new { DNumber = depNum }).ToList();
                
                return output;
            }
        }
        public List<Department> getAllDepartments()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompanyDB")))
            {
                var output = connection.Query<Department>($"dbo.uspGetAllDepartments").ToList();

                return output;
            }
        }

        public void updateDepartment(string name, int depNum)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompanyDB")))
            {
               connection.Query<Department>($"dbo.uspUpdateDepartmentName @DName, @DNumber", new { DName = name, DNumber = depNum });
              
            }
        }

        public void createDepartment(string name, int Manager)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompanyDB")))
            {
                connection.Query<Department>($"dbo.uspCreateDepartment @DName, @MgrSSN", new { DName = name, MgrSSN = Manager }); 
            }
        }
        public void deleteDepartment(int depNum)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompanyDB")))
            {
                connection.Query<Department>($"dbo.uspDeleteDepartment @departmentNum", new { departmentNum = depNum });
            }
        }
        
    }
}
