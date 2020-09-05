public class LRUCache
    {
        // https://leetcode.com/problems/lru-cache/

        private readonly List<KeyValuePair<int, int>> _lru;
        private readonly int _capacity;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _lru =  new List<KeyValuePair<int, int>>();
        }

        public int Get(int key)
        {
            var index = _lru.FindIndex(x => x.Key == key);
            if (index == -1)
                return -1;

            var value = _lru[index].Value;

            _lru.RemoveAt(index);
            _lru.Insert(0, new KeyValuePair<int, int>(key, value));

            return value;
        }

        public void Put(int key, int value)
        {
            var index = _lru.FindIndex(x => x.Key == key);
            if (index != -1)
                _lru.RemoveAt(index);

            _lru.Insert(0, new KeyValuePair<int, int>(key, value));

            if(_lru.Count > _capacity)
                _lru.RemoveAt(_lru.Count-1);
        }
    }
