// See https://aka.ms/new-console-template for more information
using csharp_lista_indirizzi;


StreamReader file = File.OpenText("C:/Users/LombarSupport/Downloads/addresses.csv");

List<Address> personAddressList = new List<Address>();

int lineCounter = 0;

while (!file.EndOfStream)
{

    string readText = file.ReadLine();
    lineCounter++;

     if (lineCounter > 1)
{
        string[] splitInfo = readText.Split(',');

    if (splitInfo.Length != 6)
    {
        Console.WriteLine($"Mancano delle informazioni nella riga {lineCounter}");
    }
    else
    {
        Address personAddress = new Address(splitInfo[0], splitInfo[1], splitInfo[2], splitInfo[3], splitInfo[4], splitInfo[5]);
        personAddressList.Add(personAddress);
    }

}
}
     


foreach (Address personAddress in personAddressList)
{
    Console.WriteLine(personAddress);
}

