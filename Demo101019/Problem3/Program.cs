using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region region 1
            for(int printerPrintsCondition = 0; printerPrintsCondition <= 1; printerPrintsCondition++)
            {
                // cond2 = red light is flashing
                for(int cond2 = 0; cond2 <= 1; cond2++)
                {
                    for(int bananasCondition = 0; bananasCondition <= 1; bananasCondition++)
                    {
                        if(printerPrintsCondition == 0 && cond2 == 0 && bananasCondition == 0) 
                        {
                            // call action methods
                            Console.WriteLine("Print prints condition: NO");
                            // call action methods
                        }
                        if(printerPrintsCondition == 0 && cond2 == 0 && bananasCondition == 1)
                        {
                            // call action methods
                            // printer jam
                        }
                    }
                }
            }
            #endregion

            #region region 2
            for (int i =0; i <= 7; i++)
            {
                switch (i)
                {
                    case 0:
                        // print out conditions
                        // call action methods for NO, NO, NO
                        break;
                    case 1:
                        //print our conditions
                        // call action methods for No, No, Yes
                        break;
                }
            }
            #endregion
        }

        // Create the Methods

        public void CheckInk()
        {
            Console.WriteLine("Check ink and replace if empty.");
        }
        public void PowerCable()
        {
            Console.WriteLine("Check the power cable connection.");
        }
    }
}
