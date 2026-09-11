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
         Console.WriteLine($"{groceryList[i]}: {pris[i]}kr ");   
         
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
           Console.WriteLine($"Ta bort {groceryList[remove - 1]}, {pris[remove - 1]}  ");
           groceryList.RemoveAt(remove - 1);
           pris.RemoveAt(remove - 1);
        }
        else 
        {
        Console.WriteLine($"Det finns ingen {remove}");
        }

}
}