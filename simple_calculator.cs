using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_num;
            int second_num;
            char operation;

            Console.WriteLine("�������� �������� (+,-,*,/,^,%): ");
            operation = char.Parse(Console.ReadLine());
            if (operation == '+')
            {
                Console.WriteLine("������� ������ �����: ");
                first_num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("������� ������ �����: ");
                second_num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("���������:" + (first_num + second_num));
                Console.ReadKey();

            }

            else if (operation == '-')
            {
                Console.WriteLine("������� ������ �����: ");
                first_num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("������� ������ �����: ");
                second_num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("���������: " + (first_num - second_num));
                Console.ReadKey();

            }

            else if (operation == '*')
            {
                Console.WriteLine("������� ������ �����: ");
                first_num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("������� ������ �����: ");
                second_num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("���������: " + (first_num * second_num));
                Console.ReadKey();

            }

            else if (operation == '/')
            {
                Console.WriteLine("������� ������ �����: ");
                first_num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("������� ������ �����: ");
                second_num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("���������: " + (first_num / second_num));
                Console.ReadKey();
            }

            else if (operation == "^")
            {
                int num1ques;
               
                Console.WriteLine("������� �����, ���������� � �������: ");
                num1ques = byte.Parse(Console.ReadLine());

                Console.WriteLine("���������: " + (num1ques * num1ques));
                Console.ReadLine();

                Console.ReadKey();

            }

            else if (operation = '%')
            {

                int num2ques;

                Console.WriteLine("������� ������ �����: ");
                num2ques = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("���������: " + (num2ques % num2ques));
                Console.ReadLine();

            }


        }
 
    }
}
