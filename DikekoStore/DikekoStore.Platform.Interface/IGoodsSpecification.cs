using Dikeko.ORM.Core.Model;
using DikekoStore.Model.Common;
using DikekoStore.Model.Request.Platform;
using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Platform.Interface
{
    /// <summary>
    /// 商品规格
    /// </summary>
    public interface IGoodsSpecification
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        int Add(GoodsSpecification goodsSpecification);

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        int Edit(GoodsSpecification goodsSpecification);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        int Delete(PrimaryKey primaryKey);

        /// <summary>
        /// 删除属性值
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        int DeleteVal(PrimaryKey primaryKey);

        /// <summary>
        /// 按照CategoryId读取
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        IList<GoodsSpecificationKey> GetByCategoryId(string categoryId);
        /// <summary>
        /// 按照PropertyKeyId读取
        /// </summary>
        /// <param name="propertyKeyId"></param>
        /// <returns></returns>
        IList<Dikeko.ORM.Core.Model.GoodsSpecificationVal> GetBSpecificationKeyId(string specificationKeyId);
    }
}
