

using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.MessagePatterns;
using SassyMQ.Lib.RabbitMQ;
using SassyMQ.AAT.Lib.RabbitMQ;
using SassyMQ.Lib.RabbitMQ.Payload;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SassyMQ.AAT.Lib.RMQActors;

namespace SassyMQ.AAT.Lib
{
    public abstract class AATActorBase : SMQActorBase<AATPayload> 
    {
        public AATActorBase(string allExchange, bool isAutoConnect) : base(allExchange, isAutoConnect)
        {
        }
    }
}