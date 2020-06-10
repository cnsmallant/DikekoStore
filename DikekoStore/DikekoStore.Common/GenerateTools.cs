using System;
using System.Collections.Generic;
using System.Text;

namespace DikekoStore.Common
{
    /// <summary>
    /// 生成工具类
    /// </summary>
    public class GenerateTools
    {
        /// <summary>
        /// 生成主键
        /// </summary>
        /// <returns></returns>
        public static string  PrimaryKey()
        {
          return  Guid.NewGuid().ToString("N");
        }
    }
}
