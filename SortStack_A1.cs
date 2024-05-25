using System;
using System.Collections.Generic;
public class Program{
    public static void Main(string[] args){
        
        Stack<int> st = new Stack<int>();
        Stack<int> tp = new Stack<int>();
        st.Push(-5);
        st.Push(2);
        st.Push(-2);
        st.Push(4);
        st.Push(3);
        st.Push(1);
        
        foreach (int item in st)
        {
            Console.Write(item + " "); 
        }
        Console.WriteLine();
        tp.Push(st.Pop());
        while(st.Count > 0){            
            int ele = st.Pop();
            while(tp.Count >= 1 && tp.Peek() > ele){
                st.Push(tp.Pop());
            }
            tp.Push(ele);
        }

        foreach (int item in tp)
        {
            Console.Write(item + " "); 
        }

    }
}
