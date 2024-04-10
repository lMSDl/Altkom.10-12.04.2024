namespace Altkom._10_12._04._2024.SOLID
{
    public class SMS : IMessage
    {
        public required string Number { get; set; }
        public required string Content { get; set; }

        public void SendMessage()
        {
            SendSms();
        }

        public void SendSms()
        {
            Console.WriteLine("Sending SMS..");
        }
    }

    public class Email : IMessage
    {
        public required string Number { get; set; }
        public required string Subject { get; set; }
        public required string Content { get; set; }

        public void SendEmail()
        {
            Console.WriteLine("Sending email..");
        }
        public void SendMessage()
        {
            SendEmail();
        }

    }

    public class MMS : IMessage
    {

        public required string Number { get; set; }
        public required byte[] Content { get; set; }

        public void SendMms()
        {
            Console.WriteLine("Sending MMS..");
        }
        public void SendMessage()
        {
            SendMms();
        }
    }

    public interface IMessage
    {
        void SendMessage();
    }


    public class Messanger
    {
        public IEnumerable<IMessage> Services { get; set; }

        public Messanger(IEnumerable<IMessage> services)
        {
            Services = services;
        }

        public void SendMessage(IEnumerable<IMessage> services)
        {
            Services = services;
            SendMessage();
        }

        public void SendMessage()
        {
            if (Services != null)
            {
                foreach (IMessage item in Services)
                {
                    item.SendMessage();
                }
            }
        }
    }


    /*class SMS
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    class MMS
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    class Mail
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
    }

    class Messenger
    {
        public SMS SMS { get; set; }
        public MMS MMS { get; set; }
        public Mail Mail { get; set; }


        public void SendMessage()
        {
            SMS.SendSMS();
            MMS.SendMMS();
            Mail.SendMail();
        }
    }*/
}
