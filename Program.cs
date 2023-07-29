using System;
using System.IO;
using Newtonsoft.Json;

namespace JSONCreator
{
    class Program
    {
        static void Main()
        {
            string[] sectorOptions = {
                "Unassigned", "IT", "Software Engineer","Full-stack Web Developer",
                "Data Scientist","DevOps Engineer","QA Tester"
            };

            System.Console.WriteLine("Choose the type of file: ");
            System.Console.WriteLine("1./t.TXT/n2./t.JSON");
            int fileChoice = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Choose the name of the file: ");
            string fileName = Console.ReadLine();
            string path = "";

            if (fileChoice == 1) path = TXT.ToTXT(fileName);
            else if (fileChoice == 2) path = JSON.ToJSON(fileName);
            else System.Console.WriteLine("Invalid option.");

            System.Console.WriteLine("Choose the number of employees: ");
            int numOfEmployees = Convert.ToInt32(Console.ReadLine());
            string json = "";
            for (int i = 0; i < numOfEmployees; i++)
            {
                Employee employee = new Employee();

                employee.id = i;
                Console.WriteLine("Please enter your full name: ");
                employee.fullname = Convert.ToString(Console.ReadLine());
                System.Console.WriteLine("Choose your sector:");
                for (int y = 1; y < sectorOptions.Length; y++)
                {
                    System.Console.WriteLine($"{y}\t{sectorOptions[y]}");;
                }

                int sectorChoice = Convert.ToInt32(Console.ReadLine());
                employee.sector = Sector.ChoosingSector(sectorChoice);
                employee.hired_date = DateTime.Now;
                System.Console.WriteLine("Is the employee on vacation: Y/N");
                char OnHoliday = Convert.ToChar(Console.ReadLine());
                if(OnHoliday == 'Y' || OnHoliday == 'y') employee.isOnHoliday = true;
                else if (OnHoliday == 'N' || OnHoliday == 'n') employee.isOnHoliday = false;
                else System.Console.WriteLine("Invalid option.");
                System.Console.WriteLine("What's the yearly gross salary of this employee? (EUR)");
                employee.salaryGross = Convert.ToInt32(Console.ReadLine());

                json = json + Converting.IntoJSON(employee.id, employee.fullname, employee.sector, employee.salaryGross, employee.isOnHoliday);

                using (StreamWriter write = new StreamWriter(path))
                {
                    write.Write(json);
                }
            }
            System.Console.WriteLine($"File name:\t{fileName}\nData serialized and saved on {path}");
        }
    }
}
