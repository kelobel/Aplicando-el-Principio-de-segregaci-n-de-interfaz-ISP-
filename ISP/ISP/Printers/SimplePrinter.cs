using ISP.ISP.Interfaces;


namespace ISP.ISP.Printers
{
    public class SimplePrinter : IPrint
    {
        public void Print(Document document)
        {
            Console.WriteLine("Imprimiendo documento: " + document.Name);
        }
    }
}
