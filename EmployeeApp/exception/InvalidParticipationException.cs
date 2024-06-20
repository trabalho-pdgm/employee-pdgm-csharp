using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee.exception
{
    public class InvalidParticipationException : Exception
    {
        public InvalidParticipationException()
            : base("The participation of shareholder must be minimum 1% and maximum 100%")
        {
        }
    }
}
