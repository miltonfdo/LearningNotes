
using System;

namespace Algorithm
{
    partial class Program
    {
        static void dfs_traversal(Node node)
        {
            if(node ==null) return;
            Console.Write(node.data + " ");
            dfs_traversal(node.left);
            dfs_traversal(node.right);


        }
    }
}