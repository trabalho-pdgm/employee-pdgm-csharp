using employee.exception;
using EmployeeApp.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    public class ShareHolder : Person
    {

        private const double ParticipationThreshold1 = 25.0;
        private const double ParticipationThreshold2 = 50.0;
        private const double ParticipationRate1 = 0.01;
        private const double ParticipationRate2 = 0.05;
        private const double ParticipationRate3 = 0.10;
        private const double MinimumParticipation = 1;
        private const double MaximumParticipation = 100.0;

        public double Share { get; }
        public double StockValue { get; }

        public ShareHolder(string name, string rg, string cpf,
            DateTime birthDate, SexEnum sex, double share
            , double stockValue) : base(name, rg, cpf, birthDate, sex)
        {
            Share = share;
            StockValue = stockValue;
        }

        public override double CalculateIncome()
        {
            double capital = StockValue * (Share / 100);
            double total = 0;

            ValidateParticipation();

            if (Share <= ParticipationThreshold1)
            {
                total = capital * ParticipationRate1;
            }
            else if (Share <= ParticipationThreshold2)
            {
                total = capital * ParticipationRate2;
            }
            else
            {
                total = capital * ParticipationRate3;
            }

            return total;
        }

        private void ValidateParticipation()
        {
            if (Share < MinimumParticipation || Share > MaximumParticipation)
            {
                throw new InvalidParticipationException();
            }
        }
    }
}
