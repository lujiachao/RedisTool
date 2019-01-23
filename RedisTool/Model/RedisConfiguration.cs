using RedisTool.Model.EntityHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTool.Model
{
    [Model("RedisConfiguration")]
    public static class RedisConfiguration
    {
        public static string ServiceName
        {
            get; set;
        }

        public static string ConnectionString
        {
            get; set;
        }

        public static int DatabaseId
        {
            get; set;
        }

        public static int SyncTimeOut
        {
            get; set;
        }

        public static string Password
        {
            get; set;
        }
    }
}
