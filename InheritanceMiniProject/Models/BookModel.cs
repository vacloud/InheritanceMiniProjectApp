









public class BookModel : InventoryItemModel , IPurchasable
{
    public int NumberOfPages { get; set; }

    public void Purchase()
    {
        QuantityInStock--;
        Console.WriteLine("Book has been purchased");
    }

   
}
