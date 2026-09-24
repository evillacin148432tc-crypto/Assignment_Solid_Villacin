using System;
using System.Windows.Forms;

namespace Assignment_Solid
{
    public partial class Form1 : Form
    {
        private readonly OrderCalculator _calculator = new();
        private readonly OrderRepository _repository = new("Server=localhost;Database=Orders;Trusted_Connection=True;");
        private readonly InvoiceEmailSender _emailSender = new();
        private readonly InvoicePrinter _printer = new();

        private decimal total;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            total = _calculator.CalculateTotal(dgvItems);

            string discount = cmbDiscountType.SelectedItem.ToString();
            if (discount == "Student") total *= 0.9m;
            else if (discount == "Senior") total *= 0.85m;
            else if (discount == "BlackFriday") total *= 0.7m;

            lblTotal.Text = total.ToString("C");
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            _repository.Save(txtCustomerEmail.Text, total);
            MessageBox.Show("Saved!");
        }

        private void btnEmailInvoice_Click(object sender, EventArgs e)
        {
            _emailSender.Send(txtCustomerEmail.Text, total);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_printer.BuildInvoiceText(txtCustomerEmail.Text, total));
        }
    }
}