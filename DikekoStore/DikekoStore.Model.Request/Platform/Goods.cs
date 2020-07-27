using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using static DikekoStore.Common.Enumerate;

namespace DikekoStore.Model.Request.Platform
{
    /// <summary>
    /// 商品
    /// </summary>
    [DataContract]
    public class Goods
    {
        /// <summary>
        ///主键
        /// </summary>
        [DataMember]
        public string Id { get; set; }
        /// <summary>
        ///标题
        /// </summary>
        [DataMember]
        public string Title { get; set; }
        /// <summary>
        ///类别
        /// </summary>
        [DataMember]
        public string CategoryId { get; set; }
        /// <summary>
        ///封面
        /// </summary>
        [DataMember]
        public string Cover { get; set; }
        /// <summary>
        ///规格信息（json格式）
        /// </summary>
        [DataMember]
        public List<Specification> Specification { get; set; }
        /// <summary>
        ///主图（json格式）
        /// </summary>
        [DataMember]
        public List<string> MainFigure { get; set; }
        /// <summary>
        ///内容
        /// </summary>
        [DataMember]
        public string Content { get; set; }
        /// <summary>
        ///是否淘宝宝贝
        /// </summary>
        [DataMember]
        public bool IsTaoBao { get; set; }
        /// <summary>
        ///淘口令
        /// </summary>
        [DataMember]
        public string TaoWord { get; set; }
        /// <summary>
        ///原价（以分为单位）
        /// </summary>
        [DataMember]
        public decimal OriginalPrice { get; set; }
        /// <summary>
        ///售价（以分为单位）
        /// </summary>
        [DataMember]
        public decimal Price { get; set; }
        /// <summary>
        ///运费模版
        /// </summary>
        [DataMember]
        public string FreightTemplateId { get; set; }
        /// <summary>
        ///是否上架
        /// </summary>
        [DataMember]
        public bool IsShelves { get; set; }
        /// <summary>
        ///是否启用
        /// </summary>
        public bool IsUsed { get; set; }
        /// <summary>
        ///是否删除
        /// </summary>
        public bool IsDelete { get; set; }
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
        /// 商品sku
        /// </summary>
        public List<GoodsSku> GoodsSku { get; set; }
    }

    /// <summary>
    /// 商品规格
    /// </summary>
    [DataContract]
    public class Specification
    {
        /// <summary>
        /// 显示名
        /// </summary>
        [DataMember]
        public string Lable { get; set; }
        /// <summary>
        /// 显示值
        /// </summary>
        [DataMember]
        public string Value { get; set; }
    }

    /// <summary>
    /// 商品sku
    /// </summary>
    [DataContract]
    public class GoodsSku
    {
        /// <summary>
        ///主键
        /// </summary>
        [DataMember]

        public string Id { get; set; }
        /// <summary>
        ///名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        ///原价（以分为单位）
        /// </summary>
        [DataMember]
        public long OriginalPrice { get; set; }
        /// <summary>
        ///售价（以分为单位）
        /// </summary>
        [DataMember]
        public long Price { get; set; }
        /// <summary>
        ///库存
        /// </summary>
        [DataMember]
        public int Stock { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [DataMember]
        public string  GoodsId { get; set; }
        /// <summary>
        ///SKU-Id组合（json格式）
        /// </summary>
        [DataMember]
        public List<string> SkuIdGroup { get; set; }
        /// <summary>
        ///是否启用
        /// </summary>
        public bool IsUsed { get; set; }
        /// <summary>
        ///是否删除
        /// </summary>
        public bool IsDelete { get; set; }
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
    }

    /// <summary>
    /// 商品分页
    /// </summary>
    public class GoodsPage:Common.Page
    {
        /// <summary>
        /// 排序字段
        /// </summary>
        public SortField SortField { get; set; }
        
    }
}
