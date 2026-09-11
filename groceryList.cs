using System.ComponentModel;

Console.WriteLine("---Welcome to GroceryList");

List<string> groceryList = [];
List<int> pris = [];


while (true)
{

if (groceryList.Count == 0)

    {
        Console.WriteLine ("Listan är tom");
        
    } 
else
    {
      for (int i = 0; i < groceryList.Count; i += 1)
        {
         Console.WriteLine($"{i + 1}.{groceryList[i]}: {pris[i]}kr ");   
         
        }
        int sum = pris.Sum();
        Console.WriteLine($"Total priset blir {sum}kr");
    } 
Console.WriteLine("Skriv in en matvara eller skriv en siffra för att ta bort");
string inputMat = Console.ReadLine();

    
if (int.TryParse(inputMat, out int remove))

    {
    if (remove >= 1 && remove <= groceryList.Count)
        {
           Console.WriteLine($"Ta bort {groceryList[remove - 1]}, {pris[remove - 1]}kr");
           groceryList.RemoveAt(remove - 1);
           pris.RemoveAt(remove - 1);
        }
        else 
        {
        Console.WriteLine($"Det finns ingen {remove}");
        }

    }
else if (inputMat == "dyrast")
    {
        if (groceryList.Count == 0)
        {
            Console.WriteLine("Listan är tom, det finns ingen dyr matprodukt");
        }
        else
        {
            int max = pris.Max();
            int maxIndex = pris.IndexOf(max);
            Console.WriteLine($"Det dyraste är {groceryList[maxIndex]} för {max}kr");
        }
    }


else
    {
    Console.WriteLine("Skriv in pris:");
    string inputPrisText = Console.ReadLine();

    if (int.TryParse(inputPrisText, out int inputPris ))

        {
            groceryList.Add(inputMat);
            pris.Add(inputPris);  
        }
    else
        {
            Console.WriteLine("Ogiltigt pris, du måste skrifa siffra");  
        }

            Console.WriteLine("");



    }
}