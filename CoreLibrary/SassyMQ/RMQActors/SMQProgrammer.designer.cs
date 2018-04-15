using System;
using System.Linq;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.MessagePatterns;
using SassyMQ.Lib.RabbitMQ;
using SassyMQ.AAT.Lib.RabbitMQ;
using SassyMQ.Lib.RabbitMQ.Payload;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SassyMQ.AAT.Lib;
using CoreLibrary.SassyMQ;

namespace SassyMQ.AAT.Lib.RMQActors
{
    public partial class SMQProgrammer : AATActorBase
    {
     
        public SMQProgrammer(bool isAutoConnect = true)
            : base("programmer.all", isAutoConnect)
        {
        }
        // AirtableApplicantTracking - AAT
        public virtual bool Connect(string virtualHost, string username, string password)
        {
            return base.Connect(virtualHost, username, password);
        }   

        protected override void CheckRouting(AATPayload payload) 
        {
            this.CheckRouting(payload, false);
        }

        partial void CheckPayload(AATPayload payload);

        private void Reply(AATPayload payload)
        {
            if (!System.String.IsNullOrEmpty(payload.ReplyTo))
            {
                payload.DirectMessageQueue = this.QueueName;
                this.CheckPayload(payload);
                this.RMQChannel.BasicPublish("", payload.ReplyTo, body: Encoding.UTF8.GetBytes(payload.ToJSonString()));
            }
        }

        protected override void CheckRouting(AATPayload payload, bool isDirectMessage) 
        {
            // if (payload.IsDirectMessage && !isDirectMessage) return;

            try {
                
             if (payload.IsLexiconTerm(LexiconTermEnum.world_wassup_programmer)) 
            {
                this.OnWorldWassupReceived(payload);
            }
        
            } catch (Exception ex) {
                payload.Exception = ex;
            }
            this.Reply(payload);
        }

        
        /// <summary>
        /// Responds to: Wassup - 
        /// </summary>
        public event System.EventHandler<PayloadEventArgs<AATPayload>> WorldWassupReceived;
        protected virtual void OnWorldWassupReceived(AATPayload payload)
        {
            this.LogMessage(payload, "Wassup - ");
            var plea = new PayloadEventArgs<AATPayload>(payload);
            this.Invoke(this.WorldWassupReceived, plea);
        }
        
        /// <summary>
        /// Hello - 
        /// </summary>
        public void ProgrammerHello() 
        {
            this.ProgrammerHello(this.CreatePayload());
        }

        /// <summary>
        /// Hello - 
        /// </summary>
        public void ProgrammerHello(System.String content) 
        {
            var payload = this.CreatePayload();
            payload.Content = content;
            this.ProgrammerHello(payload);
        }

        /// <summary>
        /// Hello - 
        /// </summary>
        public void ProgrammerHello(AATPayload payload)
        {
            
            this.SendMessage(payload, "Hello - ",
            "programmermic", "world.general.programmer.hello");
        }


        
        /// <summary>
        /// Goodbye - 
        /// </summary>
        public void ProgrammerGoodbye() 
        {
            this.ProgrammerGoodbye(this.CreatePayload());
        }

        /// <summary>
        /// Goodbye - 
        /// </summary>
        public void ProgrammerGoodbye(System.String content) 
        {
            var payload = this.CreatePayload();
            payload.Content = content;
            this.ProgrammerGoodbye(payload);
        }

        /// <summary>
        /// Goodbye - 
        /// </summary>
        public void ProgrammerGoodbye(AATPayload payload)
        {
            
            this.SendMessage(payload, "Goodbye - ",
            "programmermic", "world.general.programmer.goodbye");
        }


        

        
        public void LogMessage(AATPayload payload, System.String msg)
        {
            if (IsDebugMode)
            {
                System.Diagnostics.Debug.WriteLine(msg);
                System.Diagnostics.Debug.WriteLine("payload: " + payload.SafeToString());
            }
        }
        
    }
}

                    