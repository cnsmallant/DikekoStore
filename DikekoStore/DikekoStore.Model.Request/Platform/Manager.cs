using DikekoStore.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Model.Request.Platform
{
    /// <summary>
    /// 登录
    /// </summary>
    public class ManagerLogin
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }

    /// <summary>
    /// 分页
    /// </summary>
    public class ManagerPage : Page
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public string PhoneNumber { get; set; }
    }

    /// <summary>
    /// 添加
    /// </summary>
    public class ManagerAdd
    {

      /// <summary>
      /// 帐号
      /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string PhoneNumber { get; set; }
       
    }

    /// <summary>
    /// 修改
    /// </summary>
    public class ManagerUpdate
    {

        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 帐号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string PhoneNumber { get; set; }

    }

}
