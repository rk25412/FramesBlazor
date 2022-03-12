namespace FramesBlazor.Models;

public class AdminFramesOut
{
    [Key]
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public ICollection<AdminFramesOutNumber> AdminFramesOutNumbers { get; set; } = new List<AdminFramesOutNumber>();
}
