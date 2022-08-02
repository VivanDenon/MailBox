using System;
using System.Runtime.Serialization;

namespace Mail
{
    [Serializable]
    internal class MailClientExeption : Exception
    {
        public MailClientExeption()
        {
        }

        public MailClientExeption(string message) : base(message)
        {
        }

        public MailClientExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MailClientExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}