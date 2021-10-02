using System;



class Program
{
    static void Main(string[] args)
    {
        string decide = "y";
        string selectFlower;
        FlowerStore flowerStore = new FlowerStore();

        do
        {
            ShowAllFlower(flowerStore);
            selectFlower = Console.ReadLine();
            SelectFlower(selectFlower,flowerStore);
            wantExit();
            decide = Console.ReadLine();
            showCart(decide,flowerStore);
      
    }
 while(decide != "exit");

        
        
        
 }
   
    static void ShowAllFlower(FlowerStore flowerStore)
    {
        Console.WriteLine("Select number for buy flower :");
        foreach (string i in flowerStore.flowerList)
        {
            Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
            Console.WriteLine(i);
        }
    }
    static void SelectFlower(string selected, FlowerStore flowerStore)
    {
        switch (selected)
        {

            case "1":
                flowerStore.addToCart(flowerStore.flowerList[0]);
                Console.WriteLine("Added " + flowerStore.flowerList[0]);
                break;
            case "2":
                flowerStore.addToCart(flowerStore.flowerList[1]);
                Console.WriteLine("Added " + flowerStore.flowerList[1]);
                break;
            default:
                Console.WriteLine("Not Added to cart. found select number of flower");
                break;
        }
    }
    static void wantExit()
    {
        Console.WriteLine("You can stop this progress ? exit for >> exit << progress and press any key for continue");
    }
    static void showCart(string decide,FlowerStore flowerStore)
    {
        if (decide == "exit")
        {
            Console.Write("Current my cart");
            flowerStore.showCart();
        }
    }
}
