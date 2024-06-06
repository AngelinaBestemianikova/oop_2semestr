using lab4_5.Models;
using System.Collections.Generic;

namespace lab4_5
{
    public class Memory
    {
        private List<List<Product>> _memory = new List<List<Product>>();
        private int _memoryIndex = -1;

        public void Add(List<Product> listOfProducts)
        {
            _memory.Add(listOfProducts);
            _memoryIndex++;
        }

        public List<Product> Forward()
        {
            if (_memoryIndex < _memory.Count - 1)
            {
                _memoryIndex++;
            }

            return _memory[_memoryIndex];
        }

        public List<Product> Back()
        {
            if (_memoryIndex > 0)
            {
                _memoryIndex--;
            }

            return _memory[_memoryIndex];
        }
    }
}
