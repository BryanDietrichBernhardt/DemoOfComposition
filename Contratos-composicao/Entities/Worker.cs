using System;
using System.Collections.Generic;
using Contratos_composicao.Entities.Enums;

namespace Contratos_composicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //Instanciar para garantir que não será nula

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public string Income(int year, int mouth)
        {
            Double totalIncome = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mouth)
                {
                    totalIncome += contract.TotalValue();
                }
            }
            return $"Income for {mouth}/{year}: {totalIncome.ToString("F2")}";
        }
    }
}
