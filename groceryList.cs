Console.WriteLine("---Welcome to GroceryList");

List<string> groceryList = ["mjölk", "bröd"];
List<int> pris = [15, 2];




while (true)
{

   if (groceryList.Count == 0)

    {
        Console.WriteLine ("Listan är tom");
        
    } 
    else
    {
      int summa = 0;  
      for (int i = 0; i < groceryList.Count; i += 1)
        {
         Console.WriteLine($"{groceryList[i]}: {pris[i]}kr ");   
         
        }
        int sum = pris.Sum();
        Console.WriteLine($"Total priset blir {sum}kr");
    } 
}  
    
