using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHarpQuizConsole
{
    public class CSharpQuestionAndAnswer
    {
        public List<string> questionsList = new List<string>
        {
            "What is C#?",
            "What is type-safe?",
            "What is a managed language?",
            "What is Intermediate Language?",
            "What is the Big-O Notation?",
        };

        public List<string> answerListCorrect = new List<string>
        {
            "C# is an object oriented, type safe, and managed language that is compiled by .NET framework to generate Microsoft Intermediate Language.", // 
            "Type-safe is when the compiler throws an error if you try to assign the wrong type to a variable e.g 'int x = 5; x = 'test';' this will fail because we are assigning a alphabetic string to" +
            " type int", //
            "A managed language, is when the CLR(Common Language Runtime) that manages execution of .NET programs, is managed by the GC(Garbage Collector). This includes error handling, memory management etc, " +
            "instead of being handled by the OS(Operation System). You will get Intermediate Language code when the program compiles.", //
            "Intermediate language is a language read by the compiler, and is a product of high level language compilation. Once done it is then optimizes, then translated to machine code(assembly).", //
            "Big O notation is used in Computer Science to describe the performance or complexity of an algorithm. Big O specifically describes the worst-case scenario, and can be used to describe the " +
            "execution time required or the space used (e.g. in memory or on disk) by an algorithm.", //
        };

        public List<string> answerListIncorrect1 = new List<string>
        {
            "C# is an procedural programming, type safe, and non-managed language that is compiled by .NET framework to generate Microsoft Intermediate Language.", //
            "Type-safe is when the compiler throws an warning if you try to assign the wrong type to a variable e.g var x = 5; x = 10;' this will fail because we are assigning are assigning a numerical value" +
            " without declaring as an  int", //
            "A managed language, is when the CLR(Common Language Runtime) that manages execution of .NET programs, is managed by the OS. This includes error handling memory management  etc, " +
            "instead of being handled by a GC (Garbage Collector).", //
            "Intermediate language is a language read by the OS, and is a product of high level language compilation. Once done it is then optimizes, then translated to machine code(assembly).", //
            "Big O notation is used in Computer Science to describe the power of an application. Big O specifically determines how much RAM a computer can store", //
        };

        public List<string> answerListIncorrect2 = new List<string>
        {
            "C# is an object oriented, type safe, and unmanaged language that is directly executed by OS, and is compiled by .NET framework to generate Microsoft Intermediate Language.", //
            "Type-safe is when the OS throws an error if you try to assign the wrong type to a variable e.g 'int x = 5; x = 'test';' this will fail because we are assigning a alphabetic string to type int", //
            "A managed language, is when the language is being managed by a specific individual", //
            "Intermediate language is a language read by the compiler, and is a product of low level language compilation. Once done it is then optimizes, then translated to machine code(assembly).", //
            "Big O notation is used in Computer Science to describe the level of a language, which can be a high level language or a low level language that directly communicates with the OS ", //
        };

        public List<string> answerListIncorrect3 = new List<string>
        {
            "C# is a markup, type safe, and managed language that is compiled by .NET framework to generate Microsoft Intermediate Language.", //
            "Type-safe means a design pattern that implements safe practices when typing up variables.", //
            "A managed language, is when the CLR(Common Language Runtime) that manages execution of .NET programs, is managed by the GC(Garbage Collector). This includes error handling  etc but exludes " +
            "memory management instead of being handled by the OS(Operation System). You get machine code when the program compiles.", //
            "Intermediate language is a language read by the compiler, and is a product of low level language compilation. Once done it is then optimizes, then translated to high level code.", //
            "Big O notation is used in Computer Science to describe the performance or complexity of an algorithm. Big O specifically describes the best-case scenario, and can be used to describe and measure" +
            "the amount of data being processed using algorithms.", //
        };

    }
}
