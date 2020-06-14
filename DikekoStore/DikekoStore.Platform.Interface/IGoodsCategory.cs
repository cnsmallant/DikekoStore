using Dikeko.ORM.Core.Model;
using DikekoStore.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Platform.Interface
{
    /// <summary>
    /// 商品类别管理
    /// </summary>
    public interface IGoodsCategory
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        int Add(GoodsCategory category);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        int Edit(GoodsCategory category);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        int Delete(PrimaryKey primaryKey);

        /// <summary>
        /// 按照主键查询
        /// </summary>
        /// <returns></returns>
        GoodsCategory GetById(PrimaryKey primaryKey);

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        IList<GoodsCategory> GetByList();

        /// <summary>
        /// 按照Level查询
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        IList<GoodsCategory> GetByLevel(int level);
    }
}
