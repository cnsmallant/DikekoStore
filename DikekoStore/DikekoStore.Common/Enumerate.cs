using System;
using System.ComponentModel;

namespace DikekoStore.Common
{
    /// <summary>
    /// 枚举
    /// </summary>
    public class Enumerate
    {
        #region 排序
        public enum SortEnum
        {
            /// <summary>
            /// 升序
            /// </summary>
            [Description("升序")]
            ASC,
            /// <summary>
            /// 降序
            /// </summary>
            [Description("降序")]
            DESC
        }
        #endregion
        }
}
