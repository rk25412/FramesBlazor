namespace FramesBlazor.Pages.Workers;

public partial class Workers : ComponentBase
{
    [Inject] IWorkerService workerService { get; set; } = default!;
    [Inject] DialogService DialogService { get; set; } = default!;

    IEnumerable<Worker> WorkersList = default!;
    Worker worker = default!;
    RadzenDataGrid<Worker> grid = default!;
    bool isLoading;
    int count;
    async Task LoadData(LoadDataArgs args)
    {
        isLoading = true;

        var query = await workerService.GetWorkers(null);

        await Task.Yield();

        if (!string.IsNullOrEmpty(args.Filter))
            query = query.Where(args.Filter);

        if (!string.IsNullOrEmpty(args.OrderBy))
            query = query.OrderBy(args.OrderBy);

        count = query.Count();

        WorkersList = query.Skip(args.Skip.Value).Take(args.Top.Value).ToList();

        isLoading = false;
    }
    async Task DeleteWorker(int workerId, string workerName)
    {
        var result = await DialogService.Confirm("Are you sure?", $"Delete {workerName}!!",
        new ConfirmOptions { OkButtonText = "Yes", CancelButtonText = "No" });

        if (result is true)
        {
            await workerService.DeleteWorker(workerId);
            await grid.Reload();
            grid.Reset(true, true);
        }
    }
}
