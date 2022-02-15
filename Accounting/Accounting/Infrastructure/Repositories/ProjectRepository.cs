using Accounting.Infrastructure.Contracts;
using Accounting.Infrastructure.Models;
using System.Data.Entity;
using System.Linq;

namespace Accounting.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly Context _context = new Context();

        public void Create(string code, string name, string customer, string date, string qty, string barCode)
        {
            var project = new Project()
            {
                Code = code,
                Name = name,
                Customer = customer,
                Date = date,
                Qty = qty,
                BarCode = barCode,
            };
            _context.Projects.Add(project);
        }

        public void Edit(int id, string code, string name, string customer, string date, string qty, string barCode)
        {
            var project = _context.Projects.FirstOrDefault(x => x.Id == id);
            project.Code = code;
            project.Name = name;
            project.Customer = customer;
            project.Date = date;
            project.Qty = qty;
            project.BarCode = barCode;
        }

        public void Delete(int id)
        {
            var project = _context.Projects.FirstOrDefault(x => x.Id == id);
            _context.Projects.Remove(project);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public object GetAll()
        {
            return _context.Projects.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object SearchCode(string code)
        {
            var search = _context.Projects.Where(c => c.Code.Contains(code));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object SearchCustomer(string customer)
        {
            var search = _context.Projects.Where(c => c.Customer.Contains(customer));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object SearchDate(string date)
        {
            var search = _context.Projects.Where(c => c.Date.Contains(date));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }
    }
}
