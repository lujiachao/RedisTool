using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTool.Redis
{
    public interface IRedisCacheSerializer
    {
        T Deserialize<T>(RedisValue objbyte);

        string Serialize(object value, Type type);
    }
}
