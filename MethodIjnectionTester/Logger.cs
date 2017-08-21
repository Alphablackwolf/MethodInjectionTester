using System;

namespace MethodIjnectionTester
{
    /// <summary>
    /// A wrapper for the Stardew Valley logger to simplify the interface and restrict what is logged.
    /// </summary>
    public static class Logger
    {
        public static void LogTrace(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogVerbose(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogInformation(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogWarning(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogError(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogCritical(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogCriticalWarning(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogDisplay(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogOptionsError(string message)
        {
            Console.WriteLine(message);
        }
    }
}
