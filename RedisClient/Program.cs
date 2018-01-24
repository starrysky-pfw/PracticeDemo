using RedisService;
using System;

namespace RedisClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisCacheProvider.RedisManager().GetDatabase().StringSet("name", "pfw");
            Console.WriteLine(RedisCacheProvider.RedisManager().GetDatabase().StringGet("name"));

            Console.WriteLine(RedisCacheProvider.RedisManager().GetDatabase().StringGet("requirepass"));

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
