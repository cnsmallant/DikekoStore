using DikekoStore.Common;
using DikekoStore.Platform.Interface;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Platform.Service
{
    /// <summary>
    /// 商品
    /// </summary>
    public class GoodsService : Common.DataBase, IGoods
    {
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public int Add(Model.Request.Platform.Goods goods)
        {

            if (goods.GoodsSku == null)
            {
                return 0;
            }
            StringBuilder sb = new StringBuilder();
            var goodsId = Common.GenerateTools.PrimaryKey();
            sb.Append($@"INSERT INTO dbo.Goods
                                                   (
                                                       Id,
                                                       Title,
                                                       CategoryId,
                                                       Cover,
                                                       Specification,
                                                       MainFigure,
                                                       Content,
                                                       IsTaoBao,
                                                       TaoWord,
                                                       OriginalPrice,
                                                       Price,
                                                       FreightTemplateId,
                                                       IsShelves,
                                                       IsUsed,
                                                       IsDelete,
                                                       CreateUserId,
                                                       CreateTime,
                                                       EditUserId,
                                                       EditTime
                                                   )
                                                   VALUES
                                                   (   N'{goodsId}',  -- Id - nvarchar(50)
                                                       N'{goods.Title}',  -- Title - nvarchar(max)
                                                       N'{goods.CategoryId}',  -- CategoryId - nvarchar(50)
                                                       N'{goods.Cover}',  -- Cover - nvarchar(max)
                                                       N'{Newtonsoft.Json.JsonConvert.SerializeObject(goods.Specification)}',  -- Specification - ntext
                                                       N'{goods.MainFigure}',  -- MainFigure - ntext
                                                       N'{goods.Content}',  -- Content - ntext
                                                       {Convert.ToInt32(goods.IsTaoBao)}, -- IsTaoBao - bit
                                                       N'{goods.TaoWord}',  -- TaoWord - nvarchar(max)
                                                       {Common.CNYTool.ToFen(goods.OriginalPrice, Enumerate.CNYEnum.Yuan)},    -- OriginalPrice - bigint
                                                       {Common.CNYTool.ToFen(goods.Price, Enumerate.CNYEnum.Yuan)},    -- Price - bigint
                                                       N'{goods.FreightTemplateId}',  -- FreightTemplateId - nvarchar(50)
                                                       {Convert.ToInt32(goods.IsShelves)}, -- IsShelves - bit
                                                       1, -- IsUsed - bit
                                                       0, -- IsDelete - bit
                                                       N'0',  -- CreateUserId - nvarchar(50)
                                                       {DateTimeOffset.Now.ToUnixTimeMilliseconds()},    -- CreateTime - bigint
                                                       N'0',  -- EditUserId - nvarchar(50)
                                                       {DateTimeOffset.Now.ToUnixTimeMilliseconds()}     -- EditTime - bigint
                                                       )");

            foreach (var item in goods.GoodsSku)
            {
                sb.Append($@"INSERT INTO  dbo.GoodsSku
                                                               (
                                                                   Id,
                                                                   Name,
                                                                   OriginalPrice,
                                                                   Price,
                                                                   Stock,
                                                                   SkuIdGroup,
                                                                   GoodsId,
                                                                   IsUsed,
                                                                   IsDelete,
                                                                   CreateUserId,
                                                                   CreateTime,
                                                                   EditUserId,
                                                                   EditTime
                                                               )
                                                               VALUES
                                                               (   N'{Common.GenerateTools.PrimaryKey()}',  -- Id - nvarchar(50)
                                                                   N'{item.Name}',  -- Name - nvarchar(max)
                                                                   {Common.CNYTool.ToFen(item.OriginalPrice, Enumerate.CNYEnum.Yuan)},    -- OriginalPrice - bigint
                                                                   {Common.CNYTool.ToFen(item.Price, Enumerate.CNYEnum.Yuan)},    -- Price - bigint
                                                                   {item.Stock},    -- Stock - int
                                                                   N'{Newtonsoft.Json.JsonConvert.SerializeObject(item.SkuIdGroup)}',  -- SkuIdGroup - ntext
                                                                   '{goodsId}'
                                                                   1, -- IsUsed - bit
                                                                   0, -- IsDelete - bit
                                                                   N'0',  -- CreateUserId - nvarchar(50)
                                                                   {DateTimeOffset.Now.ToUnixTimeMilliseconds()},    -- CreateTime - bigint
                                                                   N'0',  -- EditUserId - nvarchar(50)
                                                                   {DateTimeOffset.Now.ToUnixTimeMilliseconds()}     -- EditTime - bigint
                                                                   )");
            }

            return db.Transaction(sb.ToString());
        }

        /// <summary>
        /// 编辑商品
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public int Edit(Model.Request.Platform.Goods goods)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 按照Id读取商品
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Model.Response.Platform.Goods GetById(string Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 分页读取商品
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public List<Model.Response.Platform.GoodsPage> GetPage(Model.Request.Platform.GoodsPage page)
        {
            throw new NotImplementedException();
        }
    }
}
