using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    class DetailEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
        public string EmpSalary { get; set; }
        public string EmpCity { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string EmpCity { get; set; }
    }
}
