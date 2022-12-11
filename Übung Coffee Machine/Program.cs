Console.OutputEncoding = System.Text.Encoding.Default;
Console.Clear();

double money = 0;


Console.ForegroundColor = ConsoleColor.Magenta; ;
Console.WriteLine("How much money do you have?");
money = double.Parse(Console.ReadLine()!);
if (money < 1.5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Sorry, you have not enough money.");
    return;
}

while (money >= 1.5)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Which product do you want to buy?");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1) Cappuccino☕ (3.5€), 2) Tea🍵 (1.5€), 3) Cacao🍫☕ (2.5€), 4) Nothing else❌");
    int drink = int.Parse(Console.ReadLine()!);

    if (drink == 1) { money -= 3.5; }
    else if (drink == 2) { money -= 1.5; }
    else if (drink == 3) { money -= 2.5; }
    else if (drink == 4)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"You get back {money}€.");
        Console.ReadKey();
        Console.Clear();
        return;
    }
    if (money < 1.5)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You can't buy more, you have not enough money left.");
        return;
    }
}