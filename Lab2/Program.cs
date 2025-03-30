namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        
        int myInt = 25;
        double myDouble = 3.14159;
        float myFloat = 5.75F;
        char myChar = 'A';
        bool myBool = true;
        string myString = "this program was written in C#";

        Console.WriteLine("int: " + myInt);
        Console.WriteLine("double: " + myDouble);
        Console.WriteLine("float: " + myFloat);
        Console.WriteLine("char: " + myChar);
        Console.WriteLine("bool: " + myBool);
        Console.WriteLine("string: " + myString);

        
        double doubleValue = 9.78;
        int intValue = (int)doubleValue;
        Console.WriteLine("explicitly casted int: " + intValue);

        int number = 100;
        bool boolValue = false;
        string stringFromInt = Convert.ToString(number);
        string stringFromBool = Convert.ToString(boolValue);
        Console.WriteLine("converted int to string: " + stringFromInt);
        Console.WriteLine("converted bool to string: " + stringFromBool);

        
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello " + userName + ", you are " + userAge + " years old.");

        
        int num1 = 8;
        int num2 = 4;

        Console.WriteLine("addition (num1 + 10): " + (num1 + 10));
        Console.WriteLine("subtraction (num1 - 2): " + (num1 - 2));
        Console.WriteLine("multiplication (num1 * 3): " + (num1 * 3));
        Console.WriteLine("division (num1 / 2): " + (num1 / 2));
        Console.WriteLine("modulus (num1 % 2): " + (num1 % 2));

        Console.WriteLine("                          ");
         
        Console.WriteLine("addition (num2 + 10): " + (num2 + 10));
        Console.WriteLine("subtraction (num2 - 2): " + (num2 - 2));
        Console.WriteLine("multiplication (num2 * 3): " + (num2 * 3));
        Console.WriteLine("division (num2 / 2): " + (num2 / 2));
        Console.WriteLine("modulus (num2 % 2): " + (num2 % 2));

        Console.WriteLine(" ");
        
        float floatNum = 1.123456789f;
        double doubleNum = 1.123456789;

        Console.WriteLine("float value: " + floatNum);
        Console.WriteLine("double value: " + doubleNum);

       
        int counter = 10;
        counter++;
        Console.WriteLine("after increment: " + counter);
        counter--;
        Console.WriteLine("after decrement: " + counter); 

    }}