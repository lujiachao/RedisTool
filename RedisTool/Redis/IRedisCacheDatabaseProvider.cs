﻿using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTool.Redis
{
    public interface IRedisCacheDatabaseProvider
    {
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        IDatabase GetDatabase();

        /// <summary>
        /// 再次注册连接
        /// </summary>
        /// <param name="actionEvent"></param>
        void RegisterReConnectionEvent(Action<IConnectionMultiplexer> actionEvent);
    }
}
