using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Algorithm
{
    public class Node
    {
        public string data;
        public Node left;
      public Node right;

      public Node(String data,Node left,Node right)
      {
          this.data = data;
          this.left=left;
          this.right=right;
      }  
      public Node(string data)
      {
          this.data=data;
          this.left=null;
          this.right=null;

      }

    }
}