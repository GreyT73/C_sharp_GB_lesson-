Console.Write("Enter user name: ");
string username = Console.ReadLine();
if(username.ToLower() == "sergey")
{
    Console.WriteLine("OMG! This is Sergey <3");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}