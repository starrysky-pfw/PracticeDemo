using RedisService;
using StackExchange.Redis;
using System;

namespace RedisClient
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string： set与get
            RedisCacheProvider.Database().StringSet("name", "pfw");
            Console.WriteLine(RedisCacheProvider.Database().StringGet("name"));
            #endregion

            #region hash  get与set
            RedisCacheProvider.Database().HashSet("userinfo", "name", "pfw");
            RedisCacheProvider.Database().HashSet("userinfo", "age", "24");

            var hashEntrys = new HashEntry[2] { new HashEntry("username", "starrysky"), new HashEntry("userage", "25") };
            RedisCacheProvider.Database().HashSet("userinfo", hashEntrys);
            var minfo = RedisCacheProvider.Database().HashGetAll("userinfo");
            #endregion

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
