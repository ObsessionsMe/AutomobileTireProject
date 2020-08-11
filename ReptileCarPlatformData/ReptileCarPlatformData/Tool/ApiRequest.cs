using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReptileCarPlatformData.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ReptileCarPlatformData.Tool
{

    /// <summary>
    ///  接口请求帮助类
    /// </summary>
    public class ApiRequest
    {
        //1接口请求地址
        public static string ApiUrl = "https://services.wheel-size.com/widget/finder/api/";


        /// <summary>
        ///  发起Get请求，获取查询搜索的结果集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object RequestByGet(string param)
        {
            object result = null;
            using (var client = new HttpClient())
            {
                var responseString = client.GetStringAsync(ApiUrl + param);
                if (responseString == null)
                {
                    //请求失败
                    return result;
                }
                result = responseString;
                //解析数据
                //result = JsonConvert.DeserializeObject<List<requestDataEntity>>(responseString.Result);
            }
            return result;
        }
    }
}
