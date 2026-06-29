namespace BuilderPattern
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer computer;

        public GamingComputerBuilder()
        {
            computer = new Computer();
        }

        public void SetProcessor()
        {
            computer.Processor = "Intel Core i9";
        }

        public void SetRAM()
        {
            computer.RAM = "32 GB DDR5";
        }

        public void SetStorage()
        {
            computer.Storage = "1 TB SSD";
        }

        public void SetGraphicsCard()
        {
            computer.GraphicsCard = "NVIDIA RTX 4080";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}