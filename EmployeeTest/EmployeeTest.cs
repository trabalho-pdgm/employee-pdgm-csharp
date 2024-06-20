using EmployeeApp.enums;
using employee;

namespace EmployeeTest
{
    public class EmployeeTest
    {
        [Fact(DisplayName = "Calculates the final salary of employee")]
        public void GivenEmployeeInfo_WhenCalculateIncome_ThenReturnsFinalSalary()
        {
            var employee = new Employee(
                "João", 
                "12345",
                "6789",
                new DateTime(1982, 04, 20),
                SexEnum.MALE,
                2500,
                "555",
                "666");

            var resultExpected = 2180.30;

            var resultActual = employee.CalculateIncome();

            Assert.Equal(resultExpected, resultActual);
        }

        [Fact(DisplayName = "Verifies if the object initialize correctly")]
        public void GivenConstructorParameters_WhenCreatingEmployee_ThenSetsAttributesCorrectly()
        {
            var employee = new Employee("João", "12345", "6789",
                new DateTime(1982, 04, 20), SexEnum.MALE, 2500, "555", "666");

            Assert.Equal("João", employee.Name);
            Assert.Equal("12345", employee.Rg);
            Assert.Equal("6789", employee.Cpf);
            Assert.Equal(new DateTime(1982, 04, 20), employee.BirthDate);
            Assert.Equal(SexEnum.MALE, employee.Sex);
            Assert.Equal(2500, employee.Salary);
            Assert.Equal("555", employee.Pis);
            Assert.Equal("666", employee.Ctps);
        }
    }
}