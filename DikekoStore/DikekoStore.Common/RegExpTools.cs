using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DikekoStore.Common
{
    /// <summary>
    /// 正则表达式
    /// </summary>
    public class RegExpTools
    {
        public static Regex regPhone = new Regex(@"^1[3-9]\d{9}$");
    }
}
