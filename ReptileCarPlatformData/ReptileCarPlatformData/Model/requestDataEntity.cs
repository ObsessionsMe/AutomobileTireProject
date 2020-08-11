using System;
using System.Collections.Generic;
using System.Text;

namespace ReptileCarPlatformData.Model
{
    /// <summary>
    /// 查询结果返回的数据集合
    /// </summary>
    public class requestDataEntity
    {
        public class Market
        {
            /// <summary>
            /// 
            /// </summary>
            public string slug { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string abbr { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string name_en { get; set; }
        }

        public class BodiesItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string image { get; set; }
        }

        public class Generation
        {
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<BodiesItem> bodies { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int start_year { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int end_year { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<int> years { get; set; }
        }

        public class Power
        {
            /// <summary>
            /// 
            /// </summary>
            public int kW { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int PS { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int hp { get; set; }
        }

        public class Tire_pressure
        {
            /// <summary>
            /// 
            /// </summary>
            public double bar { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int psi { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int kPa { get; set; }
        }

        public class Front
        {
            /// <summary>
            /// 
            /// </summary>
            public Tire_pressure tire_pressure { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string rim { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int rim_diameter { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int rim_width { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int rim_offset { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_sizing_system { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_construction { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int tire_width { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int tire_aspect_ratio { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_diameter { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_section_width { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_is_82series { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int load_index { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string speed_index { get; set; }
        }

        //因名称重复，该实体已更名无作用
        //public class Tire_pressures
        //{
        //    /// <summary>
        //    /// 
        //    /// </summary>
        //    public double bar { get; set; }
        //    /// <summary>
        //    /// 
        //    /// </summary>
        //    public int psi { get; set; }
        //    /// <summary>
        //    /// 
        //    /// </summary>
        //    public int kPa { get; set; }
        //}

        public class Rear
        {
            /// <summary>
            /// 
            /// </summary>
            public Tire_pressure tire_pressure { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string rim { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string rim_diameter { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string rim_width { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string rim_offset { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_sizing_system { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_construction { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_width { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_aspect_ratio { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_diameter { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_section_width { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tire_is_82series { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string load_index { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string speed_index { get; set; }
        }

        public class WheelsItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string showing_fp_only { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string is_stock { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Front front { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Rear rear { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public Market market { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string body { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string trim { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string slug { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Generation generation { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int stud_holes { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int pcd { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public double centre_bore { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string lock_type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string lock_text { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string bolt_pattern { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Power power { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string engine_type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string fuel { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<WheelsItem> wheels { get; set; }
        }
    }
}