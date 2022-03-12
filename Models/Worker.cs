namespace FramesBlazor.Models;

public class Worker
{
    public Worker()
    {
    }

    public Worker(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Worker(string name)
    {
        Name = name;
    }

    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = default!;


    public ICollection<WorkerFramesIn> WorkerFramesIn { get; set; } = new List<WorkerFramesIn>();
    public ICollection<WorkerBill> WorkerBills { get; set; } = new List<WorkerBill>();
    public ICollection<WorkerFramesOut> WorkerFramesOut { get; set; } = new List<WorkerFramesOut>();
}
