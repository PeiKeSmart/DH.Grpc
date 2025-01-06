using Grpc.Core;
using Grpc.Core.Interceptors;

using NewLife.Log;

namespace DH.Grpc;

public class GRPCInterceptor : Interceptor
{
    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
    {
        XTrace.Log.Debug($"[GRPCInterceptor.UnaryServerHandler]starting call");

        var response = await base.UnaryServerHandler(request, context, continuation).ConfigureAwait(false);

        XTrace.Log.Debug($"[GRPCInterceptor.UnaryServerHandler]finished call");

        return response;
    }
}