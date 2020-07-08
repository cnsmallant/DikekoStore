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
    /// <summary>
    /// 商品规格
    /// </summary>
    public class GoodsSpecificationService : DataBase, IGoodsSpecification
    {
        /// <summary>
        /// 添加规格
        /// </summary>
        /// <param name="goodsSpecification"></param>
        /// <returns></returns>
        public int Add(GoodsSpecification goodsSpecification)
        {
            StringBuilder sb = new StringBuilder();
            var SpecificationKeyId = Common.GenerateTools.PrimaryKey();
          
            sb.Append($@" INSERT dbo.GoodsSpecificationKey
                                     (
                                         Id,
                                         Name,
                                         CategoryId,
                                         IsDropdownBox,
                                         IsUsed,
                                         IsDelete,
                                         CreateUserId,
                                         CreateTime,
                                         EditUserId,
                                         EditTime
                                     )
                                     VALUES
                                     (   N'{SpecificationKeyId}',  -- Id - nvarchar(50)
                                         N'{goodsSpecification.Name}',  -- Name - nvarchar(50)
                                         N'{goodsSpecification.CategoryId}',  -- CategoryId - nvarchar(50)
                                          {Convert.ToInt32(goodsSpecification.IsDropdownBox)}
                                         1, -- IsUsed - bit
                                         0, -- IsDelete - bit
                                         N'{goodsSpecification.CategoryId}',  -- CreateUserId - nvarchar(50)
                                         {goodsSpecification.CreateTime},    -- CreateTime - bigint
                                         N'{goodsSpecification.EditUserId}',  -- EditUserId - nvarchar(50)
                                         {goodsSpecification.EditTime}     -- EditTime - bigint
                                         );");
            if (goodsSpecification.IsDropdownBox)
            {
                foreach (var item in goodsSpecification.GoodsSpecificationVal)
                {
                
                    sb.Append($@"INSERT dbo.GoodsSpecificationVal
                                                       (
                                                           Id,
                                                           Name,
                                                           SpecificationKeyId,
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
                                                           N'{SpecificationKeyId}',  -- PropertyKeyId - nvarchar(50)
                                                           1, -- IsUsed - bit
                                                           0, -- IsDelete - bit
                                                           N'{goodsSpecification.CategoryId}',  -- CreateUserId - nvarchar(50)
                                                           {goodsSpecification.CreateTime},    -- CreateTime - bigint
                                                           N'{goodsSpecification.EditUserId}',  -- EditUserId - nvarchar(50)
                                                           {goodsSpecification.EditTime}     -- EditTime - bigint
                                                           );");
                
                }

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
            sb.Append($@"UPDATE  dbo.GoodsSpecificationVal SET IsDelete=1 WHERE SpecificationKeyId = (SELECT Id FROM dbo.GoodsSpecificationKey WHERE Id='{primaryKey.Id}' );");
            sb.Append($@"UPDATE dbo.GoodsSpecificationKey SET IsDelete=1 WHERE Id ='{primaryKey.Id}';");
            return db.Transaction(sb.ToString());
        }

        /// <summary>
        /// 删除规格值
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public int DeleteVal(PrimaryKey primaryKey)
        {
            var sql = "UPDATE dbo.GoodsSpecificationVal SET IsDelete=1 WHERE Id =@Id";
            SqlParameter[] para =
            {
                new SqlParameter("@Id",primaryKey.Id)
            };
            return db.Update(sql, para);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="goodsSpecification"></param>
        /// <returns></returns>
        public int Edit(GoodsSpecification goodsSpecification)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sub = new StringBuilder();
            List<string> specificationValId = new List<string>();
            sb.Append($@"UPDATE  dbo.GoodsSpecificationKey SET Name='{goodsSpecification.Name}' WHERE  Id='{goodsSpecification.Id}' ");
            if (goodsSpecification.IsDropdownBox)
            {
              
                foreach (var item in goodsSpecification.GoodsSpecificationVal)
                {
                    if (string.IsNullOrEmpty(item.Id))
                    {
                        sub.Append($@"INSERT dbo.GoodsSpecificationVal
                                                       (
                                                           Id,
                                                           Name,
                                                           SpecificationKeyId,
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
                                                           N'{item.SpecificationKeyId}',  -- PropertyKeyId - nvarchar(50)
                                                           1, -- IsUsed - bit
                                                           0, -- IsDelete - bit
                                                           N'{goodsSpecification.CategoryId}',  -- CreateUserId - nvarchar(50)
                                                           {goodsSpecification.CreateTime},    -- CreateTime - bigint
                                                           N'{goodsSpecification.EditUserId}',  -- EditUserId - nvarchar(50)
                                                           {goodsSpecification.EditTime}     -- EditTime - bigint
                                                           );");

                    }
                    else
                    {
                        sub.Append($"UPDATE.GoodsSpecificationVal SET Name='{item.Name}' WHERE  Id='{item.Id}'");
                        specificationValId.Add(item.Id);
                    }
                    if (specificationValId.Count > 0)
                    {
                        sb.Append($"UPDATE.GoodsSpecificationVal SET IsDelete=1 WHERE SpecificationKeyId='' AND Id NOT IN('{string.Join("','", specificationValId)}')");
                    }
                }
            }
            else
            {
                sb.Append($@"UPDATE  dbo.GoodsSpecificationVal SET IsDelete=1 WHERE SpecificationKeyId ='{goodsSpecification.Id}';");
            }

            return db.Transaction(sb.ToString());
        }

        /// <summary>
        /// 按照keyid读取
        /// </summary>
        /// <param name="specificationKeyId"></param>
        /// <returns></returns>
        public IList<Dikeko.ORM.Core.Model.GoodsSpecificationVal> GetBSpecificationKeyId(string specificationKeyId)
        {
            var sql = $@"SELECT Id,
                                                Name,
                                                SpecificationKeyId,
                                                IsUsed,
                                                IsDelete,
                                                CreateUserId,
                                                CreateTime,
                                                EditUserId,
                                                EditTime FROM dbo.GoodsSpecificationVal
                                                WHERE SpecificationKeyId=@SpecificationKeyId AND IsUsed=1 AND IsDelete=0";
            SqlParameter[] para =
         {
                new SqlParameter("@SpecificationKeyId",specificationKeyId)
            };
            return db.FetchOrDefault<Dikeko.ORM.Core.Model.GoodsSpecificationVal>(sql, para);
        }

        /// <summary>
        /// 按照类别Id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public IList<GoodsSpecificationKey> GetByCategoryId(string categoryId)
        {
            var sql = $@"SELECT Id,
                                                 Name,
                                                 CategoryId,
                                                 IsDropdownBox,
                                                 IsUsed,
                                                 IsDelete,
                                                 CreateUserId,
                                                 CreateTime,
                                                 EditUserId,
                                                 EditTime FROM dbo.GoodsSpecificationKey
                                                 WHERE CategoryId=@CategoryId AND IsUsed=1 AND IsDelete=0";
            SqlParameter[] para =
         {
                new SqlParameter("@CategoryId",categoryId)
            };
            return db.FetchOrDefault<Dikeko.ORM.Core.Model.GoodsSpecificationKey>(sql, para);
        }


    }
}
