using System;

namespace HttpRequestTester.Model
{
    public class HttpGet
    {
        public string Url { get; set; }

        public string Response { get; set; }

        public DateTime RequestDateTime { get; set; }

        public DateTime ResponseDateTime { get; set; }

        public int? ResponseTime { get; set; }

        public bool IsSuccess { get; set; }
    }
}
