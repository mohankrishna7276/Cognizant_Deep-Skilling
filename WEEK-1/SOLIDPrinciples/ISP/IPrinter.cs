namespace SOLIDPrinciples.ISP
{
    /// <summary>
    /// Segregated interface for printing functionality
    /// Interface Segregation: Clients should not be forced to depend on interfaces they don't use
    /// </summary>
    public interface IPrinter
    {
        void Print(string document);
    }
}
