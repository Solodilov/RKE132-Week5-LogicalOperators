//Math >= 90 OR Chemistry >= 90
//math && chem || math && bio || chem && bio

int math, bio, chem;

Console.WriteLine("Enter your Math results:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology results:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry results:");
chem = Int32.Parse(Console.ReadLine());

if(math >= 90 && chem >= 90 || math >= 90 && bio >= 90 || bio >= 90 && chem >= 90)
{
    Console.WriteLine("Congratulations! You got accepted.");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}