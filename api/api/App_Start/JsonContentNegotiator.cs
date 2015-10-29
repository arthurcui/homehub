using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;

namespace api
{
    public class JsonContentNegotiator : IContentNegotiator
    {
        private readonly JsonMediaTypeFormatter _jsonFormatter;
        private readonly MediaTypeHeaderValue _mediaTypeHeaderValue;

        public JsonContentNegotiator()
        {
            _jsonFormatter = new JsonMediaTypeFormatter();
            _mediaTypeHeaderValue = new MediaTypeHeaderValue("application/json");
        }

        public ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
        {
            return new ContentNegotiationResult(_jsonFormatter, _mediaTypeHeaderValue);
        }
    }
}