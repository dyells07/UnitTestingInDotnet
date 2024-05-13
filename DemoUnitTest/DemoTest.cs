using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest
{
    public class DemoTest
    {
        public int ReturnDemoIfZero(int num)
        {
            if (num == 0)
            {
                return 500;
            }
            else
            {
                return 200;
            }
        }
    }
}
