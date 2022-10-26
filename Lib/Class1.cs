using System;
using static System.Console;

namespace Lib;

public class Game
{
    ///<summary>
    ///Выводит главное меню в консоль
    ///<summary>
    Hero H1;
    public Game()
    {
        Clear();
        Write("Введите ваше имя: ");
        string name = ReadLine();
        this.H1 = new Hero(name);
    }
    
    public void PrintMainMenu()
    {
        try
        {
            WriteLine(this.H1.ToString());
            WriteLine("1 Бой");
            WriteLine("2 Лавка");
            WriteLine("3 Выход");
            Write("Введите ваш выбор: ");
            string answer = ReadLine();
            switch (int.Parse(answer))
            {
                case 1:
                    Clear();
                    break;
                case 2:
                    Clear();
                    PrintShopMenu();
                    break;
                case 3:
                    return;
                default:
                    WriteLine();
                    WriteLine("Не понимаю ваш запрос");
                    this.PrintMainMenu();
                    break;
            }
        }
        catch
        {

        }
    }
    public void PrintShopMenu()

    {
        try
        {
            WriteLine("1 Купить зелья");
            WriteLine("2 Купить оружие");
            WriteLine("3 Назад");
            Write("Введите ваш выбор: ");
            string answer = ReadLine();
            if (int.Parse(answer) == 1)
            {
                Clear();

            }
            if (int.Parse(answer) == 2)
            {
                Clear();

            }
            if (int.Parse(answer) == 3)
            {
                Clear();
                this.PrintMainMenu();
            };
        }
        catch
        {
            WriteLine();
            WriteLine("Не понимаю ваш запрос");
            this.PrintMainMenu();
        }
    }


}



public class Hero
{
    string name;
    int hp;
    int op;
    public Hero(string heroName)
    {
        this.name = heroName;
        this.hp = 100;
        this.op = 100;
    }

    public Hero(Hero enemy)
    {
        this.name = "Enemy";
        this.hp = enemy.hp + 100;
        this.op = enemy.hp + 100;
    }

    public override string ToString()
    {
        return ($"Name {this.name} HP {this.hp} OP {this.op} ");
    }
}