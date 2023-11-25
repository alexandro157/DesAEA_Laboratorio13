namespace Demo_api.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public int InvoiceNumber { get; set; }
        public float Total { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
