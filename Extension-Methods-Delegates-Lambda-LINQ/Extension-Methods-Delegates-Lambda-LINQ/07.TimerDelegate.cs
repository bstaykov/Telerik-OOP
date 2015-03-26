namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Threading;

    public class Timer
    {
        // 07. Using delegates write a class Timer that can execute certain method at each t seconds.
        // the method that help to repeat other method after some time in some duration

        public delegate void MethodToExecute(string message);

        public static void RepeatSomeMethod(MethodToExecute method, int stepInSeconds, long durationInSeconds)
        {
            long start = 1;

            while (start <= durationInSeconds)
            {
                method("Seconds: " + start);
                Thread.Sleep(stepInSeconds * 1000);
                start += stepInSeconds;
            }
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
