using ISP.ISP.Interfaces;



namespace ISP.ISP.Printers
{
    public class MultiFunctionPrinter : IPrint, IScan
    {
        public void Print(Document document)
        {
            Console.WriteLine("Imprimiendo documento: " + document.Name);
        }

        public void Scan(Document document)
        {
            Console.WriteLine("Imprimiendo documento: " + document.Name);
        }
    }
}
