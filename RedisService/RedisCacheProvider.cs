using System;
using StackExchange.Redis;

namespace RedisService
{
    public class RedisCacheProvider
    {
        static ConnectionMultiplexer connectionMultiplexer;

        public static ConnectionMultiplexer Multiplexer()
        {
            if (connectionMultiplexer == null || !connectionMultiplexer.IsConnected)
            {
                connectionMultiplexer = ConnectionMultiplexer.Connect(new ConfigurationOptions() { EndPoints = { { "127.0.0.1", 6379 }, { "192.168.0.13", 6379 } } }); //, Password = "pfwredis" 
            }
            return connectionMultiplexer;
        }

        public static IDatabase Database(int db = -1)
        {
            return Multiplexer().GetDatabase(db);
        }
    }
}
