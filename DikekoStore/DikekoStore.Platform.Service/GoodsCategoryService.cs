using Dikeko.ORM.Core.Model;
using DikekoStore.Common;
using DikekoStore.Model.Common;
using DikekoStore.Platform.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DikekoStore.Platform.Service
{
    /// <summary>
    /// 商品类别管理
    /// </summary>
    public class GoodsCategoryService : DataBase, IGoodsCategory
    {
        /// <summary>
        /// 添加商品类别
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public int Add(GoodsCategory category)
        {
            var sql = @"INSERT dbo.GoodsCategory
                                              (
                                                  Id,
                                                  Name,
                                                  Level,
                                                  Icon,
                                                  ParentId,
                                                  IsUsed,
                                                  IsDelete,
                                                  CreateUserId,
                                                  CreateTime,
                                                  EditUserId,
                                                  EditTime
                                              )
                                              VALUES
                                              (   @Id,
                                                  @Name,
                                                  @Level,
                                                  @Icon,
                                                  @ParentId,
                                                  @IsUsed,
                                                  @IsDelete,
                                                  @CreateUserId,
                                                  @CreateTime,
                                                  @EditUserId,
                                                  @EditTime
                                                  )";
            SqlParameter[] para =
            {
                new SqlParameter("@Id",category.Id),
                new SqlParameter("@Name",category.Name),
                new SqlParameter("@Level",category.Level),
                new SqlParameter("@Icon",category.Icon),
                new SqlParameter("@ParentId",category.ParentId),
                new SqlParameter("@IsUsed",category.IsUsed),
                new SqlParameter("@IsDelete",category.IsDelete),
                new SqlParameter("@CreateUserId",category.CreateUserId),
                new SqlParameter("@CreateTime",category.CreateTime),
                new SqlParameter("@EditUserId",category.EditUserId),
                new SqlParameter("@EditTime",category.EditTime)
            };
            return db.Insert(sql, para);
        }

        /// <summary>
        /// 删除商品类别
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public int Delete(PrimaryKey primaryKey)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE dbo.GoodsPropertyVal SET IsDelete=1 WHERE PropertyKeyId IN (SELECT Id FROM dbo.GoodsPropertyKey WHERE CategoryId=@Id);");
            sb.Append("UPDATE dbo.GoodsSpecificationVal SET IsDelete=1 WHERE SpecificationKeyId IN (SELECT Id FROM dbo.GoodsSpecificationKey WHERE CategoryId=@Id); ");
            sb.Append("UPDATE dbo.GoodsPropertyKey SET IsDelete=1 WHERE CategoryId=@Id;");
            sb.Append("UPDATE dbo.GoodsSpecificationKey SET IsDelete=1 WHERE CategoryId=@Id;");
            sb.Append("UPDATE dbo.GoodsCategory SET IsDelete=1 WHERE ParentId IN (SELECT Id FROM dbo.GoodsCategory WHERE Id=@Id);");
            sb.Append("UPDATE dbo.GoodsCategory SET IsDelete=1 WHERE Id=@Id;");
            SqlParameter[] para =
            {
                new SqlParameter("@Id",primaryKey.Id)
            };
            return db.Transaction(sb.ToString(), para);
        }

        /// <summary>
        /// 修改商品类别
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public int Edit(GoodsCategory category)
        {
            var sql = @"UPDATE  dbo.GoodsCategory 
                                                SET
                                                Name=@Name,
                                                Level=@Level,
                                                Icon=@Icon,
                                                ParentId=@ParentId,
                                                EditUserId=@EditUserId,
                                                EditTime=@EditTime
                                                WHERE Id=@Id";
            SqlParameter[] para =
            {
                new SqlParameter("@Id",category.Id),
                new SqlParameter("@Name",category.Name),
                new SqlParameter("@Level",category.Level),
                new SqlParameter("@Icon",category.Icon),
                new SqlParameter("@ParentId",category.ParentId),
                new SqlParameter("@EditUserId",category.EditUserId),
                new SqlParameter("@EditTime",category.EditTime)
            };
            return db.Insert(sql, para);
        }

        /// <summary>
        /// 按照主键读取商品类别
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public GoodsCategory GetById(PrimaryKey primaryKey)
        {
            var sql = @"SELECT  Id,
                                               Name,
                                               Level,
                                               Icon,
                                               ParentId,
                                               IsUsed,
                                               IsDelete,
                                               CreateUserId,
                                               CreateTime,
                                               EditUserId,
                                               EditTime FROM dbo.GoodsCategory WHERE Id=@Id";
            SqlParameter[] para =
            {
                new SqlParameter("@Id",primaryKey.Id)
            };
            return db.SingleOrDefault<GoodsCategory>(sql, para);
        }

        /// <summary>
        /// 按照级别读取商品类别
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public IList<GoodsCategory> GetByLevel(int level)
        {
            var sql = @"SELECT  Id,
                                               Name,
                                               Level,
                                               Icon,
                                               ParentId,
                                               IsUsed,
                                               IsDelete,
                                               CreateUserId,
                                               CreateTime,
                                               EditUserId,
                                               EditTime FROM dbo.GoodsCategory WHERE Level=@Level AND IsDelete=0";
            SqlParameter[] para =
            {
                new SqlParameter("@Level",level)
            };
            return db.FetchOrDefault<GoodsCategory>(sql, para);
        }

        /// <summary>
        /// 读取商品类别
        /// </summary>
        /// <returns></returns>
        public IList<GoodsCategory> GetByList()
        {
            var sql = @"SELECT  Id,
                                               Name,
                                               Level,
                                               Icon,
                                               ParentId,
                                               IsUsed,
                                               IsDelete,
                                               CreateUserId,
                                               CreateTime,
                                               EditUserId,
                                               EditTime FROM dbo.GoodsCategory WHERE IsDelete=0";
           
            return db.FetchOrDefault<GoodsCategory>(sql);
        }
    }
}
