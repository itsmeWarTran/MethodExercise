using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("What is your name?"); //name
            var name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}");


            Console.WriteLine("What is your age?"); //age
            var age = Console.ReadLine();
            Console.WriteLine($"Your age is {age}");


            Console.WriteLine("What is your favorite color?"); //favColor
            var favColor = Console.ReadLine();
            Console.WriteLine($"Your favorite color is {favColor}");


            Console.WriteLine("What is your hobby?"); //hobby
            var hobby = Console.ReadLine();
            Console.WriteLine($"Your hobby is {hobby}");


            Console.WriteLine("What is your favorite acivity?"); //favActivity
            var favActivity = Console.ReadLine();
            Console.WriteLine($"Your favorite acivity is  {favActivity}");

            Console.WriteLine($"My name is {name} and I am {age} years old. My favorite color is {favColor} and I like to {hobby}. One thing I love to do is {favActivity}");


            //Exercise 2
            Console.WriteLine(add(5,6));
            Console.WriteLine(subtract(7, 2));
            Console.WriteLine(multiply(53, 62));
            Console.WriteLine(divide(3342, 234));
            Console.WriteLine(mod(2431, 423));
        }
        public static int add(int num1, int num2) //add
        {
            int result = num1 + num2;
            return result;
        }


        public static int subtract(int num1, int num2) //subtract
        {
            int result = num1 - num2;
            return result;
        }


        public static int multiply(int num1, int num2) //multiply
        {
            int result = num1 * num2;
            return result;
        }


        public static double divide(int num1, int num2) //divide
        {
            double result = num1 / num2;
            return result;
        }


        public static int mod(int num1, int num2) //mod
        {
            int result = num1 % num2;
            return result;
        }
    }
}
