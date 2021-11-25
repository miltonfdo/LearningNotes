using System;
using System.Collections.Generic;
namespace Practice{
public static void Main(string[] args)
{
    
}
static bool isMatchingBrackets(char[] list){

    Stack<char> st = new Stack<char>();
    for(int i=0;i<list.Length;i++){
        if(list[i]=='('||list[i]=='['||list[i]=='{'){
            st.Push(list[i]);
        }
        else if (list[i]==')'||list[i]==']'||list[i]=='}'){
            if(st.Count==0)
            {
                  return false;
            }
            else
            {

            }


        }
        }
        return true;
}
public class Stack{
    public int top=-1;
    char[] item= new char[100];
    public void Push(char x){
        if(top==99){
            Console.WriteLine("Oveflow");
        }
        else{
            item[top]=x;
            top++;
        }

    }
    public char pop(char x){
          if(top==-1){
            Console.WriteLine("underflow");
        }
        else{
            char element= item[top];
            top--;
            return element;
        }

        return'\0';

    }
}
}