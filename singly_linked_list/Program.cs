using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singly_linked_list
{
    // each node consist of the information part and lik to to the next mode

    class node
    {
        public int rollNumber;
        public string name;
        public node next;
    }
    class List
    {
        node START;

        public List()
        {
            START = null;
        }

    }
}
