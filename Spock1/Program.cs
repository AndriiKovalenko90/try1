// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



static void HW1()
{   
    //-------------------------First
    //Console.WriteLine("Hello, what is your name?");
    //string name = Console.ReadLine();
    //Console.WriteLine($"Your name is {name}");

    //-------------------------Second
    //Console.WriteLine($"Enter two integer numbers");
    //int x = int.Parse(Console.ReadLine());
    //int y = int.Parse(Console.ReadLine());
    //Console.WriteLine($"x = {x}, y = {y}");

    //-------------------------Third
    //int temp;
    //temp = y;
    //y = x;
    //x = temp;
    //Console.WriteLine($"x = {x}, y = {y}");

    //-------------------------Fourth
    //Console.WriteLine("Enter the integer number");
    //int number = int.Parse(Console.ReadLine());
    //Console.WriteLine($"The number of digits: {number.ToString().Length}");

    //-------------------------Fifth
    string firstName;
    string lastName;
    int age;
    double weight;
    double height;
    double bMI;

    Console.WriteLine("What is your name?");
    firstName = Console.ReadLine();
    Console.WriteLine("What is your last name?");
    lastName = Console.ReadLine();
    Console.WriteLine("How old are you?");
    age = int.Parse(Console.ReadLine());
    Console.WriteLine("Provide your weight in kg:");
    weight = double.Parse(Console.ReadLine());
    Console.WriteLine("Provide your height in m");
    height = double.Parse(Console.ReadLine());
    bMI = weight / (height * height);
    string profile = 
        $"Your profile:{Environment.NewLine}" +
        $"Full Name:{lastName} {firstName}{Environment.NewLine}" +
        $"Age: {age}{Environment.NewLine}" +
        $"Weight: {weight}{Environment.NewLine}" +
        $"Height: {height}{Environment.NewLine}" +
        $"Body Mass Index: {bMI}";

    Console.WriteLine(profile);

}

static void DTime()
{
    DateTime now = DateTime.Now;
    Console.WriteLine(now.ToString());
    Console.WriteLine($"It's {now.Day} of {now.Month} month, {now.DayOfWeek}, {now.Hour}:{now.Minute}");

    DateTime dt = new DateTime(2016, 2, 28);
    Console.WriteLine(dt);
    DateTime dt2 = dt.AddDays(1);
    Console.WriteLine(dt2);

    Console.WriteLine(dt2.Subtract(dt));


    TimeSpan ts = now - dt2;
    Console.WriteLine(ts.TotalDays);
}