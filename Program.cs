int balance = 30;
int cost = 10;
int a = 0;
Console.WriteLine("Добро пожаловать в слоты!");
Console.WriteLine();
Console.WriteLine("1. Играть: Space");
Console.WriteLine("2. Баланс: B");
Console.WriteLine("3. Выход: Esc");

while (a == 0){

    ConsoleKey playButton = Console.ReadKey().Key;

    switch (playButton)
    {
        case ConsoleKey.Spacebar:
            Console.WriteLine();
            break;
        case ConsoleKey.Escape:
            System.Environment.Exit(0);
            break;
        case ConsoleKey.B:
            Console.WriteLine();
            Console.WriteLine("Ваш баланс: " + balance);
            Console.WriteLine();
            ConsoleKey continue1 = Console.ReadKey().Key;
            break;
    }

    Random rnd = new Random();
    int num1 = rnd.Next(1, 10);
    Console.Write(num1 + " ");
    Random rnd2 = new Random();
    int num2 = rnd.Next(1, 10);
    Console.Write(num2 + " ");
    Random rnd3 = new Random();
    int num3 = rnd.Next(1, 10);
    Console.Write(num3 + " ");

    int winnings;
    if (num1 == num2 && num2 == num3)
    {
        winnings = num1 * 8;
        balance = balance + winnings;
        Console.WriteLine("Бинго! Вы выиграли " + winnings + " очков");
        Console.WriteLine("Ваш баланс: " + balance);
        
    }
    else if (num1 == num2 || num2 == num3)
    {
        winnings = num1 * 4;
        balance = balance + winnings;
        Console.WriteLine("Бинго! Вы выиграли " + winnings + " очков");
        Console.WriteLine("Ваш баланс: " + balance);
    }
    else 
    {
        balance = balance - cost;
        if (balance <= 0) { balance = 0; }
        Console.WriteLine("Неудача :( Ваш баланс: " + (balance) + " очков");
        
    }
    if (balance <= 9) {
        Console.WriteLine();
        Console.WriteLine("Вы проиграли! Хотите начать заново?");
        Console.WriteLine();
        Console.WriteLine("Нажмите Space, чтобы начать заново");
        Console.WriteLine("Нажмите Esc, чтобы выйти");
        balance = 30;
    }
}

