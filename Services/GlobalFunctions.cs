namespace FramesBlazor.Services;

public static class GlobalFunctions
{
    public static IEnumerable<FramesInGroupedData> GetGroupedDataFromAdminFramesIn(IEnumerable<AdminFramesIn> adminFramesIns)
    {
        List<FramesInGroupedData> groupedData = new();
        foreach (var item in adminFramesIns)
        {
            if (groupedData.Any(x => x.Date.Equals(DateOnly.FromDateTime(item.Date))))
            {
                groupedData.FirstOrDefault(x =>
                    x.Date.Equals(DateOnly.FromDateTime(item.Date))).SubData.Add(
                        new(item.Id, TimeOnly.FromDateTime(item.Date), item.NoOfFrames));
            }
            else
            {
                groupedData.Add(new(DateOnly.FromDateTime(item.Date), new()));
                groupedData.FirstOrDefault(x =>
                    x.Date.Equals(DateOnly.FromDateTime(item.Date))).SubData.Add(
                        new(item.Id, TimeOnly.FromDateTime(item.Date), item.NoOfFrames));
            }
        }

        return groupedData.OrderBy(x => x.Date);
    }
}
