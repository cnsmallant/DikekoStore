using DikekoStore.Platform.Interface;
using DikekoStore.Platform.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Platform.Context
{
    public class ServiceContext
    {
        /// <summary>
        /// 当前选择
        /// </summary>
        public static ServiceContext Current
        {
            get
            {
                return new ServiceContext();
            }
        }

        /// <summary>
        /// 管理员实例化
        /// </summary>
        public IManager ManagerService = new ManagerService();
    }
}
