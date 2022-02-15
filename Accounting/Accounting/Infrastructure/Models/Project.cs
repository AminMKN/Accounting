namespace Accounting.Infrastructure.Models
{
    public partial class Project
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Date { get; set; }
        public string Qty { get; set; }
        public string BarCode { get; set; }
    }
}
