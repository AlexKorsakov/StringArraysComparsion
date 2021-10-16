namespace StringArrayComparsion
{
    public interface IStringArrayComparer
    {
        void Initialize(string[] left, string[] right);

        bool AreArraysEqual();
    }
}