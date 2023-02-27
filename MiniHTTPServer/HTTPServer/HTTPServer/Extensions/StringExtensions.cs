using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPServer.Extensions
{
    public class StringExtensions
    {
        public string Capitalize(String input)
        {
            if (input.Length <= 1)
            {
                return input.ToUpper();
            }
            else
            {
                return char.ToUpper(input[0]) + input.Substring(1);
            }
            return input.ToUpper();
        }
    }
}
