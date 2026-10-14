using System;

public class Program
{
    static public void Main ()
    {
       
 Console.WriteLine("-- OR -> AND -> AND --");
       
Console.WriteLine((false || false) && (false && false));
  Console.WriteLine((true || false) && (true && false)); 
   Console.WriteLine((false || true) && (false && true));  
   Console.WriteLine((true || true) && (true && true));
        
       
 Console.WriteLine("-- AND -> NOT -> OR--");
 Console.WriteLine((false && false) || !(false));
 Console.WriteLine((true && false) || !(true)); 
 Console.WriteLine((false && true) || !(false));  
   Console.WriteLine((true && true) || !(true));
   
    }
}
