
using Uppgift3a;

try
{
    Person person = new Person("A", "Bertilsson");
}
catch (ArgumentException argEx)
{
    Console.WriteLine(argEx.Message);
}
