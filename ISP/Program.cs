using ISP.ISP;
using ISP.ISP.Interfaces;
using ISP.ISP.Printers;
public class Program
{
    public static void Main(string[] args)
    {
        Document doc = new Document { Name = "Reporte" };

        IPrint simplePrinter = new SimplePrinter();
        simplePrinter.Print(doc);

        MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
        multiFunctionPrinter.Print(doc);
        multiFunctionPrinter.Scan(doc);
    }
}