namespace DomashnaSZad
{
    internal class Program
    {
        static void Main()
        {
            List<Employers> list = new List<Employers>();
            Console.Write("How much employees? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Input info for employee {i + 1} ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = 0;
                try
                {
                    salary = double.Parse(Console.ReadLine());
                }
                catch { }
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
                catch { }
                Employers employee = new Employers(name, salary, position, field, email, age);
                list.Add(employee);
            }

            string WealthiestField = FindWealthiestField(list);
            Console.WriteLine($"Highest average salary is in {WealthiestField}");
            List<Employers> answer = FindAndSortRichestField(list, WealthiestField);
            
            for (int i = 0 ; i < answer.Count ; i++)
            {
                Console.WriteLine($"{answer[i].Name} {answer[i].Salary:f2} {answer[i].Email} {answer[i].Age}");
            }
            //Employers highest = new Employers();
            //highest.Salary = double.MinValue;
            //for (int i = 0;i < list.Count;i++)
            //{
            //    if (list[i].Salary > highest.Salary)
            //    {
            //        highest.Salary = list[i].Salary;
            //        highest.Field = list[i].Field;
            //    }
            //}
            //Console.WriteLine($"Highest average salary is in {highest.Field}");
            //for (int i =0;i<list.Count;i++)
            //{
            //    if (list[i].Field == highest.Field)
            //    {
            //        Console.WriteLine(string.Join(" ", list[i].Name, list[i].Salary, list[i].Email, list[i].Age));
            //    }
            //}
        }
        static string FindWealthiestField(List<Employers> list)
        {
            List<string> fields = new List<string>();
            string highestField = null;
            double highestAvg = double.MinValue;
            string curField = null;
            foreach (Employers item in list)
            {
                if (string.Compare(item.Field, curField, true) != 0)
                {
                    fields.Add(item.Field);
                    curField = item.Field;
                }
            }

            for (int i = 0; i < fields.Count; i++)
            {
                short counter = 0;
                double sum = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (string.Compare(fields[i], list[j].Field, true) == 0)
                    {
                        counter++;
                        sum += list[j].Salary;
                    }
                }

                if ((double)sum / counter > highestAvg)
                {
                    highestAvg = sum/counter;
                    highestField = fields[i];
                }

            }
            return highestField;
        }
        static List<Employers> FindAndSortRichestField(List<Employers> list, string highestField)
        {
            List<Employers> result = new List<Employers>();
            foreach (Employers item in list)
            {
                if (item.Field == highestField)
                {
                    result.Add(item);
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                int index = i;
                Employers swap = result[i];
                while (index > 0 && result[index-1].Salary >= swap.Salary)
                {
                    result[index] = result[index-1];
                    index--;
                }
                
            }
            result.Reverse();
            return result;
        }
    }
}
