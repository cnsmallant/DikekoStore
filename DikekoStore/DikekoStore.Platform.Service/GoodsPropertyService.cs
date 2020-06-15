using DikekoStore.Common;
using DikekoStore.Model.Request.Platform;
using DikekoStore.Platform.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Platform.Service
{
    public class GoodsPropertyService : DataBase, IGoodsProperty
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="goodsProperty"></param>
        /// <returns></returns>
        public int Add(GoodsProperty goodsProperty)
        {
            StringBuilder sb = new StringBuilder();
            var PropertyKeyId = Common.GenerateTools.PrimaryKey();
            sb.Append($@"IF NOT EXISTS(SELECT Id FROM dbo.GoodsPropertyKey WHERE Name='{goodsProperty.Name}' AND IsDelete=0)");
            sb.Append("BEGIN");
            sb.Append($@"INSERT dbo.GoodsPropertyKey
                                     (
                                         Id,
                                         Name,
                                         CategoryId,
                                         IsUsed,
                                         IsDelete,
                                         CreateUserId,
                                         CreateTime,
                                         EditUserId,
                                         EditTime
                                     )
                                     VALUES
                                     (   N'{PropertyKeyId}',  -- Id - nvarchar(50)
                                         N'{goodsProperty.Name}',  -- Name - nvarchar(50)
                                         N'{goodsProperty.CategoryId}',  -- CategoryId - nvarchar(50)
                                         1, -- IsUsed - bit
                                         0, -- IsDelete - bit
                                         N'{goodsProperty.CategoryId}',  -- CreateUserId - nvarchar(50)
                                         {goodsProperty.CreateTime},    -- CreateTime - bigint
                                         N'{goodsProperty.EditUserId}',  -- EditUserId - nvarchar(50)
                                         {goodsProperty.EditTime}     -- EditTime - bigint
                                         );");
            foreach (var item in goodsProperty.PropertyVal)
            {
                sb.Append($@"IF NOT EXISTS(SELECT Id FROM dbo.GoodsPropertyVal WHERE Name='{item.Name}' AND  PropertyKeyId='{PropertyKeyId}' AND               IsDelete=0 ) ");
                sb.Append("BEGIN");
                sb.Append($@"INSERT dbo.GoodsPropertyVal
                                                       (
                                                           Id,
                                                           Name,
                                                           PropertyKeyId,
                                                           IsUsed,
                                                           IsDelete,
                                                           CreateUserId,
                                                           CreateTime,
                                                           EditUserId,
                                                           EditTime
                                                       )
                                                       VALUES
                                                       (   N'{Common.GenerateTools.PrimaryKey()}',  -- Id - nvarchar(50)
                                                           N'{item.Name}',  -- Name - nvarchar(50)
                                                           N'{PropertyKeyId}',  -- PropertyKeyId - nvarchar(50)
                                                           1, -- IsUsed - bit
                                                           0, -- IsDelete - bit
                                                           N'{goodsProperty.CategoryId}',  -- CreateUserId - nvarchar(50)
                                                           {goodsProperty.CreateTime},    -- CreateTime - bigint
                                                           N'{goodsProperty.EditUserId}',  -- EditUserId - nvarchar(50)
                                                           {goodsProperty.EditTime}     -- EditTime - bigint
                                                           );");
                sb.Append("END");
            }
            sb.Append("END");
            return db.Transaction(sb.ToString());
        }

        public int Edit(GoodsProperty goodsProperty)
        {
            throw new NotImplementedException();
        }
    }
}
