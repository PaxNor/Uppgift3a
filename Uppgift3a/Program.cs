
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
    Person p2 = ph.CreatePerson(-1, "Jan", "Persson", 181, 83);
    Person p3 = ph.CreatePerson(39, "Ulf", "Vikström", 190, 90);
}
catch (ArgumentException argEx)
{
    Console.WriteLine(argEx.Message);
}
