using StackExchange.Redis;

namespace ClassLibrary1
{
    public class Class1
    {
        public ConnectionMultiplexer GetMultiplexer() => ConnectionMultiplexer.Connect(new ConfigurationOptions());
    }
}
