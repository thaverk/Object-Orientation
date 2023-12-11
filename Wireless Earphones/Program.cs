namespace Wireless_Earphones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buds earphones = new Buds(true,true,"Samsung","Red");

           Console.WriteLine($"Welcome to {earphones.brand} Digital Well-Being Statiscs: ");
            Console.WriteLine($"Power: {earphones.powerON}");
            Console.WriteLine($"Bluetooth: {earphones.bluetooth}");
            Console.WriteLine($"The colour of your phone is: {earphones.colour}");
            
  
        }
    }
}
