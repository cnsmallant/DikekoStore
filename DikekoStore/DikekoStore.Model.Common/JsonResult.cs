using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

/// <summary>
/// json结果
/// </summary>
[DataContract]
public class JsonResult
{
    /// <summary>
    /// 标识
    /// </summary>
    [DataMember]
    public bool Flag { get; set; }

    /// <summary>
    /// 错误码
    /// </summary>
    [DataMember]
    public dynamic Code { get; set; }

    /// <summary>
    /// 错误信息
    /// </summary>
    [DataMember]
    public dynamic Message { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    [DataMember]
    [JsonProperty(PropertyName = "Count", NullValueHandling = NullValueHandling.Ignore)]
    public dynamic Count { get; set; }

    /// <summary>
    /// 数据
    /// </summary>
    [DataMember]
    [JsonProperty(PropertyName = "Data", NullValueHandling = NullValueHandling.Ignore)]
    public dynamic Data { get; set; }
    /// <summary>
    /// token
    /// </summary>
    [DataMember]
    [JsonProperty(PropertyName = "Token", NullValueHandling = NullValueHandling.Ignore)]
    public dynamic Token { get; set; }



    /// <summary>
    /// 返回结果
    /// </summary>
    /// <param name="flag">标识</param>
    /// <param name="code">返回码</param>
    /// <param name="message">返回信息</param>
    public JsonResult(bool flag, dynamic code, dynamic message)
    {
        Flag = flag;
        Code = code;
        Message = message;
    }

    /// <summary>
    /// 返回结果
    /// </summary>
    /// <param name="flag">标识</param>
    /// <param name="code">返回码</param>
    /// <param name="message">返回信息</param>
    ///<param name="data">返回数据</param>
    /// <param name="token">token</param>
    public JsonResult(bool flag, dynamic code, dynamic message, dynamic data, string token)
    {
        Flag = flag;
        Code = code;
        Message = message;
        if (string.IsNullOrEmpty(token))
        {
            if (data == null)
            {
                Data = string.Empty;
            }
            else
            {
                Data = data;
            }
        }
        else
        {
            Data = null;
        }
        Token = token;
    }

    /// <summary>
    /// 返回结果
    /// </summary>
    /// <param name="flag">标识</param>
    /// <param name="code">返回码</param>
    /// <param name="message">返回信息</param>
    /// <param name="count">返回数量</param>
    /// <param name="data">返回数据包</param>
    public JsonResult(bool flag, dynamic code, dynamic message, int count, dynamic data)
    {
        Flag = flag;
        Code = code;
        Message = message;
        Count = count;
        Data = data;
    }
}
