namespace DBAccess.Access
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U props, string connectionId = "Default");
        Task PostData<T>(string storedProcedure, T props, string connectionId = "Default");
    }
}