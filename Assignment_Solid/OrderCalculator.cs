using System;
using System.Windows.Forms;

namespace Assignment_Solid
{
    public class OrderCalculator
    {
        public decimal CalculateTotal(DataGridView grid)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells["Price"].Value == null) continue;
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int qty = Convert.ToInt32(row.Cells["Qty"].Value);
                total += price * qty;
            }
            return total;
        }
    }
}