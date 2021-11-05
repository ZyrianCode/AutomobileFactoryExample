using System.Collections.Generic;
using InputHelpers.Zyrian.MessagesRepositories;
using InputHelpers.Zyrian.Providers.MessageProviders.Options;

namespace InputHelpers.Zyrian.Providers.MessageProviders.Base
{
    public class MessagesProvider
    {
        private readonly MessageRepository _messageRepository = new();

        public List<string> ProvideMessages(ProviderOptions providerOptions) => 
            _messageRepository.AllMessages[(int)providerOptions];
    }
}
