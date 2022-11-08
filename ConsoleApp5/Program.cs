﻿using ConsoleApp5;
 
try
{
    Console.WriteLine("Введите имя нового героя");
    string heroName = Console.ReadLine();
    Console.WriteLine("Введите хп нового героя");
    double heroHp = double.Parse(Console.ReadLine());
    Hero Vasya = new Hero(heroName, heroHp);
    if (heroName == "Vasya" && heroHp<=100)
    {
        Console.WriteLine($"Имя созданного героя - {heroName} и {heroHp}");
    }
    else
    {
        throw new Exception("Wrong name and hp");
    }
    Console.WriteLine("Введите имя нового дракона");
    string dragonName = Console.ReadLine();
    Console.WriteLine("Введите хп нового дракона");
    double dragonHp = double.Parse(Console.ReadLine());
    if(dragonName == "Smaug" && dragonHp <= 300)
    {
        Console.WriteLine($"Имя созданного героя {dragonName} здоровье {dragonHp}");

    }
    else
    {
        throw new Exception("Имя дракона должно быть Смауг, и хп должно быть не меньше 300");

    }
    //Hero Vasya = new Hero("Vasya", 100);
    //Dragon Smaug = new Dragon("Smaug", 500);
    Dragon Smaug = new Dragon(dragonName, dragonHp);
    double firstAttack = Vasya.Bite(Smaug);
    Smaug.TakeDamage(firstAttack);
    Console.WriteLine("Smaug breathes fire...");
    double secondAttack = Smaug.Incinirate(Vasya);
    Vasya.TakeDamage(secondAttack);
    Vasya.Heal();
}
catch (Exception ex)
{
    Console.WriteLine("Ошибка:" + ex.Message);
}
