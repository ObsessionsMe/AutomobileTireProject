using ReptileCarPlatformData.Tool;
using System;
using System.Collections.Generic;

namespace ReptileCarPlatformData
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            //1获取三个筛选条件的组合情况，得到集合searchCondition 例如:ml?make=acura&model=&year=2001，sm?make=acura&model=cl&year=2001

            //2发起请求获取数据，异常时重新发起请求，将得到的数据存储起来/或者入库
            var conditionList = getAllCondition();
            foreach (var item in conditionList)
            {
                ApiRequest.RequestByGet(item);
            }
        }

        /// <summary>
        /// 获取所有筛选条件
        /// </summary>
        /// <returns></returns>
        private static List<string> getAllCondition()
        {
            return null;
        }

    }
}
