using System;

namespace EventsExample
{
    partial class Program
    {
        public class MailService
        {
            public void OnComputed(object origin, EventArgs eventArgs)
            {
                Console.Write("Sending Email...\n");
            }
        }
    }
}
