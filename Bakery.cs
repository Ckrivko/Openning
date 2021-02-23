using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> employees;

        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            employees = new List<Employee>();
        }
        public int Count => employees.Count;
        public string Name { get; set; }

        public int Capacity { get; set; }

        public void Add(Employee employee)
        {
            if (employees.Count < Capacity)
            {
                employees.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            if (employees.Any(x => x.Name == name))
            {
                Employee employee = employees.FirstOrDefault(x => x.Name == name);
                employees.Remove(employee);
                return true;
            }
            return false;
        }

        public Employee GetOldestEmployee()
        {
            Employee employee = employees.OrderByDescending(x => x.Age).FirstOrDefault();
            return employee;
        }

        public Employee GetEmployee(string name)  // ??
        {
            Employee employee = employees.FirstOrDefault(x => x.Name == name);
            return employee;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");
            foreach (var employee in employees)
            {
                sb.AppendLine(employee.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}
