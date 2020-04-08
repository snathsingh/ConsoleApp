using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Dapper.FluentMap;
using Dapper.FluentMap.Mapping;

namespace ConsoleApp1
{
    internal class EmployeeMap : EntityMap<DetailEmployee>
    {
        public EmployeeMap()
        {
            Map(x => x.EmpId).ToColumn("id");
        }
    }
    internal class StudentMap : EntityMap<Student>
    {
        public StudentMap()
        {
            Map(x => x.Name).ToColumn("EName");
        }
    }

    class Program
    {
        static void Main()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new EmployeeMap());
                config.AddMap(new StudentMap());
            });
            using (IDbConnection con = new SqlConnection(Helper.GetConnectionString("DBCS")))
            {
                
                List<DetailEmployee> detailEmployees = new List<DetailEmployee>();
                List<Student> students = new List<Student>();
                var result=con.QueryMultiple("select * from DetailEmployee;select * from student", commandType: CommandType.Text);
                //detailEmployees = result.Read<DetailEmployee>().ToList();
                var emp = result.Read<DetailEmployee>();
                students = result.Read<Student>().ToList();
            }
        }
    }
}
