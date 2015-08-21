using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            input();

            Console.ReadKey();
        }

        static public void input()
        {
            //int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            Console.WriteLine("Enter size :");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[x];
            for (int i = 0; i < input.Length - 1; i++)
            {
                Console.WriteLine("Enter number :");
                input[i] = Convert.ToInt32(Console.ReadLine());
            }

            process(input);
        }
        static public void process(int[] input)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            output(input);
        }
        static public void output(int[] input)
        {
            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
         }
    

    }
}
