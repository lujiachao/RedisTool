using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using RedisTool.Model;
using System.Configuration;
using System;
using RedisTool.Redis;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RedisTool
{
    public partial class RedisTool : Form
    {
        private static Lazy<RedisCache> _redisCacheClient = new Lazy<RedisCache>(_radisCacheMethod);
        public void GetRedisConfig()
        {
            RedisConfiguration.ServiceName = ConfigurationManager.ConnectionStrings["ServiceName"].ConnectionString;
            RedisConfiguration.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            RedisConfiguration.DatabaseId = Convert.ToInt32(ConfigurationManager.ConnectionStrings["DatabaseId"].ConnectionString);
            RedisConfiguration.SyncTimeOut = Convert.ToInt32(ConfigurationManager.ConnectionStrings["SyncTimeOut"].ConnectionString);
            RedisConfiguration.Password = ConfigurationManager.ConnectionStrings["Password"].ConnectionString;
        }

        public void comboBoxKeySetBindKeyValue(ComboBox comboBox)
        {
            comboBox.Items.Add("string");
            comboBox.Items.Add("object");
        }

        public RedisTool()
        {
            GetRedisConfig();
            InitializeComponent();
        }

        private void RedisTool_Load(object sender, EventArgs e)
        {
            comboBoxKeySetBindKeyValue(comboBoxKeySet);
            comboBoxKeySetBindKeyValue(comboBoxKeyGet);
        }

        private static RedisCache _radisCacheMethod()
        {
            return new RedisCache("alipay_qr_seed", new RedisCacheDatabaseProvider(), new RedisCacheSerializer());
        }

        /// <summary>
        /// 单击事件通过key获取值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRedisKeyGet_Click(object sender, EventArgs e)
        {
            var keyGet = txtBoxKeyGet.Text;
            comboBoxKeyGet.Text = string.IsNullOrWhiteSpace(comboBoxKeyGet.Text) ? "string" : comboBoxKeyGet.Text;
            var comboBoxTypeGet = comboBoxKeyGet.Text;
            string redisValue = string.Empty;
            var redisHasKey = await _redisCacheClient.Value.HasKey(keyGet);
            if (!redisHasKey)
            {
                txtBoxValueGet.Text = "未找到该键值！";
                return;
            }
            if (comboBoxTypeGet == "string")
            {
                redisValue = await _redisCacheClient.Value.GetOrDefaultSingle(keyGet);
            }
            else
            {

            }
            txtBoxValueGet.Text = redisValue.ToString();
        }

        /// <summary>
        /// 单击事件,新增键值对
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRedisKeySet_Click(object sender, EventArgs e)
        {
            var keySet = txtBoxKeySet.Text;
            var valueSet = txtBoxValueSet.Text;
            comboBoxKeySet.Text = string.IsNullOrWhiteSpace(comboBoxKeySet.Text) ? "string" : comboBoxKeySet.Text;
            var comboBoxTypeSet = comboBoxKeySet.Text;
            if (string.IsNullOrWhiteSpace(keySet))
            {
                MessageBox.Show("创建键值对时，键不可为空！");
                return;
            }

            if (string.IsNullOrWhiteSpace(valueSet))
            {
                MessageBox.Show("创建键值对时，值不可为空!");
                return;
            }

            var redisHasKey = await _redisCacheClient.Value.HasKey(keySet);
            if (redisHasKey)
            {
                DialogResult dr = MessageBox.Show("该键已存在，是否需要更新？", "询问对话框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr != DialogResult.OK)
                {
                    return;
                }
            }

            if (comboBoxTypeSet == "string")
            {
                
                await _redisCacheClient.Value.setSingle(keySet, valueSet);
            }
            else
            {
                JObject valueSetToObject = null;
                try
                {
                    valueSetToObject = JsonConvert.DeserializeObject(valueSet) as JObject;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("json格式错误,请输入正确的格式!");
                }
                await _redisCacheClient.Value.Set(keySet, valueSetToObject);
            }

            if (await _redisCacheClient.Value.HasKey(keySet))
            {
                MessageBox.Show("新增键值对成功!");
            }
            else
            {
                MessageBox.Show("新增键值对失败!");
            }
        }

        /// <summary>
        /// 单击事件，删除键值对
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRedisKeyDel_Click(object sender, EventArgs e)
        {
            var keyDel = txtBoxKeyDel.Text;
            var redisHasKey = await _redisCacheClient.Value.HasKey(keyDel);
            if (!redisHasKey)
            {
                MessageBox.Show("未找到该键,请核对键");
                return;
            }
            var boolDel = await _redisCacheClient.Value.DelKey(keyDel);
            if (boolDel)
            {
                MessageBox.Show("删除键值对成功");
            }
            else
            {
                MessageBox.Show("删除键值对失败");
            }
        }
    }
}
