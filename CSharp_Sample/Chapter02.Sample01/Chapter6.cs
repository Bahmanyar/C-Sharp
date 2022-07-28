using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02.Sample01
{
    public class Chapter6
    {
        public string Test_Test(int input)
        {
            var result = input == 0 ? "Zero" : "NotZero";
            checked
            {
                byte b = byte.MaxValue;
                Console.WriteLine(b);
                b += 2;
                Console.WriteLine(b);
            }
            return result;
        }
        public void TestChecked()
        {
            //uncomment & do this

            //byte b = byte.MaxValue;
            //Console.WriteLine(b);
            //b += 2;
            //Console.WriteLine(b);

            #region [- Checked block -]
            //checked
            //{
            //    byte b = byte.MaxValue;
            //    Console.WriteLine(b);
            //    b += 2;
            //    Console.WriteLine(b);
            //} 
            #endregion


            #region [- Check part of the code -]
            byte b = byte.MaxValue;
            Console.WriteLine(b);
            b = checked(b++);
            Console.WriteLine(b); 
            #endregion



            
        }

        public void Show()
        {
            Console.WriteLine(nameof(Test_Test));
        }
    }
}
