using DikekoStore.Common;
using DikekoStore.Model.Common;
using DikekoStore.Model.Request.Platform;
using DikekoStore.Platform.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public int Delete(PrimaryKey primaryKey)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($@"UPDATE  dbo.GoodsPropertyVal SET IsDelete=1 WHERE PropertyKeyId = (SELECT Id FROM dbo.GoodsPropertyKey WHERE Id='{primaryKey.Id}' );");
            sb.Append($@"UPDATE dbo.GoodsPropertyKey SET IsDelete=1 WHERE Id ='{primaryKey.Id}';");
            return db.Transaction(sb.ToString());
        }

        /// <summary>
        /// 删除属性值
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public int DeleteVal(PrimaryKey primaryKey)
        {
            var sql = "UPDATE dbo.GoodsPropertyVal SET IsDelete=1 WHERE Id =@Id";
            SqlParameter[] para =
            {
                new SqlParameter("@Id",primaryKey.Id)
            };
            return db.Update(sql, para);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="goodsProperty"></param>
        /// <returns></returns>
        public int Edit(GoodsProperty goodsProperty)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($@"IF NOT EXISTS(SELECT Id FROM dbo.GoodsPropertyKey WHERE Name='{goodsProperty.Name}' AND  IsDelete=0)");
            sb.Append(@"BEGIN");
            sb.Append($@"UPDATE  dbo.GoodsPropertyKey SET Name='{goodsProperty.Name}' WHERE  Id='{goodsProperty.Id}' ");
            sb.Append("END");
            foreach (var item in goodsProperty.PropertyVal)
            {
                sb.Append($@"IF NOT EXISTS(SELECT Id FROM dbo.GoodsPropertyVal WHERE Name='{item.Name}' AND  IsDelete=0 AND PropertyKeyId='{item.PropertyKeyId}' )");
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
                                                           N'{item.PropertyKeyId}',  -- PropertyKeyId - nvarchar(50)
                                                           1, -- IsUsed - bit
                                                           0, -- IsDelete - bit
                                                           N'{goodsProperty.CategoryId}',  -- CreateUserId - nvarchar(50)
                                                           {goodsProperty.CreateTime},    -- CreateTime - bigint
                                                           N'{goodsProperty.EditUserId}',  -- EditUserId - nvarchar(50)
                                                           {goodsProperty.EditTime}     -- EditTime - bigint
                                                           );");
                sb.Append("END");
            }

            return db.Transaction(sb.ToString());
        }


    }
}
