﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codility Clark Test Started..");
            int[] array = {5,2,6,8,1,7 };
            int aliceTree = 3;
            int bobtrees = 2;
            int result = Solution.solution(array,aliceTree,bobtrees);
            Console.WriteLine("Maximum Apples can be collected :" + result);
            Console.ReadLine();
        }
    }
}
