using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomashnaSZad
{
    public class Employers
    {
        private string name;
        private double salary;
        private string position;
        private string field;
        private string? email;
        private int? age;

        public string Name
        {
            get { return name; }
            set
            {
                while (value == "" )
                {
                    Console.WriteLine("Name is mandatory");
                    value = Console.ReadLine();
                }
                name = value;
            }
        }
        public double Salary
        {
            get { return salary; }
            set
            { 
                while (value == 0d)
                {
                    Console.WriteLine("Salary is mandatory");
                    try
                    {
                        value = double.Parse(Console.ReadLine());
                    }
                    catch { value = 0d; }
                }
                salary = value;
            }
        }
        public string Position
        {
            get { return position; }
            set
            {
                while (value == "")
                {
                    Console.WriteLine("Position is mandatory");
                    value = Console.ReadLine();
                }
                position = value;
            }
        }
        public string Field
        {
            get { return field; }
            set
            {
                while (value == "")
                {
                    Console.WriteLine("Field is mandatory");
                    value = Console.ReadLine();
                }
                field = value;
            }
        }
        public string? Email
        {
            get { return email; }
            set
            {
                if (value != "")
                {
                    email = value;
                }
                else
                {
                    email = "n/a";
                }
            }
        }
        public int? Age
        {
            get { return age; }
            set
            {
                if (value != 0)
                {
                    age = value;
                }
                else
                {
                    age = -1;
                }
            }
        }
        public Employers(string name, double salary, string position, string field, string? email, int? age)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Field = field;
            Email = email;
            Age = age;
        }
        public Employers()
        {
        }

    }
}
