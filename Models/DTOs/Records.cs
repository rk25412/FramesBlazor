namespace FramesBlazor.Models.DTOs;

public record class FramesInGroupedData(DateOnly Date, List<FramesInSubData> SubData);
public record class FramesInSubData(int Id, TimeOnly time, int NoOfFrames);