// See https://aka.ms/new-console-template for more information
namespace ahmadWhileLoop;
class Program
{
    static void Main(string[] args)
    {
        int index = 1;
        while (index <= 5)
        {
            Console.WriteLine(index);
            index++;
        }


        //Do While Loop First execute the code in the loop before checking the condition
        //Do While loop = opposit of While Loop

        int age = 6;
        do
        {
            Console.WriteLine(age);
            age++;
        }
        while (age <=12 || age ==10);   
        
    }
}

