using Dikeko.ORM.Core.Model;
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

            sb.Append($@" INSERT dbo.GoodsPropertyKey
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

                sb.Append($@" INSERT dbo.GoodsPropertyVal
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

            }

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
            StringBuilder sub = new StringBuilder();
            List<string> propertyValId = new List<string>();
            sb.Append($@" UPDATE  dbo.GoodsPropertyKey SET Name='{goodsProperty.Name}' WHERE  Id='{goodsProperty.Id}' ;");
       
            foreach (var item in goodsProperty.PropertyVal)
            {
                if (string.IsNullOrEmpty(item.Id))
                {
                    sub.Append($@" INSERT dbo.GoodsPropertyVal
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

                }
                else
                {
                    sub.Append($" UPDATE dbo.GoodsPropertyVal SET Name='{item.Name}' WHERE Id='{item.Id}';");
                    propertyValId.Add(item.Id);
                }
            }
            if (propertyValId.Count > 0)
            {
                sb.Append($" UPDATE dbo.GoodsPropertyVal SET IsDelete=1 WHERE PropertyKeyId='' AND Id NOT IN('{string.Join("','", propertyValId)}');");
            }
            sb.Append(sub.ToString());
            return db.Transaction(sb.ToString());
        }

        /// <summary>
        /// 按照CategoryId读取
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public IList<GoodsPropertyKey> GetByCategoryId(string categoryId)
        {
            var sql = $@"SELECT Id,
                                              Name,
                                              CategoryId,
                                              IsUsed,
                                              IsDelete,
                                              CreateUserId,
                                              CreateTime,
                                              EditUserId,
                                              EditTime FROM dbo.GoodsPropertyKey
	                                          WHERE CategoryId=@CategoryId AND IsUsed=1 AND IsDelete=0";
            SqlParameter[] para =
            {
                new SqlParameter("@CategoryId",categoryId)
            };
            return db.FetchOrDefault<GoodsPropertyKey>(sql, para);
        }

        /// <summary>
        /// 按照PropertyKeyId读取
        /// </summary>
        /// <param name="propertyKeyId"></param>
        /// <returns></returns>
        public IList<Dikeko.ORM.Core.Model.GoodsPropertyVal> GetByPropertyKeyId(string propertyKeyId)
        {
            var sql = $@"SELECT Id,
                                       Name,
                                       PropertyKeyId,
                                       IsUsed,
                                       IsDelete,
                                       CreateUserId,
                                       CreateTime,
                                       EditUserId,
                                       EditTime FROM dbo.GoodsPropertyVal 
	                             WHERE PropertyKeyId=@PropertyKeyId AND IsUsed=1 AND IsDelete=0";
            SqlParameter[] para =
            {
                new SqlParameter("@PropertyKeyId",propertyKeyId)
            };
            return db.FetchOrDefault<Dikeko.ORM.Core.Model.GoodsPropertyVal>(sql, para);
        }
    }
}
