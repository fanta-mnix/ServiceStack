using System.Collections.Generic;
using System.Net;

#if PCL
using HttpStatusCode = ServiceStack.ServiceHost.HttpStatusCode;
#endif

namespace ServiceStack.ServiceHost
{
#if PCL
	public enum HttpStatusCode
	{
		Accepted = 202,
		Ambiguous = 300,
		BadGateway = 502,
		BadRequest = 400,
		Conflict = 409,
		Continue = 100,
		Created = 201,
		ExpectationFailed = 417,
		Forbidden = 403,
		Found = 302,
		GatewayTimeout = 504,
		Gone = 410,
		HttpVersionNotSupported = 505,
		InternalServerError = 500,
		LengthRequired = 411,
		MethodNotAllowed = 405,
		Moved = 301,
		MovedPermanently = 301,
		MultipleChoices = 300,
		NoContent = 204,
		NonAuthoritativeInformation = 203,
		NotAcceptable = 406,
		NotFound = 404,
		NotImplemented = 501,
		NotModified = 304,
		OK = 200,
		PartialContent = 206,
		PaymentRequired = 402,
		PreconditionFailed = 412,
		ProxyAuthenticationRequired = 407,
		Redirect = 302,
		RedirectKeepVerb = 307,
		RedirectMethod = 303,
		RequestedRangeNotSatisfiable = 416,
		RequestEntityTooLarge = 413,
		RequestTimeout = 408,
		RequestUriTooLong = 414,
		ResetContent = 205,
		SeeOther = 303,
		ServiceUnavailable = 503,
		SwitchingProtocols = 101,
		TemporaryRedirect = 307,
		Unauthorized = 401,
		UnsupportedMediaType = 415,
		Unused = 306,
		UseProxy = 305
	}
#endif
	public interface IHttpResult : IHasOptions
	{
        /// <summary>
        /// The HTTP Response Status
        /// </summary>
        int Status { get; set; }

		/// <summary>
		/// The HTTP Response Status Code
		/// </summary>
		HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// The HTTP Status Description
        /// </summary>
        string StatusDescription { get; set; }

		/// <summary>
		/// The HTTP Response ContentType
		/// </summary>
		string ContentType { get; set; }

		/// <summary>
		/// Additional HTTP Headers
		/// </summary>
		Dictionary<string, string> Headers { get; }

		/// <summary>
		/// Response DTO
		/// </summary>
		object Response { get; set; }

		/// <summary>
		/// if not provided, get's injected by ServiceStack
		/// </summary>
		IContentTypeWriter ResponseFilter { get; set; }

		/// <summary>
		/// Holds the request call context
		/// </summary>
		IRequestContext RequestContext { get; set; }
	}
}