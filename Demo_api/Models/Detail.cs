namespace Demo_api.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }
        public float SubTotal { get; set; }


        public int ProductoId { get; set; }
        public Product Product { get; set; }


        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}
