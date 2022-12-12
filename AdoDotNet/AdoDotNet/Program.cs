using System;

namespace AdoDotNet
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcom To SQL Program");
                EmployeeRepository.GetAllEmployee();
                Console.ReadLine();
            }
        }
    }
}
}
