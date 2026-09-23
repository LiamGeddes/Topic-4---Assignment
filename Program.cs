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
            name=Console.ReadLine();

            Console.WriteLine("Hi, " + name + "!");

            Console.Write("How old are you? ");
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("so you're " + age + ", eh? That's not old at all!");

            Console.Write("How much do you make per hour? ");
            double.TryParse(Console.ReadLine(), out salary);

            Console.WriteLine(salary + "! I hope that's per hour and not per year!");

            //Part 2
            


        }
    }
}
