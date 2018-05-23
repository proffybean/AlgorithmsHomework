using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AlgorithmsHomework
{
    /// <summary>
    /// Write a class with a collection in it of strings (array, list, etc...)
    /// Make the class enumerable.  Test it with a foreach loop.
    /// 
    /// </summary>
    public class Students : IEnumerable
    {
        private string[] _names = new string[10];
        private int size = 0;

        public void AddName(string name)
        {
            _names[size++] = name;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _names.Length-1; i++)
            {
                if(string.IsNullOrEmpty(_names[i]))
                {

                    break;
                }

                yield return _names[i];
            }
        }
    }
}
