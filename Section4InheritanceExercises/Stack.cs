using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4InheritanceExercises
{
    class Stack
    {
        private List<object> stk = new List<object>();

        public void Push(object obj)
        {
            if (obj is null)
            {
                throw new System.InvalidOperationException("Can not push null.");
            }
            stk.Add(obj);
        }
        public object Pop()
        {
            if (stk.Count > 0)
            {
                var lastItem = stk.Last();
                stk.RemoveAt(stk.LastIndexOf(lastItem));
                return lastItem;
            }
            throw new System.InvalidOperationException("Can not pop on empty stack.");
        }
        public void Clear()
        {
            stk.Clear();
        }
    }
}
