using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview_v1
{
    abstract class Dequeue<T>
    {
        private List<T> _data;

        public Dequeue() { Data = new List<T>(); }

        protected List<T> Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        /// <summary>
        /// Pushes an object n to the front of the Dequeue
        /// </summary>
        /// <param name="n"></param>
        protected void pushFront(T n)
        {
            List<T> tmp = new List<T>();
            tmp.Add(n);
            tmp.AddRange(Data);
            Data = tmp;
        }

        /// <summary>
        /// Pushes an object n to the back of the Dequeue
        /// </summary>
        /// <param name="n"></param>
        protected void pushBack(T n)
        {
            Data.Add(n);
        }

        /// <summary>
        /// Pops the front object off of the Dequeue
        /// </summary>
        /// <returns></returns>
        protected T popFront()
        {
            T tmp = Data.ElementAt(0);
            Data.RemoveAt(0);
            return tmp;
        }

        /// <summary>
        /// Pops the back object off of the Dequeue
        /// </summary>
        /// <returns></returns>
        protected T popBack()
        {
            T tmp = Data.Last();
            Data.RemoveAt(Data.Count - 1);
            return tmp;
        }

        /// <summary>
        /// Returns the object at the front of the Dequeue
        /// </summary>
        /// <returns></returns>
        protected T peekFront()
        {
            return Data.ElementAt(0);
        }

        /// <summary>
        /// Returns the object at the back of the Dequeue
        /// </summary>
        /// <returns></returns>
        protected T peekBack()
        {
            return Data.ElementAt(Data.Count - 1);
        }

        /// <summary>
        /// Returns the number of elements in the Dequeue
        /// </summary>
        /// <returns></returns>
        protected int count()
        {
            return Data.Count;
        }
    }
}
