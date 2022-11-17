using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num = 1;
            int num2 = 50;
            int num3 = 6;
            int num4 = 9;
            int num5 = 85;
            int num6= 32;*/

            int[] nums = new int[6];

            nums[0] = 1;
            nums[1] = 50;
            nums[2] = 6;
            nums[3] = 9;
            nums[4] = 85;
            nums[5] = 32;
            
            for(int count = 0; count < 6; count++)
            {
                Console.WriteLine(nums[count]);
            }
           // Console.WriteLine(nums[0]);
            Console.ReadKey();
        }
    }
}