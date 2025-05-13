
Random rand = new Random();
var randomNumber = rand.Next(0, 3);

if (randomNumber == 0)
{
    Console.WriteLine("Tallet ble 0");
}
else if (randomNumber == 1)
{
    Console.WriteLine("Tallet ble 1");
}
else
{
    Console.WriteLine("Tallet ble 2");
}