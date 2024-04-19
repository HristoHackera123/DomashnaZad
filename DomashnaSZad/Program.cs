namespace DomashnaSZad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employers> list = new List<Employers>();
            Console.Write("How much epmployees? ");
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Input info for employee {i+1} ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = 0;
                try
                {
                    salary = double.Parse(Console.ReadLine());
                }
                catch {}
                Console.Write("Pos: ");
                string position = Console.ReadLine();
                Console.Write("Field: ");
                string field = Console.ReadLine();
                Console.Write("Email: ");
                string? email = Console.ReadLine();
                Console.Write("Age: ");
                int? age = 0;
                try
                {
                    age = int.Parse(Console.ReadLine());
                }
                catch {}
                Employers employee = new Employers(name, salary, position, field, email, age);
                list.Add(employee);
            }

            Employers highest = new Employers();
            highest.Salary = double.MinValue;
            for (int i = 0;i < list.Count;i++)
            {
                if (list[i].Salary > highest.Salary)
                {
                    highest.Salary = list[i].Salary;
                    highest.Field = list[i].Field;
                }
            }
            Console.WriteLine($"Highest average salary is in {highest.Field}");
            for (int i =0;i<list.Count;i++)
            {
                if (list[i].Field == highest.Field)
                {
                    Console.WriteLine(string.Join(" ", list[i].Name, list[i].Salary, list[i].Email, list[i].Age));
                }
            }
        }
    }
}
