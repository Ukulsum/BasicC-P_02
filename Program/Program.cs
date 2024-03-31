using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        /*------------------------ Ans to the Ques no 03 ------------------------*/
        static void addSum(int n1,  int n2, int n3 = 3)//Create method using parameter, optional parameter
        {
            Console.WriteLine("number 1 + number 2 = " + n1 + n2);
        }
        /*------------------------ Ans to the Ques no 06 ------------------------*/
        public enum Student
        {
            Id, Name, Roll, Subject, Semester
        }
        /*------------------------ Ans to the Ques no 07 ------------------------*/
        public struct examinfo
        {
            public string Title;
            public string Roll;
            public string Subject;
            public string Marks;
        }
        static void Main(string[] args)
        {
            /*------------------------ Ans to the Ques no 01 ------------------------*/
            /*----------- Iteration Statemants (If......Else) -----------*/
            Console.WriteLine("Enter your 1st Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("This number is Even Number : ");
            }
            else
            {
                Console.WriteLine("This number is Odd Number : ");
            }
            /*-------------- Switch Case -----------*/
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 2:
                    Console.WriteLine("Today is Sunday.");
                    break;
                case 3:
                    Console.WriteLine("Today is Monday.");
                    break;
                case 4:
                    Console.WriteLine("Today is Tuesday.");
                    break;
                case 5:
                    Console.WriteLine("Today is Wednesday.");
                    break;
                case 6:
                    Console.WriteLine("Today is Thursday.");
                    break;
                default:
                    Console.WriteLine("Today is Friday");
                    break;
            }
            /*-------------------- While loop ------------*/
            int n = 0;
            while (n <= 25)
            {
                Console.WriteLine(n);
                n++;
            }
            /*-------------------- for loop ------------*/
            for(int i = 0; i<= 10; i++)
            {
                Console.WriteLine(i);
            }
            /*-------------------- do while loop ------------*/
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 10);
            /*-------------------- forEach loop ------------*/
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }
            /*------------------------ Ans to the Ques no 02 ------------------------*/
            int num2 = 20; //Declaring, naming & assigning variable using primitive data types
            int num3 = 30;
            int result;
            result = num3 + num2; //arithmetic Operator
            Console.WriteLine("Addition Number : " + result);
            result = num3 - num2; //arithmetic Operator
            Console.WriteLine("substraction Number : " + result);
            result = num3 * num2; //arithmetic Operator
            Console.WriteLine("Multiplication Number : " + result);
            result = num3 / num2; //arithmetic Operator
            Console.WriteLine("Division Number : " + result);
            result = num3 % num2; //arithmetic Operator
            Console.WriteLine("Modulo Number : " + result);
            /* difference of Prefix and Postfix*/
            int m = 10;
            Console.WriteLine(m);
            Console.WriteLine(m++);//Postfix
            Console.WriteLine(m);
            Console.WriteLine(m--);
            Console.WriteLine(m);
            Console.WriteLine(--m);//Prefix
            Console.WriteLine(m);
            Console.WriteLine(++m);

            /*------------------------ Ans to the Ques no 03 ------------------------*/
            { }//Scope
            addSum(n1: 12, n2: 20);//calling method using named arguments

            /*------------------------ Ans to the Ques no 04 ------------------------*/
            /*------------- Try - Catch - Finally -----------------*/
            int div = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured");
            }
            finally
            {
                Console.WriteLine("finally block");
            }
            Student ostu = Student.Name;
            Console.WriteLine(ostu);
            examinfo exam;
            exam.Title = "HR";
            exam.Roll = "120";
            exam.Marks = "56";
            exam.Subject = "English";

            Console.ReadLine();
        }
    }
}
