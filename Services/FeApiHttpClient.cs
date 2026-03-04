using System;
using smz3.countdown.wasm.Constants;

namespace smz3.countdown.wasm;

public class FeApiHttpClient : HttpClient
{
    public FeApiHttpClient()
    {
        BaseAddress = new Uri(EndpointConstants.API_BASE_ADDRESS);
    }

    public FeApiHttpClient(SocketsHttpHandler handler) : base(handler)
    {
        BaseAddress = new Uri(EndpointConstants.API_BASE_ADDRESS);
    }
}
