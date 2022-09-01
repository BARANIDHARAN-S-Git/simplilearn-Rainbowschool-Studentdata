using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sl_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentdetails = @"C:\Users\brother\Desktop\SimpliLearn\Project-1\DetailofStudent.txt";




            if (File.Exists(studentdetails))
            {

                string details = File.ReadAllText(studentdetails);
                Console.WriteLine(details);
            }

            else
            {
                Console.WriteLine("Error accours chech the path of document or check the condition,Thank You");
            }
            Console.ReadLine();

        }
    }
}
