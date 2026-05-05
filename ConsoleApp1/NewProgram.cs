using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class NewProgram
    {
        public NewProgram()
        {
            Console.WriteLine("Be yourself");
            reverse("GadaG");
        }


        void reverse(string input)
        {
            string value = input;
            char[] cha = value.ToCharArray();
            char[] reverse = new char[cha.Length];
            int max = cha.Length - 1;
            for (int i = 0; i < cha.Length; i++)
            {
                reverse[max] = cha[i];
                max--;
            }

            Console.WriteLine(new string(reverse));   

        }


    }
}
