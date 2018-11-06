using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search_tree
{
    class BSTree
    {
        Node _root;

        

        //void Delete(root) { }

        //bool Search(Node root) {}

        //int FindMinimum(int root) { }

        public Tree(List<int> input_Values)
        {
            _root = null;
        }

        public Tree(int initial)
        {
            _root = new Node(initial)
        }

        public void insert(int value)
        {
            if (_root = null)
            {
                Node NewNode = new Node(value);
                _root = NewNode;
                return;
            }
            Node currentNode = _root;
            bool added = false;
            do
            {
                if (value < currentNode.value)
                {
                    currentNode.left = value
                }
                else (){
                    currentNode.right= value
                }
            }
        }
    }
}
