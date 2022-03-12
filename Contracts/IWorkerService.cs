namespace FramesBlazor.Contracts;

public interface IWorkerService
{
    Task<IQueryable<Worker>> GetWorkers(Query? query);
    Task<Worker> GetWorker(int id, Query? query);
    Task<Worker> AddWorker(Worker worker);
    Task<Worker> UpdateWorker(Worker worker);
    Task<Worker> DeleteWorker(int workerId);
    Task<int> GetTotalCount();
    Task<bool> DoesWorkerExists(string name);
}
