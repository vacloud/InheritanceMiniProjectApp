

List<IRentable> rentables = new List<IRentable> ();
List<IPurchasable> purchasables = new List<IPurchasable> ();

var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia" };
var book = new BookModel { ProductName = "Tale of Two", NumberOfPages = 350 };
var excavator = new ExcavatorModel { ProductName = "bulldozer", QuantityInStock = 2 };

rentables.Add (vehicle);
rentables.Add(excavator);

purchasables.Add(book);
purchasables.Add(vehicle);




Console.Write("Do you want to rent or purchase : (rent, purchase) : ");
string rentalDecision = Console.ReadLine ();

if(rentalDecision.ToLower() == "rent")
{
    foreach(var item in rentables)
    {
        Console.WriteLine($"item : {item.ProductName}");
        Console.Write("Do you want to write this item? : (yes/no) : ");
        string wantToRent = Console.ReadLine ();

        if(wantToRent.ToLower() == "yes")
        {
            item.Rent();
        }

        Console.Write("Do you want to return this item? : (yes/no) : ");
        string wantToReturn = Console.ReadLine();

        if (wantToReturn.ToLower() == "yes")
        {
            item.ReturnRental();
        }
    }
}
else
{
    foreach (var item in purchasables)
    {
        Console.WriteLine($"item : {item}");
        Console.Write("Do you want to purchase this product? (yes/no) ");
        string wantToPurchase = Console.ReadLine ();

        if (wantToPurchase.ToLower() == "yes") { 
        item.Purchase();
        }

        
    }

}
