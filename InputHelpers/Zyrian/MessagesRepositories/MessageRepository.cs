using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputHelpers.Zyrian.Providers;

namespace InputHelpers.Zyrian.MessagesRepositories
{
    /// <summary>
    /// Хранитель сообщений для вывода.
    /// </summary>
    /// <remarks> Хранит сообщения для вывода в консоль. Для каждого типа действий предусмотрены свои сообщения. </remarks>
    public sealed class MessageRepository
    {
        public List<List<string>> AllMessages = new();

        private void ConfigureAllMessages()
        {
            AllMessages.Add(_configuringEngineMessages);
            AllMessages.Add(_configuringWheelsMessages);
            AllMessages.Add(_configuringWheelsBundleMessages);
            AllMessages.Add(_configuringTransmission);
            AllMessages.Add(_configuringSpeedRange);
        }

        public MessageRepository()
        {
            ConfigureAllMessages();
        }

        private readonly List<string> _configuringEngineMessages = new()
        {
            new string("Введите наименование двигателя: "),
            new string("Введите тип двигателя: "),
            new string("Введите количество цилиндров: ")
        };

        private readonly List<string> _configuringWheelsMessages = new()
        {
            new string("Введите наименование колёс: ")
        };

        private readonly List<string> _configuringWheelsBundleMessages = new()
        {
            new string("Введите наименование пакета колёс: ")
        };

        private readonly List<string> _configuringTransmission = new()
        {
            new string("Введите наименование трансмиссии: ")
        };

        private readonly List<string> _configuringSpeedRange = new()
        {
            new string("Введите максимальную скорость: ")
        };
    }
}
