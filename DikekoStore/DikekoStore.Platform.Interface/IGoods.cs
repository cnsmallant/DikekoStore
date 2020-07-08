using DikekoStore.Model;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace DikekoStore.Platform.Interface
{
    /// <summary>
    /// 商品管理
    /// </summary>
    public interface IGoods
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        int Add(Model.Request.Platform.Goods goods);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        int Edit(Model.Request.Platform.Goods goods);

        /// <summary>
        /// 按照Id读取商品详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Model.Response.Platform.Goods GetById(string Id);

        /// <summary>
        /// 分页查询
        /// </summary>
        List<Model.Response.Platform.GoodsPage> GetPage(Model.Common.Page page);
    }
}
