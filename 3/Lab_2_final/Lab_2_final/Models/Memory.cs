using System.Collections.Generic;

namespace Lab_2_final.Models
{
    public class Memory
    {
        private List<List<Student>> _memory = new List<List<Student>>();
        private int _memoryIndex = -1;

        public void Add(List<Student> listOfStudents)
        {
            _memory.Add(listOfStudents);
            _memoryIndex++;
        }

        public List<Student> Forward()
        {
            if (_memoryIndex < _memory.Count - 1)
            {
                _memoryIndex++;
            }

            return _memory[_memoryIndex];
        }

        public List<Student> Back()
        {
            if (_memoryIndex > 0)
            {
                _memoryIndex--;
            }

            return _memory[_memoryIndex];
        }
    }
}
