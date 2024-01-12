public interface IHealth 
{
    float Current { get; }
    float Max { get; }
    void Set(float value);
    void Modify(float value);
}

