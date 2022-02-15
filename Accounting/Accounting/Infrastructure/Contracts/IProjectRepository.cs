namespace Accounting.Infrastructure.Contracts
{
    public interface IProjectRepository
    {
        void Create(string code, string name, string customer, string date,
            string qty, string barCode);
        void Edit(int id, string code, string name, string customer, string date,
            string qty, string barCode);
        void Delete(int id);
        void SaveChanges();
        object SearchCode(string code);
        object SearchCustomer(string customer);
        object SearchDate(string date);
        object GetAll();
    }
}
