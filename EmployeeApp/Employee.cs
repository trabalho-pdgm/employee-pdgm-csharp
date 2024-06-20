using EmployeeApp.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    public class Employee : Person
    {
        private const double SalaryComparison1 = 4664.68;
        private const double SalaryComparison2 = 3751.06;
        private const double SalaryComparison3 = 2826.66;
        private const double SalaryComparison4 = 2259.21;

        private const double IrFee1 = 0.275;
        private const double IrFee2 = 0.225;
        private const double IrFee3 = 0.15;
        private const double IrFee4 = 0.075;

        private const double IrDeduction1 = 869.36;
        private const double IrDeduction2 = 636.13;
        private const double IrDeduction3 = 354.80;
        private const double IrDeduction4 = 142.80;

        private const double InssRate = 0.11;

        public double Salary { get; }
        public String Pis { get; }
        public String Ctps { get; }

        public Employee(String name, String rg, String cpf, DateTime birthDate, SexEnum sex,
            double salary, string pis, string ctps) : base(name, rg, cpf, birthDate, sex)
        {
            Salary = salary;
            Pis = pis;
            Ctps = ctps;

        }

        public override double CalculateIncome()
        {
            double inssDiscount = Salary * InssRate;
            return Salary - GetDiscount() - inssDiscount;
        }

        private double GetDiscount()
        {
            double discount = 0;

            if (Salary > SalaryComparison1)
            {
                discount = (Salary * IrFee1) - IrDeduction1;
            }
            else if (Salary >= SalaryComparison2)
            {
                discount = (Salary * IrFee2) - IrDeduction2;
            }
            else if (Salary >= SalaryComparison3)
            {
                discount = (Salary * IrFee3) - IrDeduction3;
            }
            else if (Salary >= SalaryComparison4)
            {
                discount = (Salary * IrFee4) - IrDeduction4;
            }
            else
            {
                discount = 0;
            }
            return discount;
        }
    }
}
