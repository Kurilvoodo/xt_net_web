using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpa_Task03_3
{
    internal class Enumerator<T> : IEnumerator<T>
    {
        #region Fields and properties
        protected T[] _elements;
        protected int _index = 0;
        protected int _count = 0;
        public T Current
        {
            get
            {
                return _elements[_index++];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return _elements[_index++];
            }
        }

        
        #endregion

        #region ctor
        public Enumerator(T[] elements, int count)
        {
            _elements = elements;
            _count = count;
        }
        public Enumerator()
        {
            _elements = new T[0];
            _count = 0;
        }
        #endregion

        #region Dispose()
        protected bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed
                    _elements = null;
                }
                //dispose unmanaged
                disposed = true;
            }
        }
        ~Enumerator()
        {
            Dispose(false);
        }
        #endregion

        #region MoveNext()
        public bool MoveNext()
        {
            return _index >= 0 && _index < _count ? true : false;
        }
        #endregion

        #region Reset()
        public void Reset()
        {
            _index = 0;
        }
        #endregion
    }
}
