using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceStack.ServiceInterface.ServiceModel
{
    public abstract class AbstractWebServiceException : Exception
    {
        public AbstractWebServiceException() { }
        public AbstractWebServiceException(string message) : base(message) { }
        public AbstractWebServiceException(string message, Exception inner) : base(message, inner) { }

        public abstract int StatusCode { get; set; }
        public abstract string StatusDescription { get; set; }
        public abstract object ResponseDto { get; set; }
        public abstract string ResponseBody { get; set; }
        public abstract string ErrorCode { get; }
        public abstract string ErrorMessage { get; }
        public abstract string ServerStackTrace { get; }
        public abstract ResponseStatus ResponseStatus { get; }
    }
}
