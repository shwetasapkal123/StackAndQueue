using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
     public class Node
    {
        public int data;
        public Node next;    //bcz linked list node consist of key(data) and next......next will store the next element   
        //Constructor
        public Node(int data)
        {
            this.data = data;
        }
    }
}
