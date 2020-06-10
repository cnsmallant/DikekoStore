using System;
using System.Collections.Generic;
using System.Text;
using static DikekoStore.Common.Enumerate;

namespace DikekoStore.Model.Common
{
    /// <summary>
    /// 分页
    /// </summary>
    public class Page
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int CurrentPage { get; set; }
        /// <summary>
        /// 每页项数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SortEnum Sort { get; set; }
    }
}
