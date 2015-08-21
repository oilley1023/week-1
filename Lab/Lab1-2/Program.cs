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
            BubbleSortFunction tmp = new BubbleSortFunction();
            int[] XX = tmp.input();
            tmp.process(XX);
            tmp.output(XX);
            Console.ReadLine();
        }
        public int[] input()
        {
           // int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            int tmp;
            Console.WriteLine("Enter the size : ");
            tmp = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[tmp];

            for (int i = 0; i < tmp; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            return number; 
        }
        public void process(int[] input)
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
            
        }
        public void output(int[] input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            
        }

    }
}
