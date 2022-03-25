namespace Lab2
{
    interface IPrototype<T>
    {
        T Clone();

        T DeepCopy();

    }
}
