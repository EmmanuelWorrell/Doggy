using System;
using System.Collections.Generic;

class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Size { get; set; }
    public string Mood { get; set; }
    public string Color { get; set; }

    public Dog(string name, string breed, string size, string color)
    {
        Name = name;
        Breed = breed;
        Size = size;
        Mood = GetDynamicMood(); // Set mood using DynamicMoodChange
        Color = color;
    }

    public void Walk(string place = null)
    {
        if (place == null)
        {
            place = GetDynamicPlace();
        }
        Console.WriteLine($"{Name} the {Breed} is walking to the {place}.");
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
        if (food == null)
        {
            food = GetDynamicFood();
        }
        Console.WriteLine($"{Name} the {Breed} is eating {food}.");
    }

    public void Play(string toy = null)
    {
        if (toy == null)
        {
            toy = GetDynamicToy();
        }
        Console.WriteLine($"{Name} the {Breed} is playing with the {toy}.");
    }

    public void Fetch(string item = null)
    {
        if (item == null)
        {
            item = GetDynamicFetchItem();
        }
        Console.WriteLine($"{Name} the {Breed} is fetching the {item}.");
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
        if (target == null)
        {
            target = GetDynamicChasingTarget();
        }
        Console.WriteLine($"{Name} the {Breed} is chasing {target}.");
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

    private string GetDynamicMood()
    {
        Random random = new Random();
        int choice = random.Next(1, 11); // Generates a number between 1 and 10

        switch (choice)
        {
            case 1:
                return "angry";
            case 2:
                return "happy";
            case 3:
                return "scared";
            case 4:
                return "playful";
            case 5:
                return "curious";
            case 6:
                return "confused";
            case 7:
                return "tired";
            case 8:
                return "anxious";
            case 9:
                return "aggressive";
            case 10:
                return "sad";
            default:
                return "neutral";
        }
    }

    private string GetDynamicPlace()
    {
        Random random = new Random();
        int choice = random.Next(1, 11); // Generates a number between 1 and 10

        switch (choice)
        {
            case 1:
                return "dog house";
            case 2:
                return "backyard";
            case 3:
                return "living room";
            case 4:
                return "front door";
            case 5:
                return "back door";
            case 6:
                return "corner";
            case 7:
                return "bedroom";
            case 8:
                return "car";
            case 9:
                return "frontyard";
            case 10:
                return "pool";
            default:
                return "somewhere";
        }
    }

    private string GetDynamicChasingTarget()
    {
        Random random = new Random();
        int choice = random.Next(1, 11); // Generates a number between 1 and 10

        switch (choice)
        {
            case 1:
                return "a cat";
            case 2:
                return "the mailman";
            case 3:
                return "a mouse";
            case 4:
                return "a rabbit";
            case 5:
                return "a bunny";
            case 6:
                return "their tail";
            case 7:
                return "the burglar";
            case 8:
                return "a duck";
            case 9:
                return "a chicken";
            case 10:
                return "pool";
            default:
                return "somewhere";
        }
    }

    private string GetDynamicFood()
    {
        Random random = new Random();
        int choice = random.Next(1, 11); // Generates a number between 1 and 10

        switch (choice)
        {
            case 1:
                return "kibble";
            case 2:
                return "chicken";
            case 3:
                return "beef";
            case 4:
                return "a turkey leg";
            case 5:
                return "a steak";
            case 6:
                return "peanut butter";
            case 7:
                return "juicy sausages";
            case 8:
                return "some bacon";
            case 9:
                return "a drumstick";
            case 10:
                return "a porkchop";
            default:
                return "dog food";
        }
    }

    private string GetDynamicFetchItem()
    {
        Random random = new Random();
        int choice = random.Next(1, 11); // Generates a number between 1 and 10

        switch (choice)
        {
            case 1:
                return "a ball";
            case 2:
                return "a stick";
            case 3:
                return "a frisbee";
            case 4:
                return "a toy";
            case 5:
                return "a bone";
            case 6:
                return "a rope";
            case 7:
                return "a shoe";
            case 8:
                return "a newspaper";
            case 9:
                return "a hat";
            case 10:
                return "a glove";
            default:
                return "something";
        }
    }

    private string GetDynamicToy()
    {
        Random random = new Random();
        int choice = random.Next(1, 11); // Generates a number between 1 and 10

        switch (choice)
        {
            case 1:
                return "a ball";
            case 2:
                return "a squeaky toy";
            case 3:
                return "a rope";
            case 4:
                return "a frisbee";
            case 5:
                return "a plush toy";
            case 6:
                return "a chew toy";
            case 7:
                return "a tug toy";
            case 8:
                return "a ball";
            case 9:
                return "a squeaky toy";
            case 10:
                return "a rope";
            default:
                return "a toy";
        }
    }
}

class Program
{
    static void Main(string[] args)

    {

        Dog dog1 = new Dog("Debbie", "Labrador", "large", "golden");
        dog1.Describe();
        dog1.RandomlySelectAndExecute();

        Dog dog2 = new Dog("Butch", "Pitbull", "stout", "grey");
        dog2.Describe();
        dog2.RandomlySelectAndExecute();
    }
}
