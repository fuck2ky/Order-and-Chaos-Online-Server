using System;
using System.Collections.Generic;

namespace MMORPG.Source.Utils
{
    public class Config
    {
        private int _error = 0;
        private Dictionary<string, string> _values = new Dictionary<string, string>();

        public int Open(string filename)
        {
            _error = Parse(filename);
            return _error;
        }

        public int GetLastError()
        {
            return _error;
        }

        public string GetString(string section, string name, string defaultValue = "")
        {
            var key = MakeKey(section, name);
            string value;
            if (_values.TryGetValue(key, out value))
                return value;

            return defaultValue;
        }

        public long GetInteger(string section, string name, long defaultValue = 0)
        {
            long.TryParse(GetString(section, name), out defaultValue);
            return defaultValue;
        }

        private string MakeKey(string section, string name)
        {
            return $"{section}.{name}".ToLower();
        }

        private bool ValueHandler(string section, string name, string value)
        {
            _values.Add(MakeKey(section, name), value);
            return true;
        }

        private int Parse(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
