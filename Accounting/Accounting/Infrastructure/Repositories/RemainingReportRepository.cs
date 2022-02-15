using Accounting.Infrastructure.Contracts;
using Accounting.Infrastructure.Models;
using System.Data.Entity;
using System.Linq;

namespace Accounting.Infrastructure.Repositories
{
    public class RemainingReportRepository : IRemainingReportRepository
    {
        private readonly Context _context = new Context();

        public void Create(string code, string name, string color, string size, string qty,
            string percentage, string type, string description, string date)
        {
            var remainingReport = new RemainingReport()
            {
                Code = code,
                Name = name,
                Color = color,
                Size = size,
                Qty = qty,
                Percentage = percentage,
                Type = type,
                Description = description,
                Date = date
            };
            _context.RemainingReports.Add(remainingReport);
        }

        public void Delete(int id)
        {
            var remainingReport = _context.RemainingReports.FirstOrDefault(x => x.Id == id);
            _context.RemainingReports.Remove(remainingReport);
        }

        public void Edit(int id, string code, string name, string color, string size, string qty,
            string percentage, string type, string description, string date)
        {
            var remainingReport = _context.RemainingReports.FirstOrDefault(x => x.Id == id);
            remainingReport.Code = code;
            remainingReport.Name = name;
            remainingReport.Color = color;
            remainingReport.Size = size;
            remainingReport.Qty = qty;
            remainingReport.Percentage = percentage;
            remainingReport.Type = type;
            remainingReport.Description = description;
            remainingReport.Date = date;
        }

        public object GetAll()
        {
            return _context.RemainingReports.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public object SearchCode(string code)
        {
            var search = _context.RemainingReports.Where(c => c.Code.Contains(code));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object SearchDate(string date)
        {
            var search = _context.RemainingReports.Where(c => c.Date.Contains(date));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object SearchName(string name)
        {
            var search = _context.RemainingReports.Where(c => c.Name.Contains(name));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }
    }
}
