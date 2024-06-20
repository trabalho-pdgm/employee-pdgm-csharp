using EmployeeApp.enums;
using System;

namespace employee
{
    public abstract class Person
    {
        public String Name { get; }
        public String Rg { get; }
        public String Cpf { get; }
        public DateTime BirthDate { get; }
        public SexEnum Sex { get; }

        public Person(String name, String rg, String cpf, DateTime birthDate, SexEnum sex)
        {
            Name = name;
            Rg = rg;
            Cpf = cpf;
            BirthDate = birthDate;
            Sex = sex;
        }

        public abstract double CalculateIncome();
    }
}
