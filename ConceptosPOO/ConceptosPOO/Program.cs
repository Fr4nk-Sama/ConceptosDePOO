using ConceptosPOO;

Console.WriteLine("Hello, Robal!");

Date date1 = new Date(2023, 03, 21);

try
{
    Console.WriteLine(date1.ToString());
    Console.WriteLine(new Date(2023, 11, 45));
    Console.WriteLine(new Date(2023, 19, 21));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
