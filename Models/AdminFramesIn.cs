namespace FramesBlazor.Models;

public class AdminFramesIn
{
    public AdminFramesIn()
    {
    }

    public AdminFramesIn(int id, int noOfFrames, DateTime date)
    {
        Id = id;
        NoOfFrames = noOfFrames;
        Date = date;
    }

    public AdminFramesIn(int noOfFrames, DateTime date)
    {
        NoOfFrames = noOfFrames;
        Date = date;
    }

    [Key]
    public int Id { get; set; }
    public int NoOfFrames { get; set; }
    public DateTime Date { get; set; }
}
