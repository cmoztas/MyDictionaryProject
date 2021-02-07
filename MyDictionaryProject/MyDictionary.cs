namespace MyDictionaryProject
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            IncreaseArraySize();

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        private void IncreaseArraySize()
        {
            ArrayManager<TKey>.IncreaseSize(ref _keys);
            ArrayManager<TValue>.IncreaseSize(ref _values);
        }

        public TValue GetValue(TKey key) => _values[ArrayManager<TKey>.Get(ref _keys, key)];

        public TKey GetKey(TValue value) => _keys[ArrayManager<TValue>.Get(ref _values, value)];

        public TValue[] GetAllValues() => _values;

        public TKey[] GetAllKeys() => _keys;

        public string[] GetAll()
        {
            string[] myArr = new string[_keys.Length];

            for (int i = 0; i < _keys.Length; i++)
            {
                myArr[i] = $"{_keys[i]}:{_values[i]}";
            }
            return myArr;
        }
    }
}