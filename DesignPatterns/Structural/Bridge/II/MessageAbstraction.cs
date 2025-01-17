﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Bridge.II
{
    internal class MessageAbstraction
    {
        protected IMessageSenderImplementation MessageSender { get; }

        public MessageAbstraction(IMessageSenderImplementation messageSender)
        {
            MessageSender = messageSender;
        }


        public virtual void Send(string message)
        {
            MessageSender.SendMessage(message);
        }
    }
}
