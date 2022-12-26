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
                else //is the spesific node is note present
                {
                    tmp = new node(element, null, null);
                    if(parent == null)
                    {
                        ROOT = tmp;
                    }
                    else if (string.Compare(element,parent.info) <0)
                    {
                        if (string.Compare(element, parent.info) < 0)
                            parent.lchild = tmp;
                    }
                    else
                    {
                        parent.rchild = tmp;
                    }
                }
            }

            private void find(string element, ref node parent, ref node currentnode)
            {
                currentnode = ROOT;
                parent = null;
                while ((currentnode != null) && (currentnode.info != null))
                {
                    parent = currentnode;
                    if (string.Compare(element, parent.info) < 0)
                        currentnode = currentnode.rchild;
                    else
                        currentnode = currentnode.lchild;
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
