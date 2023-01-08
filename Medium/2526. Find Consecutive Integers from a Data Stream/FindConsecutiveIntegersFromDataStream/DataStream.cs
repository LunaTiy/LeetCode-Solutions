namespace FindConsecutiveIntegersFromDataStream;

public class DataStream
{
    private int _value;
    private int _k;
    private int _countValue;

    public DataStream(int value, int k)
    {
        _value = value;
        _k = k;
    }
    
    public bool Consec(int num)
    {
        if (num == _value)
            _countValue++;
        else
            _countValue = 0;

        return _countValue >= _k;
    }
}