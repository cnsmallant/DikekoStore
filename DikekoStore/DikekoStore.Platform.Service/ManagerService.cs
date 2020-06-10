using Dikeko.ORM.Core.Model;
using DikekoStore.Common;
using DikekoStore.Model.Common;
using DikekoStore.Model.Request.Platform;
using DikekoStore.Platform.Interface;
using System;
using System.Collections.Generic;
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
                                               (   N'{manager.Id}',  -- Id - nvarchar(50)
                                                   N'{manager.Account}',  -- Account - nvarchar(50)
                                                   N'{manager.Password}',  -- Password - nvarchar(max)
                                                   N'{manager.PhoneNumber}',  -- PhoneNumber - nvarchar(50)
                                                   1, -- IsUsed - bit
                                                   0, -- IsDelete - bit
                                                   N'{manager.CreateUserId}',  -- CreateUserId - nvarchar(50)
                                                   '{manager.CreateTime}',    -- CreateTime - bigint
                                                   N'{manager.EditUserId}',  -- EditUserId - nvarchar(50)
                                                   '{manager.EditTime}'     -- EditTime - bigint
                                                   )";
            return db.Insert(sql);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public int Delete(PrimaryKey primaryKey)
        {
            var sql = $"UPDATE Manager SET IsDelete=1 WHERE Id='{primaryKey}'";
            return db.Update(sql);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        public int Edit(Manager manager)
        {
            var sql = @$"UPDATE Manager SET
                                  Account='{manager.Account}'
                                 ,Password='{manager.Password}'
                                 ,PhoneNumber='{manager.PhoneNumber}'
                                 ,IsUsed='{manager.IsUsed}'
                                 ,IsDelete='{manager.IsDelete}'
                                 ,EditUserId='{manager.EditUserId}'
                                 ,EditTime='{manager.EditTime}'
                                 WHERE Id='{manager.Id}'";
            return db.Update(sql);
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="managerLogin"></param>
        /// <returns></returns>
        public Manager GetManager(ManagerLogin managerLogin)
        {
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
                                                    EditTime	FROM Manager ");
            if (RegExpTools.regPhone.IsMatch(managerLogin.Account))
            {
                sb.Append($"WHERE PhoneNumber='{managerLogin.Account}' AND Password='{managerLogin.Password}'");
            }
            else
            {
                sb.Append($"WHERE Account='{managerLogin.Account}' AND Password='{managerLogin.Password}'");
            }

            return db.SingleOrDefault<Manager>(sb.ToString());
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
                                                    EditTime	FROM Manager WHERE Id='{primaryKey}'";
            return db.SingleOrDefault<Manager>(sql);

        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public dynamic GetManagerByPage(ManagerPage page)
        {
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
                sb.Append($" AND Account LIKE '%{page.Account}%'");
            }
            if (!string.IsNullOrEmpty(page.PhoneNumber))
            {
                sb.Append($" AND PhoneNumber='{page.PhoneNumber}'");
            }
            sb.Append($" ORDER BY Id {page.Sort}");
            return db.PageOrDefault<Manager>(page.CurrentPage, page.PageSize, sb.ToString());
        }
    }
}
