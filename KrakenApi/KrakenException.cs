using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KrakenApi
{
    [Serializable]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class KrakenException : Exception
    {
        public ResponseBase Response { get; }

        public KrakenException()
        {
        }

        public KrakenException(string message) : base(message)
        {
        }

        public KrakenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public KrakenException(string message, ResponseBase response) : base(message)
        {
            Response = response;
        }

        protected KrakenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("Response", Response);
            base.GetObjectData(info, context);
        }
    }
}