using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Model.Response.Platform
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Goods
    {
        /// <summary>
        ///主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        ///标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        ///类别
        /// </summary>
        public string CategoryId { get; set; }
        /// <summary>
        ///封面
        /// </summary>
        public string Cover { get; set; }
        /// <summary>
        ///规格信息（json格式）
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// 商品SKU
        /// </summary>
        public List<GoodsSku> GoodsSku { get; set; }
        /// <summary>
        ///主图（json格式）
        /// </summary>
        public List<string> MainFigure { get; set; }
        /// <summary>
        ///内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        ///是否淘宝宝贝
        /// </summary>
        public bool IsTaoBao { get; set; }
        /// <summary>
        ///淘口令
        /// </summary>
        public string TaoWord { get; set; }
        /// <summary>
        ///原价（以分为单位）
        /// </summary>
        public long OriginalPrice { get; set; }
        /// <summary>
        ///售价（以分为单位）
        /// </summary>
        public long Price { get; set; }
        /// <summary>
        ///运费模版
        /// </summary>
        public string FreightTemplateId { get; set; }

        /// <summary>
        /// 运费模版
        /// </summary>
        public GoodsFreightTemplate GoodsFreightTemplate { get; set; }
        /// <summary>
        ///是否上架
        /// </summary>
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
    }

    /// <summary>
    /// 运费模版
    /// </summary>
    public class GoodsFreightTemplate
    {
        /// <summary>
        ///主键
        public string Id { get; set; }
        /// <summary>
        ///区域（储存格式：北京，天津，上海）
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        ///是否包邮
        /// </summary>
        public bool IsFreeShipping { get; set; }
        /// <summary>
        ///运费（以分为单位）
        /// </summary>
        public long Freight { get; set; }
        /// <summary>
        ///退货地址
        /// </summary>
        public string ReturnAddress { get; set; }

    }

    /// <summary>
    /// 商品SKU
    /// </summary>
    public class GoodsSku
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
        ///原价（以分为单位）
        /// </summary>
        public long OriginalPrice { get; set; }
        /// <summary>
        ///售价（以分为单位）
        /// </summary>
        public long Price { get; set; }
        /// <summary>
        ///库存
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        ///SKU-Id组合（json格式）
        /// </summary>
        public string SkuIdGroup { get; set; }

    }

    /// <summary>
    /// 商品分页
    /// </summary>
    public class GoodsPage
    {
        /// <summary>
        ///主键
        /// </summary>
     
        public string Id { get; set; }
        /// <summary>
        ///标题
        /// </summary>
     
        public string Title { get; set; }
        
        /// <summary>
        ///封面
        /// </summary>
        public string Cover { get; set; }
      
       
        /// <summary>
        ///内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        ///是否淘宝宝贝
        /// </summary>
        public bool IsTaoBao { get; set; }
       
        /// <summary>
        ///原价（以分为单位）
        /// </summary>
        public long OriginalPrice { get; set; }
        /// <summary>
        ///售价（以分为单位）
        /// </summary>
        public long Price { get; set; }
        /// <summary>
        ///运费模版
        /// </summary>
        public string FreightTemplateId { get; set; }
        /// <summary>
        ///是否上架
        /// </summary>
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
    }
}
