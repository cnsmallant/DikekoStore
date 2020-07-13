using System;
using System.ComponentModel;

namespace DikekoStore.Common
{


    /// <summary>
    /// 业务返回状态码
    /// </summary>
    public enum StatusCodeEnum
    {
        /// <summary>
        /// 请求成功
        /// </summary>
        [Description("请求成功")]
        OK = 200,
        /// <summary>
        /// 当前请求暂无数据返回
        /// </summary>
        [Description("当前请求暂无数据返回")]
        NoContent = 204,
        /// <summary>
        /// 请求失败
        /// </summary>
        [Description("请求失败")]
        BadRequest = 400,
        /// <summary>
        /// 当前请求需要用户授权
        /// </summary>
        [Description("当前请求需要用户授权")]
        Unauthorized = 401,
        /// <summary>
        /// 当前请求权限不足
        /// </summary>
        [Description("当前请求权限不足")]
        Forbidden = 403,
        /// <summary>
        /// 当前请求资源不存在
        /// </summary>
        [Description("当前请求资源不存在")]
        NotFound = 404,
        /// <summary>
        /// 请求超时
        /// </summary>
        [Description("请求超时")]
        RequestTimeout = 408,
        /// <summary>
        /// 服务器发生未知错误
        /// </summary>
        [Description("服务器发生未知错误")]
        InternalServerError = 500,
        /// <summary>
        /// 服务器不支持当前请求所需要的功能
        /// </summary>
        [Description("服务器不支持当前请求所需要的功能")]
        NotImplemented = 501,
        /// <summary>
        /// 服务器当前无法处理请求
        /// </summary>
        [Description("服务器当前无法处理请求")]
        ServiceUnavailable = 503,
    }
    /// <summary>
    /// 响应状态描述
    /// </summary>
    public enum ResponseDescriptionEnum
    {
        /// <summary>
        /// 帐号或密码错误
        /// </summary>
        [Description("帐号或密码错误")]
        AccountOrPasswordError,

        /// <summary>
        /// 暂无数据
        /// </summary>
        [Description("暂无数据")]
        NoData
    }
    /// <summary>
    /// 枚举
    /// </summary>
    public class Enumerate
    {
        #region 排序
        /// <summary>
        /// 排序
        /// </summary>
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

        #region 排序字段
        /// <summary>
        /// 排序字段
        /// </summary>
        public enum SortField
        {
            /// <summary>
            /// 综合
            /// </summary>
            [Description("综合")]
            Integration = 0,
            /// <summary>
            /// 新品
            /// </summary>
            [Description("新品")]
            NTS = 1,
            /// <summary>
            /// 销量
            /// </summary>
            [Description("销量")]
            Sales = 2,
            /// <summary>
            /// 价格
            /// </summary>
            [Description("价格")]
            Price = 3,
        }
        #endregion
    }
}
