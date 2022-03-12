﻿namespace FramesBlazor.Models;

public class WorkerFramesIn
{
    [Key]
    public int Id { get; set; }

    public DateTime Datetime { get; set; }

    public int NoOfFrames { get; set; }

    public int WorkerId { get; set; }

    [ForeignKey("WorkerId")]
    public Worker? Worker { get; set; }
}
