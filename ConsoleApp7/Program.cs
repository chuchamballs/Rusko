// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hackovaní Ruska");
for(int i = 0; i <= 100; i = i+20)
{
    Console.WriteLine("Postup " + i + "%");
    Thread.Sleep(1000);
}
Console.WriteLine("Rusko úspěšně hacknuto :)");