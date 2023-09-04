using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_task
{
    internal class Program
    {
      
        static void Main(string[] args)
        {

            int[] nums = { 1, 55, 51 , 878 };
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(10 * nums[i]);
            }
        }
    }
}
