









public class ExcavatorModel : InventoryItemModel , IRentable
{
    public void Dig()
    {
        Console.WriteLine("I am digging");
    }

    public void Rent()
    {
        QuantityInStock--;
        Console.WriteLine("This excavator has been rented");
    }

    public void ReturnRental()
    {
        QuantityInStock++;
        Console.WriteLine("Excavator has been returned");
    }
}