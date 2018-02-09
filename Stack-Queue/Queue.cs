using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpReview_v1
{
    class Queue<T> : Dequeue<T>
    {
        public Queue() : base() { }

        /// <summary>
        /// Pops the first object in the Queue
        /// </summary>
        /// <returns></returns>
        public T pop()
        {
            return this.popFront();
        }

        /// <summary>
        /// Pushes an object n onto the back of the Queue
        /// </summary>
        /// <param name="n"></param>
        public void push(T n)
        {
            this.pushBack(n);
        }

        /// <summary>
        /// Returns the first element in the Queue
        /// </summary>
        /// <returns></returns>
        public T peek()
        {
            return this.peekFront();
        }
    }
}
