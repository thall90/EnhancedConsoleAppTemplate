using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EnhancedConsole.Application.Infrastructure.Extensions
{
    internal static class ConsoleExtensions
    {
        internal static void WriteWithColor(
            string message,
            ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        internal static void WriteInfo(
            string message,
            Type declaringType = null)
        {
            WriteWithBackground(
                message,
                ConsoleColor.Black,
                ConsoleColor.White,
                declaringType);
        }

        internal static void WriteWarning(
            string message,
            Type declaringType = null)
        {
            WriteWithBackground(
                message,
                ConsoleColor.Black,
                ConsoleColor.DarkYellow,
                declaringType);
        }

        internal static void WriteError(
            string message,
            Type declaringType = null)
        {
            WriteWithBackground(
                message,
                ConsoleColor.Black,
                ConsoleColor.DarkRed,
                declaringType);
        }

        internal static void WriteSuccess(
            string message,
            Type declaringType = null)
        {
            WriteWithBackground(
                message,
                ConsoleColor.Black,
                ConsoleColor.Green,
                declaringType);
        }

        internal static void WriteWithBackground(
            string message,
            ConsoleColor backGroundColor,
            ConsoleColor foreGroundColor,
            Type declaringType = null)
        {
            var currentBackground = Console.BackgroundColor;
            var currentText = Console.ForegroundColor;

            Console.BackgroundColor = backGroundColor;
            Console.ForegroundColor = foreGroundColor;

            var consoleMessage = $"{message}";

            if (!string.IsNullOrWhiteSpace(declaringType?.Name))
            {
                consoleMessage = $"{declaringType?.Name} - {message}";
            }

            Console.WriteLine(consoleMessage);

            Console.BackgroundColor = currentBackground;
            Console.ForegroundColor = currentText;
        }

        internal static void WriteAfterDelay(
            string message,
            int delay)
        {
            Task.WaitAll(Task.Delay(delay));
            Console.Write(message);
        }

        internal static void PrintStartMessage(string operation)
        {
            WriteWithColor(
                $"Initializing Operations {operation}...\n",
                ConsoleColor.Magenta);
        }

        internal static void PrintExitMessage(string operation, int exitCode, Stopwatch watch)
        {
            var elapsedMinutes = watch.Elapsed.Minutes;
            var elapsedSeconds = watch.Elapsed.Seconds;

            if (exitCode != -1)
            {
                WriteWithColor(
                    $"\n{operation} Completed In: {elapsedMinutes}:{elapsedSeconds}.",
                    ConsoleColor.DarkGreen);
            }

            if (exitCode == -1)
            {
                WriteWithColor(
                    $"\n{operation} Failed After: {elapsedMinutes}:{elapsedSeconds}.",
                    ConsoleColor.DarkRed);
            }

#if DEBUG
            Console.WriteLine("Press Key");
            if (!Console.IsErrorRedirected && !Console.IsOutputRedirected)
            {
                Console.ReadKey();
            }
#endif
        }
    }
}