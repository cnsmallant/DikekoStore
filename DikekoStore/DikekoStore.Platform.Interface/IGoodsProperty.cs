using Dikeko.ORM.Core.Model;
using DikekoStore.Model.Common;
using DikekoStore.Model.Request.Platform;
using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Platform.Interface
{
    public interface IGoodsProperty
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        int Add(GoodsProperty goodsProperty);

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        int Edit(GoodsProperty goodsProperty);

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
        IList<GoodsPropertyKey> GetByCategoryId(string categoryId);
        /// <summary>
        /// 按照PropertyKeyId读取
        /// </summary>
        /// <param name="propertyKeyId"></param>
        /// <returns></returns>
        IList<Dikeko.ORM.Core.Model.GoodsPropertyVal> GetByPropertyKeyId(string propertyKeyId);
    }
}
