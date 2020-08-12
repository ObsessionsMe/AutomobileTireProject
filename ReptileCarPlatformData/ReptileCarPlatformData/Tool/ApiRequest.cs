using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
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
        public static string ApiUrl = "https://services.wheel-size.com/widget/finder/api/sm?";

        //2所有品牌默认请求地址
        public static string automobileBrandApi = "https://services.wheel-size.com/widget/finder/api/mk?make=&model=&year=";

        //条件查询请求地址
        public static string ConditionApiUrl = "https://services.wheel-size.com/widget/finder/api/mk?";

        /// <summary>
        ///  发起Get请求，获取所有品牌的结果集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object RequestAutomobileBrandData()
        {
            object result = null;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(automobileBrandApi);
                RequestByGet(req);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream, Encoding.Default))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 发起Get请求，获取返回结果集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object RequestData(string param)
        {
            object result = null;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(ApiUrl+ param);
                RequestByGet(req);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream, Encoding.Default))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


            /// <summary>
            /// 设置请求头信息/默认
            /// </summary>
            /// <param name="client"></param>
            public static void RequestByGet(HttpWebRequest req)
        {
            req.Method = "GET";
            req.Host = "services.wheel-size.com";
            req.Referer = "https://services.wheel-size.com/widget/finder/?config";
            req.Accept = "application/json, text/plain, */*";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36";
            req.Headers["Accept-Language"] = "zh-CN,zh;q=0.9";
            //req.Headers["X-CSRFToken"] = "wELoTjkA6dYLTIRu1dcx6QNFgPkXkTbtlldvokPU1cLJCsq8GHtSIuPiZh2pYhkQ";
            req.Headers["X-Csrf-Token"] = "gbSDMgaMm8sgKWTR1TTFxAvLWldsudj9";
            //req.Headers["Cookie"] = "__guid=90766360.1459916678094302000.1597213409162.0479; _ga=GA1.2.585568688.1597213441; _gid=GA1.2.1681335507.1597213441; csrftoken=VV0P9ui8Z1pQtWNjDQWwF15O8d80Bhl3KCsWEvNsU0cOcGmXikdRhF7rRFQsfFuq; monitor_count=4; _gat=1";
        }
    }
}
