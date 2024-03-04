namespace VectorImplementations
{
    public interface IStackADT<T>
    {
        int Size { get; }

        T Peek();
        T Pop();
        void Push(T elem);
    }
}