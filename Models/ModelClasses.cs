using System;
using System.Collections.Generic;
namespace appbasic1.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
    }

    public class EmployeeDatabase : List<Employee>
    {

        public EmployeeDatabase()
        {
            for(int x = 0; x < 100; x++)
            {
                Add(new Employee() { EmpNo = x, EmpName = $"{x} MS" });
                // Add(new Employee() { EmpNo = 102, EmpName = "LS" });
                // Add(new Employee() { EmpNo = 103, EmpName = "TS" });
            }
        }
    }
}