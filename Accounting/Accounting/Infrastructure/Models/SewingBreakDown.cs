namespace Accounting.Infrastructure.Models
{
    public partial class SewingBreakDown
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Qty { get; set; }
        public string PercentBreakDown { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
