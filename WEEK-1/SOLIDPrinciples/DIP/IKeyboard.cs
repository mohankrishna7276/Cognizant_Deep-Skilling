namespace SOLIDPrinciples.DIP
{
    /// <summary>
    /// Abstraction for keyboard
    /// Dependency Inversion: Depend on abstractions, not concrete implementations
    /// </summary>
    public interface IKeyboard
    {
        void Type(string text);
    }
}
