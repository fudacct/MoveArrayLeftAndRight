using System;
using System.Collections;

namespace Int_ArrayMoveLiftOrRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] sourceArray = new int[10];
            int[] resultArray = new int[10];
            string readValue = "0";
            int moveCount = 0;
            Console.WriteLine("原数组：");
            for (int i = 1; i <= 10; i++)
            {
                sourceArray[i - 1] = i;
                Console.Write(i + ";");
            }
            while (Console.ReadLine() != null)
            {
                readValue = Console.ReadLine();
                //移位的数量
                int.TryParse(readValue, out moveCount);
                moveCount = moveCount % sourceArray.Length;
                //负数从左向右移，整数从右向左移。
                //负数移动的位数，相当于数组长度加上实际右移位数。
                if (moveCount < 0)
                {
                    moveCount = sourceArray.Length + moveCount;
                }
                //移位
                for (int i = 0; i < sourceArray.Length; i++)
                {
                    if (i >= moveCount)
                    {
                        resultArray[i - moveCount] = sourceArray[i];
                    }
                    else
                    {
                        resultArray[i - moveCount + sourceArray.Length] = sourceArray[i];
                    }
                }
                //输出结果
                Console.WriteLine("结果数组：");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ";");
                }
            }
            
        }
    }
}
