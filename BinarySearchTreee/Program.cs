using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreee
{
    class node
    {
        public string info;
        public node lchild;
        public node rchild;

        //consturctor for the node class

        public node(string i, node l, node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }

        class BinaryThreee
        {
            public node ROOT;

            public BinaryThreee()
            {
                ROOT = null; //initializing root to null  
            }
        }
    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
        }
    }
}
