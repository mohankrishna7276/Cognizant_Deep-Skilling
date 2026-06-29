namespace BuilderPattern
{
    public interface IComputerBuilder
    {
        void SetProcessor();
        void SetRAM();
        void SetStorage();
        void SetGraphicsCard();

        Computer GetComputer();
    }
}