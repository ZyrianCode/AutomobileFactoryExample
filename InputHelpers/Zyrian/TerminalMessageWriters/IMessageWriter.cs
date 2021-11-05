using System.Collections.Generic;

namespace InputHelpers.Zyrian.TerminalMessageWriters
{
    public interface IMessageWriter
    {
        public void SetListOfMessages(List<string> messagesToWrite);
        public IEnumerable<string> ShowMessages();
    }
}
