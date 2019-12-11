using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpa_Task03_3
{
    class DynamicArray<T> : IList<T>
    {
        #region Fields and properties
        private T[] _elements; //main keeper of data
        private int _capacity; //main attribute fields for array to work with index
        private int _count = 0;

        public int Capacity => _capacity;
        public int Count => _count;
        #region Indexers
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count) //checking on index out of range exception
                    return _elements[index];
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Count) //checking on index out of range exception
                    _elements[index] = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion
        public bool IsReadOnly => false;
        #endregion

        #region GetEnumerator() 
        public IEnumerator<T> GetEnumerator() // Make Array Enumrable to use index
        {
            return new Enumerator<T>(_elements, _count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<T>(_elements, _count);
        }
        #endregion

        #region Constructors
        public DynamicArray()
        {
            _capacity = 8;
            _elements = new T[_capacity];
        }

        public DynamicArray(int capacity)
        {
            _capacity = capacity;
            _elements = new T[_capacity];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            int countCollection = 0;
            int index = 0;
            foreach (T item in collection)
            {
                countCollection++;
            }

            _elements = new T[countCollection];
            foreach (T item in collection)
            {
                _elements[index] = item;
                index++;
            }

            _count = _elements.Length;
            _capacity = _elements.Length;
        }
        #endregion

        #region private CapacityDoubling()
        private void CapacityDoubling()
        {
            //double the dimension
            _capacity *= 2;
            //Copy array
            T[] temp = new T[_capacity];
            Array.Copy(_elements, temp, _elements.Length);
            _elements = temp;
        }
        #endregion

        #region Add(T item)
        public void Add(T item)
        {
            if (_capacity > Count)
            {
                _elements[_count] = item;
            }
            else
            {
                this.CapacityDoubling();
                //Insert element
                _elements[_count] = item;
            }
            _count++;
        }
        #endregion

        #region Clear()
        public void Clear()
        {
            _elements = new T[_capacity];
            _count = 0;
        }
        #endregion

        #region Contains()
        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_elements[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region CopyTo(T[] array, int arrayIndex)
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex >= 0 && arrayIndex < Count)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = _elements[arrayIndex];
                    arrayIndex++;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region IndexOf(T item)
        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_elements[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Insert(int index, T item)
        public void Insert(int index, T item)
        {
            if (index > Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_capacity >= Count + 1)
            {
                for (int i = Count; i > index; i--)
                {
                    _elements[i] = _elements[i - 1];
                }
                _elements[index] = item;
            }
            else
            {
                this.CapacityDoubling();
                for (int i = Count; i > index; i--)
                {
                    _elements[i] = _elements[i - 1];
                }
                _elements[index] = item;
            }
            _count++;
        }
        #endregion

        #region Remove(T item)
        public bool Remove(T item)
        {
            if (this.Contains(item))
            {
                for (int i = this.IndexOf(item); i < Count - 1; i++)
                {
                    _elements[i] = _elements[i + 1];
                }
                _count -= 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region RemoveAt(int index)
        public void RemoveAt(int index)
        {
            if (index > 0 && index < Count)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _elements[i] = _elements[i + 1];
                }
                _count -= 1;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        #endregion

        #region AddRange(IEnumerable<T> collection)
        public void AddRange(IEnumerable<T> collection)
        {
            int countCollection = 0;
            foreach (T item in collection)
            {
                countCollection++;
            }

            if (_capacity < Count + countCollection)
            {
                _capacity = countCollection + _count;
            }

            T[] temp = new T[_capacity];
            Array.Copy(_elements, temp, _elements.Length);
            _elements = temp;

            int indexElements = Count;
            foreach (T item in collection)
            {
                _elements[indexElements] = item;
                indexElements++;
            }
            _count += countCollection;
        }

       
        #endregion
    }
}
