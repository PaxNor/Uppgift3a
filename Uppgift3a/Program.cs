
using Uppgift3a;

//try
//{
//    Person person = new Person("A", "Bertilsson");
//}
//catch (ArgumentException argEx)
//{
//    Console.WriteLine(argEx.Message);
//}

PersonHandler ph = new PersonHandler();

try
{
    Person p1 = ph.CreatePerson(33, "Anna", "Jansson", 175, 80);
    Person p2 = ph.CreatePerson(22, "Jan", "Persson", 181, 83);
    Person p3 = ph.CreatePerson(39, "Ulf", "Vikström", 190, 90);

    // Exception faults
    //Person p4 = ph.CreatePerson(-1, "Ulf", "Vikström", 190, 90);
    //Person p4 = ph.CreatePerson(39, "U", "Vikström", 190, 90);
    //Person p4 = ph.CreatePerson(39, "Ulf", "Vi", 190, 90);

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
