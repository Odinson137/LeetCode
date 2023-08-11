using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode42;

public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        Stack<int> stack = new Stack<int>();
        bool[] bools = new bool[rooms.Count];
        stack.Push(0);

        while (stack.Count > 0)
        {
            int key = stack.Pop();

            if (bools[key] == false)
            {
                bools[key] = true;
                IList<int> room = rooms[key];

                foreach (int k in room)
                {
                    stack.Push(k);
                }
            }
        }

        return bools.All(x => x);
    }
}
