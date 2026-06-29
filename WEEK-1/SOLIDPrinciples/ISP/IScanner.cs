namespace SOLIDPrinciples.ISP
{
    /// <summary>
    /// Segregated interface for scanning functionality
    /// Interface Segregation: Clients should not be forced to depend on interfaces they don't use
    /// </summary>
    public interface IScanner
    {
        void Scan(string document);
    }
}
