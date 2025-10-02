namespace CleanArchitecture.Infrastructure.SmsProvider;

internal class SmsAdapter : ISmsAdapter
{
    private static AsyncRetryPolicy<Result> _retryPolicy;
    private static AsyncFallbackPolicy<Result> _fallbackPolicy;
    private static AsyncCircuitBreakerPolicy _circuitBreakerPolicy;

    private readonly HttpClient _httpClient;
    private const string url = "sms_provider_url";

    public SmsAdapter(IHttpClientFactory httpClientFactory)
    {

        _circuitBreakerPolicy = Policy
                                .Handle<Exception>()
                                .CircuitBreakerAsync(2, TimeSpan.FromMinutes(1));


        _retryPolicy = Policy<Result>
                        .Handle<Exception>()
                        .RetryAsync(2);


        _fallbackPolicy = Policy<Result>
                            .Handle<Exception>()
                            .FallbackAsync(Result.Failure("Error on Sending message"));


        _httpClient = httpClientFactory.CreateClient();
    }

    public async Task<Result> SendAsync(string receiver, string text)
    {
        var result = await _circuitBreakerPolicy.ExecuteAsync(async () =>
        {
            var content = new FormUrlEncodedContent(
            [
                new KeyValuePair<string, string>("receiver",receiver),
                new KeyValuePair<string, string>("text",text)
            ]);

            return await _httpClient.PostAsync(url, content);
        });

        if (result.IsSuccessStatusCode)
            return new();
        return new("Error on Sending message");
    }
}