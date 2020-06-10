using Dikeko.ORM.Core.Model;
using DikekoStore.Model.Common;
using DikekoStore.Model.Request.Platform;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Platform.Interface
{
    /// <summary>
    /// 管理员表
    /// </summary>
    public interface IManager
    {
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="managerLogin"></param>
        /// <returns></returns>
        Manager GetManager(ManagerLogin managerLogin);
        /// <summary>
        /// 按照主键读取管理员
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        Manager GetManagerById(PrimaryKey  primaryKey);

        /// <summary>
        /// 分页读取
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        dynamic GetManagerByPage(ManagerPage page);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        int Add(Manager manager);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        int Edit(Manager manager);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        int Delete(PrimaryKey primaryKey);
    }
}
