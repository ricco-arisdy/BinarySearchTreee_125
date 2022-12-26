using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            public void insert(string element) //insert a node is the binary
            {
                node tmp, parent = null, currentnode = null;
                find(element, ref parent, ref currentnode);
                if (currentnode != null)
                {
                    Console.WriteLine("Duplicate word not allowed");
                    return;
                }
                
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
