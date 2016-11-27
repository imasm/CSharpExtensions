using System;
using NUnitLite;

#if DNXCORE50
using NUnit.Common;
using System.Reflection;
#endif

namespace CSharpEx.NUnit.Tests
{
    public class Program
    {
        public static int Main(string[] args)
        {
#if DNXCORE50
            int result = new AutoRun(typeof(Program).GetTypeInfo().Assembly)
                .Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);
#else
            int result =  new AutoRun().Execute(args);
#endif
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            return result;
        }
    }
}
