namespace NebusokuDev.StateMover.Runtime
{
    public interface IMoverInput
    {
        float Horizontal { get; }
        float Vertical { get; }
        bool IsUpward { get; }
        bool IsDownward { get; }
    }
}