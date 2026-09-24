namespace Assignment_Solid
{
    public class InvoicePrinter
    {
        public string BuildInvoiceText(string email, decimal total) =>
            $"Invoice for {email}: {total:C}";
    }
}