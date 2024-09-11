string UserEntry;
Console.WriteLine("write the desired text");
UserEntry = Console.ReadLine();
string trimmedtext;
trimmedtext = UserEntry.Replace(" ", "");
int txtlength = trimmedtext.Length;
Console.WriteLine("Amount of characters is : " + txtlength);
Console.ReadKey();
