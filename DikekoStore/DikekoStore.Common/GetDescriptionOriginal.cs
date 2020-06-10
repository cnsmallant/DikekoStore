using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DikekoStore.Common
{
    /// <summary>
    /// 获取描述
    /// </summary>
    public static class GetDescriptionOriginal
    {
        /// <summary>
        /// 获取描述
        /// </summary>
        public static string GetDescription(this Enum @this)
        {
            var name = @this.ToString();
            var field = @this.GetType().GetField(name);
            if (field == null) return name;
            var att = System.Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute), false);
            return att == null ? field.Name : ((DescriptionAttribute)att).Description;
        }
    }
}
