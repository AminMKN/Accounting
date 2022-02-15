using System.Data.Entity;
using System.Linq;
using Accounting.Infrastructure.Contracts;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Repositories
{
    public class PrintBreakDownRepository : IPrintBreakDownRepository
    {
        private readonly Context _context = new Context();

        public void Create(string code, string name, string color, string size, string qty, string percentBreakDown,
            string description, string date)
        {
            var printBreakDown = new PrintBreakDown()
            {
                Code = code,
                Name = name,
                Color = color,
                Size = size,
                Qty = qty,
                PercentBreakDown = percentBreakDown,
                Description = description,
                Date = date
            };
            _context.PrintBreakDowns.Add(printBreakDown);
        }

        public void Edit(int id, string code, string name, string color, string size, string qty, string percentBreakDown,
            string description, string date)
        {
            var printBreakDown = _context.PrintBreakDowns.FirstOrDefault(x => x.Id == id);
            printBreakDown.Code = code;
            printBreakDown.Name = name;
            printBreakDown.Color = color;
            printBreakDown.Size = size;
            printBreakDown.Qty = qty;
            printBreakDown.PercentBreakDown = percentBreakDown;
            printBreakDown.Description = description;
            printBreakDown.Date = date;
        }

        public void Delete(int id)
        {
            var printBreakDown = _context.PrintBreakDowns.FirstOrDefault(x => x.Id == id);
            _context.PrintBreakDowns.Remove(printBreakDown);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public object SearchCode(string code)
        {
            var search = _context.PrintBreakDowns.Where(x => x.Code.Contains(code));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object SearchName(string name)
        {
            var search = _context.PrintBreakDowns.Where(x => x.Name.Contains(name));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object SearchDate(string date)
        {
            var search = _context.PrintBreakDowns.Where(x => x.Date.Contains(date));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object GetAll()
        {
            return _context.PrintBreakDowns.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }
    }
}
