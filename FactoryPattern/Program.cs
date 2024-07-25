using System;

// Product interface
public interface IInvoice
{
    void Generate();
}

// Concrete product for PDF invoice
public class PDFInvoice : IInvoice
{
    public void Generate()
    {
        // Code to generate PDF invoice
        Console.WriteLine("Generating PDF Invoice");
    }
}

// Concrete product for Excel invoice
public class ExcelInvoice : IInvoice
{
    public void Generate()
    {
        // Code to generate Excel invoice
        Console.WriteLine("Generating Excel Invoice");
    }
}

// Concrete factory
public class InvoiceFactory
{
    public IInvoice CreateInvoice(string invoiceType)
    {
        switch (invoiceType)
        {
            case "PDF":
                return new PDFInvoice();
            case "Excel":
                return new ExcelInvoice();
            default:
                throw new ArgumentException("Invalid invoice type");
        }
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        InvoiceFactory factory = new InvoiceFactory();
        string userRequest = "PDF"; // This could be dynamic based on user input

        // Create and generate invoice
        IInvoice invoice = factory.CreateInvoice(userRequest);
        invoice.Generate();
    }
}
