using Dikeko.ORM.Core.Model;
using DikekoStore.Common;
using DikekoStore.Model.Common;
using DikekoStore.Model.Request.Platform;
using DikekoStore.Platform.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using static DikekoStore.Common.Enumerate;

namespace DikekoStore.Platform.Service
{
    /// <summary>
    /// 管理员
    /// </summary>
    public class ManagerService : DataBase, IManager
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        public int Add(Manager manager)
        {
            var sql = $@"INSERT Manager
                                               (
                                                   Id,
                                                   Account,
                                                   Password,
                                                   PhoneNumber,
                                                   IsUsed,
                                                   IsDelete,
                                                   CreateUserId,
                                                   CreateTime,
                                                   EditUserId,
                                                   EditTime
                                               )
                                               VALUES
                                               (   
                                                   @Id,
                                                   @Account,
                                                   @Password,
                                                   @PhoneNumber,
                                                   @IsUsed,
                                                   @IsDelete,
                                                   @CreateUserId,
                                                   @CreateTime,
                                                   @EditUserId,
                                                   @EditTime
                                                   )";
            SqlParameter[] para =
            {
                new SqlParameter("@Id",manager.Id),
                new SqlParameter("@Account",manager.Account),
                new SqlParameter("@Password",manager.Password),
                new SqlParameter("@PhoneNumber",manager.PhoneNumber),
                new SqlParameter("@IsUsed",manager.IsUsed),
                new SqlParameter("@IsDelete",manager.IsDelete),
                new SqlParameter("@CreateUserId",manager.CreateUserId),
                new SqlParameter("@CreateTime",manager.CreateTime),
                new SqlParameter("@EditUserId",manager.EditUserId),
                new SqlParameter("@EditTime",manager.EditTime)

            };
            return db.Insert(sql, para);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public int Delete(PrimaryKey primaryKey)
        {
            var sql = $"UPDATE Manager SET IsDelete=1 WHERE Id=@Id";
            SqlParameter[] para =
            {
                new SqlParameter("@Id",primaryKey)
            };
            return db.Update(sql, para);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        public int Edit(Manager manager)
        {
            var sql = @$"UPDATE Manager SET
                                  Account=@Account
                                 ,Password=@Password
                                 ,PhoneNumber=@PhoneNumber
                                 ,EditUserId=@EditUserId
                                 ,EditTime=@EditTime
                                 WHERE Id=@Id
                                                          ";
            SqlParameter[] para =
            {
                new SqlParameter("@Id",manager.Id),
                new SqlParameter("@Account",manager.Account),
                new SqlParameter("@Password",manager.Password),
                new SqlParameter("@PhoneNumber",manager.PhoneNumber),
                new SqlParameter("@EditUserId",manager.EditUserId),
                new SqlParameter("@EditTime",manager.EditTime)
            };

            return db.Update(sql, para);
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="managerLogin"></param>
        /// <returns></returns>
        public Manager GetManager(ManagerLogin managerLogin)
        {
            StringBuilder sb = new StringBuilder();
            object[] para;
            sb.Append($@"SELECT Id,
                                                    Account,
                                                    Password,
                                                    PhoneNumber,
                                                    IsUsed,
                                                    IsDelete,
                                                    CreateUserId,
                                                    CreateTime,
                                                    EditUserId,
                                                    EditTime	FROM Manager ");
            if (RegExpTools.regPhone.IsMatch(managerLogin.Account))
            {
                sb.Append($"WHERE PhoneNumber=@PhoneNumber  AND Password=@Password");
                para = new SqlParameter[]
               {
                  new   SqlParameter("@PhoneNumber", managerLogin.Account),
                  new   SqlParameter("@Password", managerLogin.Password),
               };
            }
            else
            {
                sb.Append($"WHERE Account=@Account  AND Password=@Password");
                para = new SqlParameter[]
              {
                    new SqlParameter("@Password", managerLogin.Password),
                    new SqlParameter("@Account", managerLogin.Account),
               };
            }

            return db.SingleOrDefault<Manager>(sb.ToString(), para);
        }

        /// <summary>
        /// 按照主键读取
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public Manager GetManagerById(PrimaryKey primaryKey)
        {
            var sql = $@"SELECT Id,
                                                    Account,
                                                    Password,
                                                    PhoneNumber,
                                                    IsUsed,
                                                    IsDelete,
                                                    CreateUserId,
                                                    CreateTime,
                                                    EditUserId,
                                                    EditTime	FROM Manager WHERE Id=@Id";
            SqlParameter[] para =
            {
                new SqlParameter("@Id",primaryKey)
            };
            return db.SingleOrDefault<Manager>(sql, para);

        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public dynamic GetManagerByPage(ManagerPage page)
        {
            object[] para=null;
            StringBuilder sb = new StringBuilder();
            sb.Append($@"SELECT Id,
                                                    Account,
                                                    Password,
                                                    PhoneNumber,
                                                    IsUsed,
                                                    IsDelete,
                                                    CreateUserId,
                                                    CreateTime,
                                                    EditUserId,
                                                    EditTime	FROM Manager  WHERE 1=1");
            if (!string.IsNullOrEmpty(page.Account))
            {
                sb.Append($" AND Account LIKE @Account");
                para = new SqlParameter[]
                {
                    new SqlParameter("@Account",$"'%{page.Account}%'")
                };
            }
            if (!string.IsNullOrEmpty(page.PhoneNumber))
            {
                sb.Append($" AND PhoneNumber=@PhoneNumber");
                para = new SqlParameter[]
                {
                    new SqlParameter("@PhoneNumber",page.PhoneNumber)
                };
            }
            sb.Append($" ORDER BY Id {page.Sort}");
            return db.PageOrDefault<Manager>(page.CurrentPage, page.PageSize, sb.ToString(), 1, para);
        }
    }
}
