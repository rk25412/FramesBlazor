namespace FramesBlazor.Contracts;

public interface IAdminFrameService
{
    #region AdminFramesIn
    Task<IQueryable<AdminFramesIn>> GetAllAdminFramesIn(Query? query);
    Task<AdminFramesIn> GetAdminFramesIn(int id, Query? query);
    Task<AdminFramesIn> AddAdminFramesIn(AdminFramesIn adminFramesIn);
    Task<AdminFramesIn> UpdateAdminFramesIn(AdminFramesIn adminFramesIn);
    Task<AdminFramesIn> DeleteAdminFramesIn(int adminFrameInId);
    #endregion
}
