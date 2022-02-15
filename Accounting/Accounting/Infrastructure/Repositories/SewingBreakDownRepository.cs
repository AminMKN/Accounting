using System.Data.Entity;
using System.Linq;
using Accounting.Infrastructure.Contracts;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Repositories
{
    public class SewingBreakDownRepository : ISewingBreakDownRepository
    {
        private readonly Context _context = new Context();

        public void Create(string code, string name, string color, string size, string qty, string percentBreakDown,
            string description, string date)
        {
            var sewingBreakDown = new SewingBreakDown()
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
            _context.SewingBreakDowns.Add(sewingBreakDown);
        }

        public void Edit(int id, string code, string name, string color, string size, string qty, string percentBreakDown,
            string description, string date)
        {
            var sewingBreakDown = _context.SewingBreakDowns.FirstOrDefault(x => x.Id == id);
            sewingBreakDown.Code = code;
            sewingBreakDown.Name = name;
            sewingBreakDown.Color = color;
            sewingBreakDown.Size = size;
            sewingBreakDown.Qty = qty;
            sewingBreakDown.PercentBreakDown = percentBreakDown;
            sewingBreakDown.Description = description;
            sewingBreakDown.Date = date;
        }

        public void Delete(int id)
        {
            var sewingBreakDown = _context.SewingBreakDowns.FirstOrDefault(x => x.Id == id);
            _context.SewingBreakDowns.Remove(sewingBreakDown);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public object SearchCode(string code)
        {
            var search = _context.SewingBreakDowns.Where(c => c.Code.Contains(code));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object SearchName(string name)
        {
            var search = _context.SewingBreakDowns.Where(c => c.Name.Contains(name));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object GetAll()
        {
            return _context.SewingBreakDowns.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }

        public object SearchDate(string date)
        {
            var search = _context.SewingBreakDowns.Where(c => c.Date.Contains(date));
            return search.OrderByDescending(x => x.Id).AsNoTracking().ToList();
        }
    }
}
