using System;
using StackExchange.Redis;

namespace RedisService
{
    public sealed class RedisCacheProvider
    {
        static ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect(new ConfigurationOptions() { EndPoints = { { "127.0.0.1", 6379 }, { "192.168.0.13", 6379 } } }); //, Password = "pfwredis" 

        public static IDatabase Database(int db = -1)
        {
            return connectionMultiplexer.GetDatabase(db);
        }
    }

    public class StructDemo
    {
        public void Num()
        {
            StuctProvider provider = new StuctProvider();
            provider.X = 25;
        }
    }

    /// <summary>
    /// 结构
    /// 结构是值类型 存储在堆栈上 性能高   多用于值计算
    /// </summary>
    public struct StuctProvider
    {
        public int X;

        public static Int64 GetNum(int num)
        {
            return num * 10;
        }
    }
}
