using RedisService;
using System;

namespace RedisClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisCacheProvider.Database().StringSet("name", "pfw");
            Console.WriteLine(RedisCacheProvider.Database().StringGet("name"));
            var points = RedisCacheProvider.Multiplexer().GetEndPoints();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
