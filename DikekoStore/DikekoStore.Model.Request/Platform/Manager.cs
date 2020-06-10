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
}
