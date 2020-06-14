using Dikeko.ORM.Core.Model;
using DikekoStore.Common;
using DikekoStore.Model.Common;
using DikekoStore.Platform.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Platform.Service
{
    /// <summary>
    /// 商品类别管理
    /// </summary>
    public class GoodsCategoryService : DataBase, IGoodsCategory
    {
        public int Add(GoodsCategory category)
        {
            throw new NotImplementedException();
        }

        public int Delete(PrimaryKey primaryKey)
        {
            throw new NotImplementedException();
        }

        public int Edit(GoodsCategory category)
        {
            throw new NotImplementedException();
        }

        public GoodsCategory GetById(PrimaryKey primaryKey)
        {
            throw new NotImplementedException();
        }

        public IList<GoodsCategory> GetByLevel(int level)
        {
            throw new NotImplementedException();
        }

        public IList<GoodsCategory> GetByList()
        {
            throw new NotImplementedException();
        }
    }
}
