using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Class
    {
        public int Argument(int a, int b)
        {
            int c;
            // Handle null argument.
            if (b == null & a == null)
            {
                throw new ArgumentNullException("параметры не заданы");
            }
            // Handle invalid argument.
            if (b == 0)
            {
                throw new ArgumentException("нельзя делить на 0");
            }
            return c = a / b;
        }
    }
}