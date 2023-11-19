namespace Lab._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle radius1 = new Circle(5);
            Circle radius2 = new Circle(6);

                Console.WriteLine("You can choose a circle with either 5cm, 6cm radius to get the area.");
                Console.WriteLine("1: 5 CM\n2: 6 CM.");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine($"Area: {radius1.GetArea()}");
                    
                }
                if (choice == "2")
                {
                    Console.WriteLine($"Area: {radius2.GetArea()}");
                    
                }

                else { Console.WriteLine("Invalid Input"); }
                
        }
  
    } 
}