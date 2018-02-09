using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview_v1
{
    class Stack<T> : Dequeue<T>
    {
        public Stack() : base() { }

        /// <summary>
        /// Pops the last object that was added to the Stack
        /// </summary>
        /// <returns></returns>
        public T pop()
        {
            return this.popBack();
        }

        /// <summary>
        /// Pushes an object n onto the top of the Stack
        /// </summary>
        /// <param name="n"></param>
        public void push(T n)
        {
            this.pushBack(n);
        }

        /// <summary>
        /// Returns the top item of the Stack
        /// </summary>
        /// <returns></returns>
        public T peek()
        {
            return this.peekBack();
        }
    }
}
