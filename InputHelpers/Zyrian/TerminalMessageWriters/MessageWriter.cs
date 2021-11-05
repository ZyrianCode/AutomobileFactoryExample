using System;
using System.Collections.Generic;

namespace InputHelpers.Zyrian.TerminalMessageWriters
{
    public class MessageWriter : IMessageWriter
    {
        private List<string> _messages;

        public void SetListOfMessages(List<string> messagesToWrite) => _messages = messagesToWrite;

        public IEnumerable<string> ShowMessages()
        {
            foreach (var message in _messages)
            {
                Console.WriteLine(message);
                yield return Console.ReadLine();
            }
        }
    }
}
