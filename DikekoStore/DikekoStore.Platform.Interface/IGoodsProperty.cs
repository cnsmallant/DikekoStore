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


    }
}
