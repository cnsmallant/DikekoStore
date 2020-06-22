using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Model.Request.Platform
{
    /// <summary>
    /// 商品规格
    /// </summary>
    public class GoodsSpecification
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
        /// 是否下拉框
        /// </summary>
        public bool IsDropdownBox { get; set; }

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
        public IList<GoodsSpecificationVal> GoodsSpecificationVal { get; set; }
    }

    /// <summary>
    /// 规格值
    /// </summary>
    public class GoodsSpecificationVal
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
        ///规格键
        /// </summary>
        public string SpecificationKeyId { get; set; }
    }
}
