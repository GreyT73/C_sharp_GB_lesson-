Console.Write("Enter user name: ");
string user = Console.ReadLine();
if(user.ToLower() == "sergey")
{
    Console.WriteLine("OMG! This is Sergey <3");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(user);
}