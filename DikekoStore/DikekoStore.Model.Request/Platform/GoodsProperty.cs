using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Model.Request.Platform
{
    /// <summary>
    /// 属性
    /// </summary>
    public class GoodsProperty
    {
        /// <summary>
        ///主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        ///名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///类别
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        ///创建人
        /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
        ///创建时间（时间戳）
        /// </summary>
        public long CreateTime { get; set; }
        /// <summary>
        ///修改人
        /// </summary>
        public string EditUserId { get; set; }
        /// <summary>
        ///修改时间（时间戳）
        /// </summary>
        public long EditTime { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public IList<GoodsPropertyVal> PropertyVal { get; set; }
    }

    /// <summary>
    /// 属性值
    /// </summary>
    public class GoodsPropertyVal
    {
        /// <summary>
        ///主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        ///名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///属性键
        /// </summary>
        public string PropertyKeyId { get; set; }
    }
}
