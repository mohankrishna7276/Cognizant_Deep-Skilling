namespace BuilderPattern
{
    public class Director
    {
        public void BuildComputer(IComputerBuilder builder)
        {
            builder.SetProcessor();
            builder.SetRAM();
            builder.SetStorage();
            builder.SetGraphicsCard();
        }
    }
}