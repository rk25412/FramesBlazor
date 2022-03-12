﻿namespace FramesBlazor.Models;

public class WorkerBill
{
    [Key]
    public int Id { get; set; }
    public DateTime Date { get; set; }

    [Precision(10, 2)]
    public decimal Amount { get; set; }
    public bool Cleared { get; set; }

    public int WorkerId { get; set; }

    [ForeignKey("WorkerId")]
    public Worker? Worker { get; set; }

    public ICollection<WorkerBillFrameTypes> WorkerBillFrameTypes { get; set; } = new List<WorkerBillFrameTypes>();
}
