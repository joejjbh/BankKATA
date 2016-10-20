using System.Collections.Generic;

namespace BankKata.Library
{
    public class CollectionOfDigitsAsLineStrings
    {
        public List<List<string>> _collection = new List<List<string>>();

        public List<List<string>> GetCollection()
        {
            return _collection;
        }

        public void AddLines(List<string> lines)
        {
            _collection.Add(lines);
        }


    }
}
