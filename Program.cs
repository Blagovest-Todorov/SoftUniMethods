using System;

namespace _01.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            PrintHelloWorld(); // invoking-calling the method !
            PrintText("HelloWorld@", 10 );
            PrintStudent("Anatoli", 50, 5.67);
            PrintText("Здравсти Пешо ", 55);
            
        }
        static void PrintHelloWorld() 
        {
            Console.WriteLine("Hello World"); // this is mehod definition 
            // method-block of code that can be performed multiple times,avoid repeating the code,resusage of the code,//
            // better maintenance,meanageble , the code becomes understandable -> the application is split into small pieces., better readability
            // void, -> method returns noting, no value, returns empty thing.// maitainability
            // static -> not changeable, can be used directly, accessed through the class only
            // here acts the principle dry --dont repeat yourself !
            // does not have a word -> return !!! so it does not return a result !
            // Methods are defined inside the class ! declare != defining! 
            //static main -can execute call only static methods !
            // variables into methods are local, its life is from opening { till closing } of the block of the code declared.

        }
        static void PrintText(string text, int num)   // declaring methods 
        {
            Console.WriteLine(num);
            // Methods can be called, invoked with thier name + ();
            // the method can be  alled into Main method, or into other method, can be called fron itself into his body--rescursion ! 
            // a method calls itself into his body !
            // Methods with parameters
            
        }
        static void PrintStudent(string name,
                                 int age,
                                 double grade) 
        {
            //Console.WriteLine("Student: {0}, Age: {1}, Grade : {2}", name, age, grade );
            Console.WriteLine($"Student: {name}, Age: {age}, Grade : {grade}");
            // Methods mane must be selfExplainng, , what the method does !, one method shour do only one thing ! 
        }
    }
}
