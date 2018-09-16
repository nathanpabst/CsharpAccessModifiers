using System;

namespace CsharpAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB b = new ClassB();
            b.PrintMessages();

            ClassC c = new ClassC();
            c.PrintMessages();
            Console.Read();
        }

        class ClassA
        {
            private int privateNum = 1;
            public int publicNum = 2;
            protected int protectedNum = 3;
        }

        //ClassB inherits from ClassA 
        //derived classes can access any public and protected fields in the parent class
        class ClassB : ClassA
        {
            public void PrintMessages()
            {
                //the publicNum field in ClassA is accessible to ClassB through inheritance 
                Console.WriteLine($"Output: {publicNum} is public access");
                //the protectedNum field in ClassA is accessible to ClassB through inheritance 
                Console.WriteLine($"Output: {protectedNum} is a protected field, but you can has because inheritance.");
                //the privateNum field is marked as private and is only accessible within ClassA
                Console.WriteLine($"You tried accessing a private field. No can has. Mind your business and whatnot.");
            }
        }

        class ClassC
        {
            //instantiating new ClassA object
            ClassA a = new ClassA();
            public void PrintMessages()
            {
                Console.WriteLine($"This class is not derived from ClassA, but Output: {a.publicNum} is a public field and can be accessed through instatiating the ClassA object.");
                Console.WriteLine("You cannot has this info! like never, ever. You think you can has private or protected info just because you instantiated the object? So wrong.");
            }
        }
    }
}
