using System.ComponentModel;

List<string> firstNames = new();
List<string> lastNames = new();

while (true)
{
    Console.Write("Enter your first name (Press Enter and leave blank when done): ");
    string? firstname = Console.ReadLine();

    if (firstname == string.Empty)
    {
        break;
    }

    Console.Write("Enter your last name: ");
    string? lastname = Console.ReadLine();

    firstNames.Add(firstname);
    lastNames.Add(lastname);
}
Console.WriteLine();
Console.WriteLine("--Students--");
string format = "{0,-10} {1,-10}*";
Console.WriteLine(format,"First", "Last");

for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine(format, firstNames[i], lastNames[i]);
}
