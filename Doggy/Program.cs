using System;
using System.Collections.Generic;

class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Size { get; set; }
    public string Mood { get; set; }
    public string Color { get; set; }

    public Dog(string name, string breed, string size, string mood, string color)
    {
        Name = name;
        Breed = breed;
        Size = size;
        Mood = mood;
        Color = color;
    }

    public void Walk(string place = null)
    {
        if (place != null)
        {
            Console.WriteLine($"{Name} the {Breed} is walking to the {place}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is walking somewhere.");
        }
    }

    public void Bark(string emotion = null)
    {
        if (emotion != null)
        {
            Console.WriteLine($"{Name} the {Breed} is barking {emotion}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is barking.");
        }
    }

    public void Sleep(string timeOfDay = null)
    {
        if (timeOfDay != null)
        {
            Console.WriteLine($"{Name} the {Breed} is sleeping {timeOfDay}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is sleeping.");
        }
    }

    public void Eat(string food = null)
    {
        if (food != null)
        {
            Console.WriteLine($"{Name} the {Breed} is eating {food}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is eating.");
        }
    }

    public void Play(string toy = null)
    {
        if (toy != null)
        {
            Console.WriteLine($"{Name} the {Breed} is playing with the {toy}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is playing.");
        }
    }

    public void Fetch(string item = null)
    {
        if (item != null)
        {
            Console.WriteLine($"{Name} the {Breed} is fetching the {item}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is fetching something.");
        }
    }

    public void Dig(string place = null)
    {
        if (place != null)
        {
            Console.WriteLine($"{Name} the {Breed} is digging in the {place}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is digging.");
        }
    }

    public void Swim(string place = null)
    {
        if (place != null)
        {
            Console.WriteLine($"{Name} the {Breed} is swimming in the {place}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is swimming.");
        }
    }

    public void RollOver()
    {
        Console.WriteLine($"{Name} the {Breed} is rolling over.");
    }

    public void Chase(string target = null)
    {
        if (target != null)
        {
            Console.WriteLine($"{Name} the {Breed} is chasing the {target}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is chasing something.");
        }
    }

    public void Sniff(string obj = null)
    {
        if (obj != null)
        {
            Console.WriteLine($"{Name} the {Breed} is sniffing the {obj}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Breed} is sniffing.");
        }
    }

    public void WagTail()
    {
        Console.WriteLine($"{Name} the {Breed} is wagging its tail.");
    }

    public void Describe()
    {
        Console.WriteLine($"{Name} is a {Size}, {Color} {Breed} and is currently {Mood}.");
    }

    public void RandomlySelectAndExecute()
    {
        Random random = new Random();
        int choice1 = random.Next(1, 13); // Generates a number between 1 and 12
        int choice2;

        do
        {
            choice2 = random.Next(1, 13); // Generates another number between 1 and 12
        } while (choice2 == choice1); // Ensure choice2 is different from choice1

        ExecuteChoice(choice1);
        ExecuteChoice(choice2);
    }

    public void ExecuteChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                Walk();
                break;
            case 2:
                Bark();
                break;
            case 3:
                Sleep();
                break;
            case 4:
                Eat();
                break;
            case 5:
                Play();
                break;
            case 6:
                Fetch();
                break;
            case 7:
                Dig();
                break;
            case 8:
                Swim();
                break;
            case 9:
                RollOver();
                break;
            case 10:
                Chase();
                break;
            case 11:
                Sniff();
                break;
            case 12:
                WagTail();
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        Dog dog1 = new Dog("Debbie", "Labrador", "large", "happy", "golden");
        dog1.Describe();
        dog1.RandomlySelectAndExecute();

        Dog dog2 = new Dog("Butch", "Pitbull", "stout", "angry", "grey");
        dog2.Describe();
        dog2.RandomlySelectAndExecute();
    }
}
