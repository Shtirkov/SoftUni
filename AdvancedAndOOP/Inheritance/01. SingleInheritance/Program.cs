using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Animal secondDog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat kitty = new Cat();
            kitty.Eat();
            kitty.Meow();

        }
    }
}
