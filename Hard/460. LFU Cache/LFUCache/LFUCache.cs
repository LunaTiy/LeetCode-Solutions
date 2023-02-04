namespace LFUCache;

public class LFUCache
{
    private readonly Dictionary<int, (int value, int frequency)> _cache;
    private readonly Dictionary<int, List<int>> _frequencies;
    private readonly int _capacity;
    private int _minFrequency;

    public LFUCache(int capacity)
    {
        _capacity = capacity;
        _cache = new Dictionary<int, (int value, int frequency)>(capacity);
        _frequencies = new Dictionary<int, List<int>>(capacity);
        _minFrequency = 0;
    }

    public int Get(int key)
    {
        if (!_cache.TryGetValue(key, out (int value, int frequency) valueFreqPair))
            return -1;

        int currentValue = valueFreqPair.value;
        int currentFreq = valueFreqPair.frequency;
        
        UpdateCache(key, currentValue, currentFreq);

        return currentValue;
    }

    public void Put(int key, int value)
    {
        if (_capacity <= 0)
            return;

        if (_cache.TryGetValue(key, out (int value, int frequency) valueFreqPair))
        {
            UpdateCache(key, value, valueFreqPair.frequency);
            return;
        }

        if (_cache.Count == _capacity)
        {
            var keys = _frequencies[_minFrequency];
            var keyToDelete = keys.ElementAt(0);

            _cache.Remove(keyToDelete);
            keys.Remove(keyToDelete);

            if (keys.Count == 0)
                _frequencies.Remove(_minFrequency);
        }

        _minFrequency = 1;
        Insert(key, value, 1);
    }

    private void UpdateCache(int key, int value, int frequency)
    {
        _frequencies[frequency].Remove(key);

        if (_frequencies[frequency].Count == 0)
        {
            _frequencies.Remove(frequency);

            if (_minFrequency == frequency)
                _minFrequency++;
        }

        Insert(key, value, frequency + 1);
    }

    private void Insert(int key, int value, int frequency)
    {
        _cache[key] = (value, frequency);
        
        if(!_frequencies.ContainsKey(frequency))
            _frequencies[frequency] = new List<int>();

        _frequencies[frequency].Add(key);
    }
}