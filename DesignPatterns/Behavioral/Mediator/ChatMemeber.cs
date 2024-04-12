namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Mediator
{
    internal abstract class ChatMemeber
    {
        private IMediator mediator;
        public string Nick { get; set; }
        public IMediator Mediator
        {
            get => mediator;
            set
            {
                if (mediator != null)
                    mediator.Quit(this);
                mediator = value;
                if (mediator != null)
                    mediator.Join(this);
            }
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}