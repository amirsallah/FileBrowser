using System;

namespace FileBrowser
{
    public class Controller
    {
        public static void PrintMenu()
        {
            Console.WriteLine(@"
=== BOOTCAMP SEARCH :: An extendable command-line search tool ===

1. Search for files
2. Manage Extensions
3. View search history

4.Exit");
        }
    }
}