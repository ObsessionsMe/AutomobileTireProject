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
            //1获取三个筛选条件的组合情况，得到集合searchCondition 例如:[make=acura&model=&year=2001，make=acura&model=cl&year=2001]
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
            List<conditionEntity> level1List = JsonConvert.DeserializeObject<List<conditionEntity>>(level1Result.ToString());
            string yearParam = "";
            //1遍历品牌(1级)的数据--171条
            foreach (var item in level1List)  //查找某个字段与值
            {
                yearParam = "yr?make=" + item .slug+ "&model=&year=";
                //2通过品牌查询出年份数据
               var yearResult =  ApiRequest.RequestData(yearParam);
                var level2List = JsonConvert.DeserializeObject<List<conditionEntity>>(yearResult.ToString());
                foreach (var item2 in level2List)
                {
                    //3品牌和年份查询出型号的数据
                    var typeResult = ApiRequest.RequestData(yearParam);
                    var level3List = JsonConvert.DeserializeObject<List<conditionEntity>>(typeResult.ToString());
                    //4

                }
            }
            return null;
        }
    }
}
