using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility1
{
    public class ConvertType
    {
        public int StringToInt(string inputString)
        {
            int output = 0;
            try
            {
                output = Convert.ToInt32(inputString);
            }
            catch { }
            return output;
        }
    }
}
