namespace FramesBlazor.Models;

public class ItemType
{
    public ItemType()
    {
    }

    public ItemType(int id, string itemName, decimal adminPrice, decimal workerPrice)
    {
        Id = id;
        ItemName = itemName;
        AdminPrice = adminPrice;
        WorkerPrice = workerPrice;
    }

    public ItemType(string itemName, decimal adminPrice, decimal workerPrice)
    {
        ItemName = itemName;
        AdminPrice = adminPrice;
        WorkerPrice = workerPrice;
    }

    [Key]
    public int Id { get; set; }

    [Required]
    public string ItemName { get; set; } = default!;

    [Precision(10, 2)]
    public decimal AdminPrice { get; set; }

    [Precision(10, 2)]
    public decimal WorkerPrice { get; set; }
}
