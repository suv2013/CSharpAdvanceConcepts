using System;

namespace EventsExample
{
    partial class Program
    {
        public class MessageService
        {
            public void OnComputed(object origin, EventArgs eventArgs)
            {
                Console.Write("Sending Message...\n");
            }
        }
    }
}
