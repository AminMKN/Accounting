namespace Accounting.Infrastructure.Contracts
{
    public interface IRemainingReportRepository
    {
        void Create(string code, string name, string color, string size,
            string qty, string percentage, string type, string description, string date);
        void Edit(int id, string code, string name, string color, string size,
            string qty, string percentage, string type, string description, string date);
        void Delete(int id);
        void SaveChanges();
        object SearchCode(string code);
        object SearchName(string name);
        object SearchDate(string date);
        object GetAll();
    }
}
