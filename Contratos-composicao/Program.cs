using System;
using Contratos_composicao.Entities;
using Contratos_composicao.Entities.Enums;

namespace Contratos_composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            Console.Write("Enter department's name: ");
            worker.Department = new Department(Console.ReadLine());
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            worker.Name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            worker.Level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Base salary: ");
            worker.BaseSalary = Double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker? ");
            int numberOfContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfContracts; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateOfContract = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                Double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int durationInHours = int.Parse(Console.ReadLine());
                worker.AddContract(new HourContract(dateOfContract, valuePerHour, durationInHours));
            }
            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            DateTime dateTimeIncome = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine($"Name: {worker.Name}\nDepartment: {worker.Department.Name}\n{worker.Income(dateTimeIncome.Year, dateTimeIncome.Month)}");
        }
    }
}
