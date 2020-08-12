using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReptileCarPlatformData.Model;
using ReptileCarPlatformData.Tool;
using System;
using System.Collections.Generic;

namespace ReptileCarPlatformData
{
    class Program
    {

        public static string TestDataParams = "make=audi&model=a6&year=2018";

        static void Main(string[] args)
        {
            Console.WriteLine("开始抓取数据中....");
            //1获取三个筛选条件的组合情况，得到集合searchCondition 例如:ml?make=acura&model=&year=2001，sm?make=acura&model=cl&year=2001
            //var urlList = getAllCondition();

            //2发起请求获取数据，异常时重新发起请求，得到数据
            var dataResult = ApiRequest.RequestData(TestDataParams);
            List<requestDataEntity> list = JsonConvert.DeserializeObject<List<requestDataEntity>>(dataResult.ToString());
            Console.WriteLine(list);

            //foreach (var item in conditionList)
            //{
            //    ApiRequest.RequestByGet(item);
            //}

            //3入库
        }

        /// <summary>
        /// 获取所有筛选条件
        /// </summary>
        /// <returns></returns>
        private static List<string> getAllCondition()
        {
            var level1Result = ApiRequest.RequestAutomobileBrandData();
            var  level1List = JArray.Parse(level1Result.ToString());
            //遍历一级条件的数据--171条
            foreach (var item in level1List)  //查找某个字段与值
            {
                string model = item["name"].ToString();//小写
                string make = item["slug"].ToString();//大写

            }
            return null;
        }
    }
}
