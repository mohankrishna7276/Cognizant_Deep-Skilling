using System;

namespace SOLIDPrinciples.ISP
{
    /// <summary>
    /// Multi-function printer that implements both segregated interfaces
    /// Instead of one bloated interface, it implements the specific interfaces it needs
    /// </summary>
    public class MultiFunctionPrinter : IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing document: {document}");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"Scanning document: {document}");
        }
    }
}
