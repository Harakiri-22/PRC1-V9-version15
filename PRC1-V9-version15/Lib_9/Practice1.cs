using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_9
{
    public class Practice1
    {
        public static (int rez, string numb) AddingNumbers()
        {
            Random random = new Random();

            int result = 0;

            string str = string.Empty;

            for (int i = 0; i < 13; i++)
            {
                int currentValue = random.Next(2, 14);
                str += currentValue.ToString() + " ";

                if (currentValue < 8)
                {
                    result += currentValue;
                }
            }
            return (result, str);
        }
    }
}
