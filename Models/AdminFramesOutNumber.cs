﻿namespace FramesBlazor.Models;

public class AdminFramesOutNumber
{
    [Key]
    public int Id { get; set; }

    public int NoOfFrames { get; set; }

    public int ItemTypeId { get; set; }

    public int AdminFramesOutId { get; set; }

    [ForeignKey("ItemTypeId")]
    public ItemType? ItemType { get; set; }

    [ForeignKey("AdminFramesOutId")]
    public AdminFramesOut? AdminFramesOut { get; set; }
}
