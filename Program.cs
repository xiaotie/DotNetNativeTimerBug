using System;
using System.Runtime.InteropServices;

namespace DotNetNative
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Win32DlgTest.Test();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadKey();
        }
    }
}
