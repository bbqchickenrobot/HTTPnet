﻿namespace HTTPnet.Core.Http
{
    public class HttpServerOptions
    {
        public int Port { get; set; } = 80;

        public int MaxUriLength { get; set; } = 2000;

        public bool NoDelay { get; set; } = true;

        public int ReceiveBufferSize { get; set; } = 4096;

        public int Backlog { get; set; } = 10;

        public int SendBufferSize { get; set; } = 81920;

        public int ReceiveChunkSize { get; set; } = 8 * 1024; // 8 KB

        public IHttpRequestHandler RequestHandler { get; set; }
    }
}
