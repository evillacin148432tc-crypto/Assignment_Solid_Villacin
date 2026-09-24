# Assignment_Solid

**SRP:** Form1 originally did math, database saving, emailing, and text
formatting all in one class. I split each job into its own class
(`OrderCalculator`, `OrderRepository`, `InvoiceEmailSender`,
`InvoicePrinter`) so Form1 just calls them instead of doing the work itself.

**OCP:** Discounts were a hardcoded `if/else` chain, so adding a new
discount meant editing working code. I replaced it with an
`IDiscountStrategy` interface and one class per discount type. New
discounts are now new classes — no existing code gets touched.

**LSP:** I added `FreeShippingDiscount`, which implements
`IDiscountStrategy` but throws an error instead of returning a value.
Selecting it crashed the app. This showed that implementing an interface
isn't enough — a class also has to honor what callers expect it to *do*.
A subtype that can't be swapped in safely breaks the whole point of coding
against an interface.

**ISP:** Instead of one big interface with Save/Email/Print methods, I
split it into `IOrderRepository`, `IInvoiceSender`, and `IInvoiceFormatter`,
so each class only implements the one method it actually needs.

**DIP:** Form1 used to create `SqlConnection` and `SmtpClient` directly.
Now it depends on interfaces instead, and the real classes get passed in
through the constructor — so the UI isn't hardwired to a specific database
or email provider.

**FakeOrderRepository:** A fake `IOrderRepository` that stores orders in a
list instead of a real database — it's useful for testing because it lets
you check that "Save Order" works correctly without needing a real SQL
Server connection.
