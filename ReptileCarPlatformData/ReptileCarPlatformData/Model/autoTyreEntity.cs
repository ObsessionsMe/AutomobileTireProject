using System;
using System.Collections.Generic;
using System.Text;

namespace ReptileCarPlatformData.Model
{
    /// <summary>
    /// 汽车轮胎数据实体(入库)
    /// </summary>
    public class autoTyreEntity
    {
        public string Country { get; set; }

        public string Make { get; set; }

        public string Year { get; set; }

        public string Model { get; set; }

        public string Trim { get; set; }

        public string Tire { get; set; }

        public string Rim { get; set; }

        public string BoltPattern { get; set; }

        public string THD { get; set; }

        public string CB { get; set; }
    }
}
