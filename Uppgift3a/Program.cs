
using Uppgift3a;

// 3.1
Console.WriteLine("\n -- 3.1 --\n");


try
{
    Person person = new Person("A", "Bertilsson");
}
catch (ArgumentException argEx)
{
    Console.WriteLine(argEx.Message);
}


PersonHandler ph = new PersonHandler();

try
{
    Person p1 = ph.CreatePerson(33, "Anna", "Jansson", 175, 80);
    Person p2 = ph.CreatePerson(22, "Jan", "Persson", 181, 83);
    Person p3 = ph.CreatePerson(39, "Ulf", "Vikström", 190, 90);

    // Exception faults
    //Person p4 = ph.CreatePerson(-1, "Ulf", "Vikström", 190, 90);
    //Person p5 = ph.CreatePerson(39, "U", "Vikström", 190, 90);
    //Person p6 = ph.CreatePerson(39, "Ulf", "Vi", 190, 90);

    // testing setters
    ph.PrintInfo(p1);
    ph.ChangePersonFirstName(p1, "Annika");
    ph.ChangePersonLastName(p1, "Larsson");
    ph.ChangePersonAge(p1, 34);
    ph.ChangePersonWeight(p1, 79);
    ph.ChangePersonHeight(p1, 176);
    ph.PrintInfo(p1);

    // testing getters
    String info = ph.GetPersonFirstName(p2);
    info = info + " " + ph.GetPersonLastName(p2);
    info = info + " " + ph.GetPersonAge(p2);
    info = info + " " + ph.GetPersonHeight(p2);
    info = info + " " + ph.GetPersonWeight(p2);
    Console.WriteLine(info);
}
catch (ArgumentException argEx)
{
    Console.WriteLine(argEx.Message);
}


// 3.2
Console.WriteLine("\n -- 3.2 --\n");

List<UserError> errors = new List<UserError>() {
    new NumericInputError(),
    new TextInputError(),
    new NumericInputError(),
    new TextInputError(),
    new TextInputError(),
    new NumericInputError()
};

foreach(UserError error in errors)
{
    Console.WriteLine(error.UEMessage());
}

Console.WriteLine();

errors = new List<UserError>() {
    new NumericRangeError(),
    new FloatingPointError(),
    new NegativeNumberError(),
    new NumericRangeError(),
    new FloatingPointError(),
    new NegativeNumberError()
};

foreach (UserError error in errors)
{
    Console.WriteLine(error.UEMessage());
}


// 3.4
Console.WriteLine("\n -- 3.4 --\n");

List<Animal> animals = new List<Animal>() {
    new Horse("Brunte", 850, 14),
    new Dog("Fido", 8, 3),
    new Hedgehog("Sonic", 0.6, 2, 1587),
    new Worm("Hose", 0.09, 1, 13),
    new Bird("Polly", 1, 7, 40),
    new Dog("Frasse", 10, 8),
    new Wolf("Zeke", 18, 9, "Grey"),
    new Dog("Smulan", 8, 3),
    new Pelican("Bo", 8, 13, 1500),
    new Wolfman("Woverine", 90, 39, "Black")
};

foreach (Animal animal in animals)
{
    Console.WriteLine(animal.DoSound());
    if(animal is IPerson)
    {
        Console.WriteLine( ((IPerson)animal).Talk() );
    }
}

// Dog list
List<Dog> dog = new List<Dog>() {
    new Dog("Fido", 3, 2),
    new Dog("Frasse", 10, 8),
    new Dog("Smulan", 8, 3),
    // can not add horse, it's not a type of dog
};

// print stat on all objects in animals
Console.WriteLine();
foreach (Animal animal in animals)
{
    Console.WriteLine(animal.Stats());
}

// print stat only on dogs
Console.WriteLine();
foreach(Animal animal in animals)
{
    if(animal is Dog)
    {
        Console.WriteLine( ((Dog)animal).Stats() );
    }
}

// print posture on dogs
Console.WriteLine();
foreach (Animal animal in animals)
{
    if (animal is Dog)
    {
        Console.WriteLine( ((Dog)animal).GetPosture() );
    }
}
