using System;

class Program{
    static int Main(string[] args){
        
        //This are the my first C# lines of code
        // Console.WriteLine("Hello world!!");
        // for (var n = 0; n < args.Length; n++){
        //     Console.WriteLine("arg[{0}] = {1}",n,args[n]);
        // }
        // return 0;
        
        // F# language test for checking reliability of C#
        // var a = 30;
        // var b = 12;
        // var sum = fscalc.Calculator.Add(a,b);

        // System.Console.WriteLine($"{a} + {b} = {sum}");

        var pt = new Point {X = 30, Y = 12};
        System.Console.WriteLine(pt.ToString());

        var numbers = new int[] {1,2,3,4,5};
        var type = numbers.GetType();

        do{
            System.Console.WriteLine(type.FullName);
            type = type.BaseType;
        }
        while(type!=null);
     return 0;
     }   
}