using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firsttask
{
    // firsttask task4
    abstract class Shape
    {
        private double x;
        private double y;
        public double X
        {
          get { return x; } set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public abstract void Draw();
    }
    class Circle : Shape
    {
        public override void  Draw()
        {
            Console.WriteLine($"Draw Circle x Value is {X}");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Draw Rectangle X Value is {X} Y Value is {Y}");
        }
    }
    // generic task1 from pdf task1
    public class GenericClass
    {
        public double avg = 0;
        public double gradesTotal = 0;
        public int counterAboveAvg = 0;
        public int counterBelowAvg = 0;
        public int counter = 0;
        public double squareRt = 0;
        List<double> gradeList = new List<double>();
        public void GenericMethod<DataType>(DataType value)
        {
            try
            {
                if (System.Convert.ToDouble(value) >= 0  ) 
                {
                    gradeList.Add(System.Convert.ToDouble(value));
                    counter += 1;
                    gradesTotal += System.Convert.ToDouble(value);
                    avg = gradesTotal  / counter ;
                    
                } 
            }
            catch (Exception ex) 
            { 
              Console.Write($"error exception {ex.ToString()}");
              Console.WriteLine();
            }

        }
        public void getMaxGrade() {
            foreach (double grade in gradeList) 
            {
                if(grade > avg)
                {
                    counterAboveAvg += 1;
                }else if (grade < avg)
                {
                    counterBelowAvg += 1;   
                }
            }

        }
        
        public void RealNumberSquareRoot<DataType>(DataType value)
        {
            try
            {
                if (System.Convert.ToDouble(value) >= 0)
                {
                    Console.WriteLine($"Square Root of {System.Convert.ToDouble(value)} Value is {Math.Sqrt((System.Convert.ToDouble(value)))}");
                    

                }
            }
            catch (Exception ex)
            {
                Console.Write($"error exception {ex.ToString()}");
                Console.WriteLine();
            }
        }

    }
    //public class GenericList<T>
    //{
       // public void Add(T item) { }
   // }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            startover:
            Console.Clear();
            DisplayTasks();
            //Console.WriteLine();
            Begin:
            Console.WriteLine("Enter Task Number:");
            string input = Console.ReadLine();
            if ( int.TryParse(input, out int taskNo))
            {
              goto switchCase;
            }
            else
            {
                Console.WriteLine("Error Select Integer Value (1,5):");
                goto Begin;
            }

            switchCase:

            switch (taskNo)
            {
                case 1:
                    // firsttask task1
                    Task1();
                    PressKey();
                    goto startover;
                    
                case 2:
                    // firsttask task2
                    MultiplicationValues();
                    PressKey();
                    goto startover;
                    
                case 3:
                    // firsttask task3 Arrayofnames
                    string[] names = { "mohammad", "adam", "amir", "Sayeed", "RamZi", "ali" };
                    PrintArrayDefaultValues(names);
                    UpperCaseArray(names);
                    ReversArray(names);
                    PressKey();
                    goto startover;
                case 4:
                    // firsttask task44
                    Circle myshape = new Circle();
                    myshape.X = 10;
                    myshape.Draw();

                    Rectangle myrect = new Rectangle();
                    myrect.X = 12;
                    myrect.Y = 13;
                    myrect.Draw();
                    PressKey();
                    goto startover;
                case 5:
                    // task1.pdf
                      GenericClass grades = new GenericClass();
                    grades.GenericMethod(80);
                    grades.GenericMethod(90.00);
                    grades.GenericMethod(80.5);
                    grades.GenericMethod("ahmad");
                    grades.GenericMethod(85);
                    
                    Console.WriteLine($"grades total {grades.gradesTotal, -7}");
                    Console.WriteLine($"subjects {grades.counter,-7}"); 
                    Console.WriteLine($"Average {grades.avg,-7}");
                    grades.getMaxGrade();
                    Console.WriteLine("_____________________") ;
                    Console.WriteLine($"{grades.counterAboveAvg} Found Above Averag");
                    Console.WriteLine($"{grades.counterBelowAvg} Found Below Averag");
                    Console.WriteLine();
                    Console.WriteLine("_________Real Number Square Root________");
                    grades.RealNumberSquareRoot(25.88888f);
                    grades.RealNumberSquareRoot(25);
                    grades.RealNumberSquareRoot(true);
                    grades.RealNumberSquareRoot("true");

                    PressKey();
                    goto startover;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid Value Entered");
                    goto Begin;



            }
            
            
            
        }
        static void MultiplicationValues()
        {
            EnterValue1:
            Console.WriteLine("Enter integer Value1 To get Multiplication Table:");
            string input = Console.ReadLine();
            if ( int.TryParse(input, out int firstValue))
            {
                goto EnterValue2;
            }
            else
            {
                Console.WriteLine("Error Invalid Value ReEnter Value");
                goto EnterValue1;
            }
        EnterValue2:
            Console.WriteLine("Enter integer Value2 To get Multiplication Table of 2 Values:");
            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out int secondValue))
            {
                goto endfunc;
            }
            else
            {
                Console.WriteLine("Error Invalid Value ReEnter Second Value");
                goto EnterValue2;
            }

            endfunc:
            Multiplication(firstValue);
            Multiplication(firstValue, secondValue);
            
        }

        static void DisplayTasks()
        {
            Console.WriteLine($"1 Firsttask.pdf task1");
            Console.WriteLine($"2 Firsttask.pdf Task2");
            Console.WriteLine($"3 Firsttask.pdf Task3");
            Console.WriteLine($"4 Firsttask.pdf Task4");
            Console.WriteLine($"5 Firsttask.pdf Generics Task");
            Console.WriteLine($"6 Exit");
        }
        static void Task1()
        {
            begenfunc:
            Console.WriteLine("How Old Are You?");
            string input = Console.ReadLine();
            int? age = null;
            if (int.TryParse(input, out int parseAge)) 
            { 
                age = parseAge;
                
            }
            else 
            { 
                Console.WriteLine("You enter Invalid Value");
                goto begenfunc;
            }
            if (age > 17)
            { Console.WriteLine(" Hello You Can vote "); }
            else
            { 
                Console.WriteLine("Hello You are under age you cant vote");
                
            }
         
        }
        static void  Multiplication(int x)
        {
            Console.WriteLine();
            Console.WriteLine($"Multiplication table {x} time 1 to 12");
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{x,-4} x {i,-4} = {x*i,-4}");
            }
        }
        static void Multiplication(int x, int y)
        {
            Console.WriteLine();
            Console.WriteLine($"Multiplication table {x} time 1 to {y}");
            for (int i = 1; i <= y; i++)
            {
                Console.WriteLine($"{x,-4} x {i,-4} = {x * i,-4}");
            }
        }

        static void PrintArrayDefaultValues(string[] names) 
        {
            
            Console.WriteLine();
            Console.WriteLine("Deafult array Values:");
            Console.WriteLine();
            foreach (string name in names) {
                Console.WriteLine($"{name,-2}");
            }


        }
        static void UpperCaseArray(string[] names)
        {
            Console.WriteLine();
            Console.WriteLine("Change array Values ToUpper Case:");
            Console.WriteLine();
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToUpper();
                Console.WriteLine($"{names[i],-2}");
                
            }
        }
        static void ReversArray(string[] names)
        {
            Console.WriteLine();
            Console.WriteLine("Array Reversed:");
            Console.WriteLine();
            Array.Reverse(names);
            foreach (string name in names)
            {
                Console.WriteLine($"{name,-2}");
            }
        }
        static void PressKey()
        {
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
