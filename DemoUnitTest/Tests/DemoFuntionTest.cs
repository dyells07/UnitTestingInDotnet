using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest.Tests
{
    public static class DemoFuntionTest
    {
        public  static void DemoTest_ReturnDemoIfZero_ReturnString()
        {
            try
            {
                //Arrange - Go get your variables
                int num = 1;
                DemoTest demoTest = new DemoTest();

                //Act - executute the fuction
                int result = demoTest.ReturnDemoIfZero(num);

                //Assert - Whatever is returned is it what you want 
                if (result == 200)
                {
                    Console.WriteLine("Passed : DemoTest_ReturnDemoIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed : DemoTest_ReturnDemoIfZero_ReturnString");
                }

            }
            catch(Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
