using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailVerteilerApp
{
    public class Configurator : IConfigurator
    {
        private readonly Dictionary<string, object> _items = new();

        public TItem Get<TItem>(string key, TItem defaultValue)
        {
            var exist = _items.ContainsKey(key);
            if (!exist)
            {
                return defaultValue;
            }

            return (TItem)_items[key];
        }

        public void Set(string key, object value)
        {
            _items[key] = value;
        }
    }
}
