using employee;
using employee.exception;
using EmployeeApp.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmployeeTest
{
    public class ShareHolderTest
    {
        [Fact(DisplayName = "Calculates the final rendiment of shareholder")]
        public void GivenShareHolderInfo_WhenCalculateIncome_ThenReturnsRendimentOfShareholder()
        {
            var shareholder = new ShareHolder(
                "Marcos",
                "12345",
                "6789",
                new DateTime(1982, 04, 20),
                SexEnum.MALE,
                30,
                333333.33);

            double resultExpected = 5000;

            var resultActual = shareholder.CalculateIncome();

            Assert.Equal(resultExpected, resultActual, 0.01);
        }

        [Fact(DisplayName = "Verifies if the object initialize correctly")]
        public void GivenConstructorParameters_WhenCreatingShareHolder_ThenSetsAttributesCorrectly()
        {
            var shareholder = new ShareHolder(
                "Marcos",
                "12345",
                "6789",
                new DateTime(1982, 04, 20),
                SexEnum.MALE,
                30,
                333333.33);

            Assert.Equal("Marcos", shareholder.Name);
            Assert.Equal("12345", shareholder.Rg);
            Assert.Equal("6789", shareholder.Cpf);
            Assert.Equal(new DateTime(1982, 04, 20), shareholder.BirthDate);
            Assert.Equal(30, shareholder.Share);
            Assert.Equal(333333.33, shareholder.StockValue);
        }

        [Fact(DisplayName = "Throws a error when the participation is inferior than zero")]
        public void GivenShareHolderInfo_WhenCalculateIncome_ThenThrowsAError()
        {
            var shareholder = new ShareHolder(
                "Marcos",
                "12345",
                "6789",
                new DateTime(1982, 04, 20),
                SexEnum.MALE,
                0.5,
                333333.33);

            Assert.Throws<InvalidParticipationException>(() => shareholder.CalculateIncome());  
        }
    }
}
