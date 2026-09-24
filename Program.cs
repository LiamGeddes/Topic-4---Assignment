namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double salary;
            //Part 1
            Console.Write("Hello. What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + "!");

            Console.Write("How old are you? ");
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("so you're " + age + ", eh? That's not old at all!");

            Console.Write("How much do you make per hour? ");
            double.TryParse(Console.ReadLine(), out salary);

            Console.WriteLine(salary + "! I hope that's per hour and not per year!");

            //Part 2

            string firstName;
            string lastName;
            string login;
            int grade;
            string studentID;
            double average;

            Console.WriteLine("Please enter the following information.");

            Console.Write("First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Last Name:  ");
            lastName = Console.ReadLine();

            Console.Write("Login name: ");
            login = Console.ReadLine();

            Console.Write("Grade (9 - 12): ");
            int.TryParse(Console.ReadLine(),out grade);

            Console.Write("Student ID:");
            studentID = Console.ReadLine();

            Console.Write("Average:");
            double.TryParse(Console.ReadLine(), out average);

            Console.WriteLine("\nYour information: ");
            Console.WriteLine("Login:\t" + login);
            Console.WriteLine("ID:\t" + studentID);
            Console.WriteLine("Name:\t" + lastName + ", " + firstName);
            Console.WriteLine("Average:\t" + average.ToString("F1") + "%");
            Console.WriteLine("Grade:\t" + grade);

            //Part 3
            string name;
            int age;

            Console.Write("Hello. What is your name? ");
            name = Console.ReadLine();

            Console.WriteLine("Hi , " + name + "!");

            Console.Write("How old are you? ");
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("Did you know that in five years you will be " + (age + 5) + " years old?");
            Console.WriteLine("And five years ago you were " + (age - 5) + "! Imagine that!");

            //Part 4
            double number1;
            double number2;
            double number3;

            Console.Write("enter the first number: ");
            double.TryParse(Console.ReadLine(), out number1);

            Console.Write("enter the second number: ");
            double.TryParse(Console.ReadLine(), out number2);

            Console.Write("enter the third number: ");
            double.TryParse(Console.ReadLine(), out number3);

            double total = number1 + number2 + number3;
            double answer = total / 2;

            Console.WriteLine("The total divided by 2 is: " + answer);

            //Part 5
            string item1;
            string item2;
            double price1;
            double price2;

            Console.Write("enter the name of the first item: ");
            item1 = Console.ReadLine();

           




            


        }
    }
}
