using System;

namespace BasicClass
{
    class Cat
    {
        public string name;
        public string color;

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }
    }

    class MainApp
    { 
        static void Main(string[] args)
        {
        Cat Kitty = new Cat();
        Kitty.color = "하얀색";
        Kitty.name = "키티";
        Kitty.Meow();
        Console.WriteLine($"{Kitty.name} : {Kitty.color}");

        Cat nero = new Cat();
        nero.color = "검은색";
        nero.name = "네로";
        nero.Meow();
        Console.WriteLine($"{nero.name} : {nero.color}");
        }
    }
}
