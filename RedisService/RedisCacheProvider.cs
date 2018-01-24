using System;
using StackExchange.Redis;

namespace RedisService
{
    public class RedisCacheProvider
    {
        static ConnectionMultiplexer connectionMultiplexer;

        public static ConnectionMultiplexer RedisManager()
        {
            if (connectionMultiplexer == null || !connectionMultiplexer.IsConnected)
            {
                connectionMultiplexer = ConnectionMultiplexer.Connect(new ConfigurationOptions() { EndPoints = { { "127.0.0.1", 6379 } }, Password = "pfwredis" }); //, Password = "pfwredis" 
            }
            return connectionMultiplexer;
        }
    }

    public class RedisService
    {
        private int db = 0; //默认数据库

        public RedisService DB(int db)
        {
            RedisCacheProvider.RedisManager().GetDatabase(db);
            return this;
        }


        public void SetStr()
        {
            RedisCacheProvider.RedisManager().GetDatabase().StringSet("", "", TimeSpan.FromSeconds(100));
        }
    }
}
