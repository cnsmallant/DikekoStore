
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dikeko.ORM.Core;
namespace Dikeko.ORM.Core.Model 
 {
[TableName("OrderAppraise")]
public class OrderAppraise
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///描述分
 /// </summary>
[Column("DescriptionPoints")]
public  int  DescriptionPoints{ get; set; }
/// <summary>
///服务分
 /// </summary>
[Column("ServicePoints")]
public  int  ServicePoints{ get; set; }
/// <summary>
///物流分
 /// </summary>
[Column("LogisticsPoints")]
public  int  LogisticsPoints{ get; set; }
/// <summary>
///评价内容
 /// </summary>
[Column("Content")]
public  string  Content{ get; set; }
/// <summary>
///评价图片（3张图片 json格式保存）
 /// </summary>
[Column("Pictures")]
public  string  Pictures{ get; set; }
/// <summary>
///订单Id
 /// </summary>
[Column("OrderId")]
public  string  OrderId{ get; set; }
/// <summary>
///订单编号
 /// </summary>
[Column("OrderCode")]
public  string  OrderCode{ get; set; }
/// <summary>
///商品ID
 /// </summary>
[Column("GoodsId")]
public  string  GoodsId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("OrderHistory")]
public class OrderHistory
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///订单ID
 /// </summary>
[Column("OrderId")]
public  string  OrderId{ get; set; }
/// <summary>
///描述（json格式数据）
 /// </summary>
[Column("Description")]
public  string  Description{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("AfterSale")]
public class AfterSale
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///订单ID
 /// </summary>
[Column("OrderId")]
public  string  OrderId{ get; set; }
/// <summary>
///订单编号
 /// </summary>
[Column("OrderCode")]
public  string  OrderCode{ get; set; }
/// <summary>
///售后单号
 /// </summary>
[Column("Code")]
public  string  Code{ get; set; }
/// <summary>
///售后类型（0-仅退款 1-退货退款）
 /// </summary>
[Column("Type")]
public  int  Type{ get; set; }
/// <summary>
///申请原因
 /// </summary>
[Column("Reason")]
public  string  Reason{ get; set; }
/// <summary>
///售后状态（0-申请中 1-已完成 2-已关闭）
 /// </summary>
[Column("Status")]
public  int  Status{ get; set; }
/// <summary>
///售后结果（0-待处理 1-同意 2-拒绝）
 /// </summary>
[Column("Result")]
public  int  Result{ get; set; }
/// <summary>
///申请人
 /// </summary>
[Column("UserId")]
public  string  UserId{ get; set; }
/// <summary>
///处理人
 /// </summary>
[Column("Conductor")]
public  string  Conductor{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("AfterSaleHistory")]
public class AfterSaleHistory
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///售后Id
 /// </summary>
[Column("AfterSaleId")]
public  string  AfterSaleId{ get; set; }
/// <summary>
///描述（json字段）
 /// </summary>
[Column("Description")]
public  string  Description{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("AfterSaleReason")]
public class AfterSaleReason
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///原因
 /// </summary>
[Column("Reason")]
public  string  Reason{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("AfterSaleLogistics")]
public class AfterSaleLogistics
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///售后Id
 /// </summary>
[Column("AfterSaleId")]
public  string  AfterSaleId{ get; set; }
/// <summary>
///退货快递单号
 /// </summary>
[Column("TrackingNumber")]
public  string  TrackingNumber{ get; set; }
/// <summary>
///退货快递公司
 /// </summary>
[Column("ExpressName")]
public  string  ExpressName{ get; set; }
/// <summary>
///退货快递公司编码
 /// </summary>
[Column("ExpressCode")]
public  string  ExpressCode{ get; set; }
/// <summary>
///退货发货时间（时间戳）
 /// </summary>
[Column("DeliveryTime")]
public  long  DeliveryTime{ get; set; }
/// <summary>
///退货商户收货时间（时间戳）
 /// </summary>
[Column("ReceiptTime")]
public  long  ReceiptTime{ get; set; }
/// <summary>
///状态（0-待发货 1-待收货 2-已签收）
 /// </summary>
[Column("Status")]
public  string  Status{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("Areas")]
public class Areas
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  int  Id{ get; set; }
/// <summary>
///名称
 /// </summary>
[Column("Name")]
public  string  Name{ get; set; }
/// <summary>
///父键
 /// </summary>
[Column("ParentId")]
public  int  ParentId{ get; set; }
/// <summary>
///级别
 /// </summary>
[Column("Level")]
public  string  Level{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("ImageFolder")]
public class ImageFolder
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///文件夹名字
 /// </summary>
[Column("Name")]
public  string  Name{ get; set; }
/// <summary>
///文件夹级别
 /// </summary>
[Column("ParentId")]
public  string  ParentId{ get; set; }
/// <summary>
///文件夹级别
 /// </summary>
[Column("Level")]
public  int  Level{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("ImageSpace")]
public class ImageSpace
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///图片原名
 /// </summary>
[Column("OriginalName")]
public  string  OriginalName{ get; set; }
/// <summary>
///图片路径
 /// </summary>
[Column("Path")]
public  string  Path{ get; set; }
/// <summary>
///图片MD5值
 /// </summary>
[Column("MD5")]
public  string  MD5{ get; set; }
/// <summary>
///图片文件夹
 /// </summary>
[Column("ImageFolderId")]
public  string  ImageFolderId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("VerificationCode")]
public class VerificationCode
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///手机号
 /// </summary>
[Column("PhoneNumber")]
public  string  PhoneNumber{ get; set; }
/// <summary>
///验证码
 /// </summary>
[Column("Code")]
public  string  Code{ get; set; }
/// <summary>
///到期时间（时间戳）
 /// </summary>
[Column("ExpireTime")]
public  long  ExpireTime{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("Express")]
public class Express
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///名称
 /// </summary>
[Column("Name")]
public  string  Name{ get; set; }
/// <summary>
///编码
 /// </summary>
[Column("Code")]
public  string  Code{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("Manager")]
public class Manager
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///账号
 /// </summary>
[Column("Account")]
public  string  Account{ get; set; }
/// <summary>
///密码
 /// </summary>
[Column("Password")]
public  string  Password{ get; set; }
/// <summary>
///手机号
 /// </summary>
[Column("PhoneNumber")]
public  string  PhoneNumber{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("UserBase")]
public class UserBase
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///用户昵称
 /// </summary>
[Column("NickName")]
public  string  NickName{ get; set; }
/// <summary>
///帐号头像
 /// </summary>
[Column("Avatar")]
public  string  Avatar{ get; set; }
/// <summary>
///登陆账号（随机6位数）
 /// </summary>
[Column("Account")]
public  string  Account{ get; set; }
/// <summary>
///登录密码
 /// </summary>
[Column("PassWord")]
public  string  PassWord{ get; set; }
/// <summary>
///手机号码
 /// </summary>
[Column("PhoneNumber")]
public  string  PhoneNumber{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("UserExtension")]
public class UserExtension
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///WxOpenId
 /// </summary>
[Column("WxOpenId")]
public  string  WxOpenId{ get; set; }
/// <summary>
///AliapyOpenId
 /// </summary>
[Column("AliapyOpenId")]
public  string  AliapyOpenId{ get; set; }
/// <summary>
///用户基表ID
 /// </summary>
[Column("UserId")]
public  string  UserId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("UserCertification")]
public class UserCertification
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///真实姓名
 /// </summary>
[Column("RealName")]
public  string  RealName{ get; set; }
/// <summary>
///生日
 /// </summary>
[Column("Birthday")]
public  string  Birthday{ get; set; }
/// <summary>
///性别（0-男 1-女）
 /// </summary>
[Column("Gender")]
public  int  Gender{ get; set; }
/// <summary>
///身份证号码
 /// </summary>
[Column("IdCardNumber")]
public  string  IdCardNumber{ get; set; }
/// <summary>
///用户基表ID
 /// </summary>
[Column("UserId")]
public  string  UserId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("UserAddress")]
public class UserAddress
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///姓名
 /// </summary>
[Column("UserName")]
public  string  UserName{ get; set; }
/// <summary>
///省
 /// </summary>
[Column("Province")]
public  string  Province{ get; set; }
/// <summary>
///市
 /// </summary>
[Column("City")]
public  string  City{ get; set; }
/// <summary>
///县
 /// </summary>
[Column("County")]
public  string  County{ get; set; }
/// <summary>
///详细地址
 /// </summary>
[Column("Address")]
public  string  Address{ get; set; }
/// <summary>
///是否默认
 /// </summary>
[Column("Isdefault")]
public  string  Isdefault{ get; set; }
/// <summary>
///用户基表ID
 /// </summary>
[Column("UserId")]
public  string  UserId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("Goods")]
public class Goods
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///标题
 /// </summary>
[Column("Title")]
public  string  Title{ get; set; }
/// <summary>
///类别
 /// </summary>
[Column("CategoryId")]
public  string  CategoryId{ get; set; }
/// <summary>
///封面
 /// </summary>
[Column("Cover")]
public  string  Cover{ get; set; }
/// <summary>
///规格信息（json格式）
 /// </summary>
[Column("Specification")]
public  string  Specification{ get; set; }
/// <summary>
///主图（json格式）
 /// </summary>
[Column("MainFigure")]
public  string  MainFigure{ get; set; }
/// <summary>
///内容
 /// </summary>
[Column("Content")]
public  string  Content{ get; set; }
/// <summary>
///是否淘宝宝贝
 /// </summary>
[Column("IsTaoBao")]
public  bool  IsTaoBao{ get; set; }
/// <summary>
///淘口令
 /// </summary>
[Column("TaoWord")]
public  string  TaoWord{ get; set; }
/// <summary>
///原价（以分为单位）
 /// </summary>
[Column("OriginalPrice")]
public  long  OriginalPrice{ get; set; }
/// <summary>
///售价（以分为单位）
 /// </summary>
[Column("Price")]
public  long  Price{ get; set; }
/// <summary>
///运费模版
 /// </summary>
[Column("FreightTemplateId")]
public  string  FreightTemplateId{ get; set; }
/// <summary>
///是否上架
 /// </summary>
[Column("IsShelves")]
public  bool  IsShelves{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsCategory")]
public class GoodsCategory
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///名称
 /// </summary>
[Column("Name")]
public  string  Name{ get; set; }
/// <summary>
///级别
 /// </summary>
[Column("Level")]
public  int  Level{ get; set; }
/// <summary>
///图标
 /// </summary>
[Column("Icon")]
public  string  Icon{ get; set; }
/// <summary>
///父键
 /// </summary>
[Column("ParentId")]
public  string  ParentId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsPropertyKey")]
public class GoodsPropertyKey
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///名称
 /// </summary>
[Column("Name")]
public  string  Name{ get; set; }
/// <summary>
///类别
 /// </summary>
[Column("CategoryId")]
public  string  CategoryId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsPropertyVal")]
public class GoodsPropertyVal
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///名称
 /// </summary>
[Column("Name")]
public  string  Name{ get; set; }
/// <summary>
///属性键
 /// </summary>
[Column("PropertyKeyId")]
public  string  PropertyKeyId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsSpecificationKey")]
public class GoodsSpecificationKey
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///名称
 /// </summary>
[Column("Name")]
public  string  Name{ get; set; }
/// <summary>
///类别
 /// </summary>
[Column("CategoryId")]
public  string  CategoryId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsSpecificationVal")]
public class GoodsSpecificationVal
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///名称
 /// </summary>
[Column("Name")]
public  string  Name{ get; set; }
/// <summary>
///规格键
 /// </summary>
[Column("SpecificationKeyId")]
public  string  SpecificationKeyId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsSku")]
public class GoodsSku
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///名称
 /// </summary>
[Column("Name")]
public  string  Name{ get; set; }
/// <summary>
///原价（以分为单位）
 /// </summary>
[Column("OriginalPrice")]
public  long  OriginalPrice{ get; set; }
/// <summary>
///售价（以分为单位）
 /// </summary>
[Column("Price")]
public  long  Price{ get; set; }
/// <summary>
///库存
 /// </summary>
[Column("Stock")]
public  int  Stock{ get; set; }
/// <summary>
///SKU-Id组合（json格式）
 /// </summary>
[Column("SkuIdGroup")]
public  string  SkuIdGroup{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsMirror")]
public class GoodsMirror
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///标题
 /// </summary>
[Column("Title")]
public  string  Title{ get; set; }
/// <summary>
///类别
 /// </summary>
[Column("CategoryId")]
public  string  CategoryId{ get; set; }
/// <summary>
///封面
 /// </summary>
[Column("Cover")]
public  string  Cover{ get; set; }
/// <summary>
///规格信息（json格式）
 /// </summary>
[Column("Specification")]
public  string  Specification{ get; set; }
/// <summary>
///主图（json格式）
 /// </summary>
[Column("MainFigure")]
public  string  MainFigure{ get; set; }
/// <summary>
///内容
 /// </summary>
[Column("Content")]
public  string  Content{ get; set; }
/// <summary>
///是否淘宝宝贝
 /// </summary>
[Column("IsTaoBao")]
public  bool  IsTaoBao{ get; set; }
/// <summary>
///淘口令
 /// </summary>
[Column("TaoWord")]
public  string  TaoWord{ get; set; }
/// <summary>
///原价（以分为单位）
 /// </summary>
[Column("OriginalPrice")]
public  long  OriginalPrice{ get; set; }
/// <summary>
///售价（以分为单位）
 /// </summary>
[Column("Price")]
public  long  Price{ get; set; }
/// <summary>
///运费模版
 /// </summary>
[Column("FreightTemplateId")]
public  string  FreightTemplateId{ get; set; }
/// <summary>
///是否上架
 /// </summary>
[Column("IsShelves")]
public  bool  IsShelves{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsCollect")]
public class GoodsCollect
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///商品ID
 /// </summary>
[Column("GoodsId")]
public  string  GoodsId{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsFreightTemplate")]
public class GoodsFreightTemplate
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///区域（储存格式：北京，天津，上海）
 /// </summary>
[Column("Area")]
public  string  Area{ get; set; }
/// <summary>
///是否包邮
 /// </summary>
[Column("IsFreeShipping")]
public  bool  IsFreeShipping{ get; set; }
/// <summary>
///运费（以分为单位）
 /// </summary>
[Column("Freight")]
public  long  Freight{ get; set; }
/// <summary>
///退货地址
 /// </summary>
[Column("ReturnAddress")]
public  string  ReturnAddress{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("GoodsPackage")]
public class GoodsPackage
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///主商品
 /// </summary>
[Column("GoodsId")]
public  string  GoodsId{ get; set; }
/// <summary>
///搭配商品（json格式存储）
 /// </summary>
[Column("MatchGoodsId")]
public  string  MatchGoodsId{ get; set; }
/// <summary>
///价格（以分为单位）
 /// </summary>
[Column("Price")]
public  long  Price{ get; set; }
/// <summary>
///套餐数量
 /// </summary>
[Column("Quantity")]
public  int  Quantity{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("ShoppingCart")]
public class ShoppingCart
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///商品ID
 /// </summary>
[Column("GoodsId")]
public  string  GoodsId{ get; set; }
/// <summary>
///数量
 /// </summary>
[Column("Quantity")]
public  int  Quantity{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("Orders")]
public class Orders
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///订单号
 /// </summary>
[Column("Code")]
public  string  Code{ get; set; }
/// <summary>
///支付方式（0-支付宝，1-微信支付）
 /// </summary>
[Column("PaymentMethod")]
public  int  PaymentMethod{ get; set; }
/// <summary>
///统一付款码
 /// </summary>
[Column("UniformPaymentCode")]
public  string  UniformPaymentCode{ get; set; }
/// <summary>
///付款时间（时间戳）
 /// </summary>
[Column("PaymentTime")]
public  long  PaymentTime{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("OrderItem")]
public class OrderItem
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///子订单号
 /// </summary>
[Column("Code")]
public  string  Code{ get; set; }
/// <summary>
///订单Id
 /// </summary>
[Column("OrderId")]
public  string  OrderId{ get; set; }
/// <summary>
///商品Id
 /// </summary>
[Column("GoodsId")]
public  string  GoodsId{ get; set; }
/// <summary>
///商品镜像Id
 /// </summary>
[Column("GoodsMirrorId")]
public  string  GoodsMirrorId{ get; set; }
/// <summary>
///所选商品Sku-id
 /// </summary>
[Column("GoodsSkuId")]
public  string  GoodsSkuId{ get; set; }
/// <summary>
///所选商品Sku
 /// </summary>
[Column("GoodsSku")]
public  string  GoodsSku{ get; set; }
/// <summary>
///物流Id
 /// </summary>
[Column("OrderLogistics")]
public  string  OrderLogistics{ get; set; }
/// <summary>
///应付金额（以分为单位）
 /// </summary>
[Column("AmountPayable")]
public  long  AmountPayable{ get; set; }
/// <summary>
///运费（以分为单位）
 /// </summary>
[Column("Freight")]
public  long  Freight{ get; set; }
/// <summary>
///实付金额（以分为单位）
 /// </summary>
[Column("AmountActuallyPaid")]
public  long  AmountActuallyPaid{ get; set; }
/// <summary>
///状态（0-待付款 1-待收货 2-待评价 ）
 /// </summary>
[Column("Status")]
public  int  Status{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
[TableName("OrderLogistics")]
public class OrderLogistics
{
/// <summary>
///主键
 /// </summary>
[Column("Id")]
[PrimaryKey("Id",false)]
public  string  Id{ get; set; }
/// <summary>
///收货人
 /// </summary>
[Column("Receiver")]
public  string  Receiver{ get; set; }
/// <summary>
///收货人联系方式
 /// </summary>
[Column("ReceiverPhone")]
public  string  ReceiverPhone{ get; set; }
/// <summary>
///收货人地址
 /// </summary>
[Column("ReceiverAddress")]
public  string  ReceiverAddress{ get; set; }
/// <summary>
///快递单号
 /// </summary>
[Column("TrackingNumber")]
public  string  TrackingNumber{ get; set; }
/// <summary>
///快递公司
 /// </summary>
[Column("ExpressName")]
public  string  ExpressName{ get; set; }
/// <summary>
///快递编码
 /// </summary>
[Column("ExpressCode")]
public  string  ExpressCode{ get; set; }
/// <summary>
///发货时间（时间戳）
 /// </summary>
[Column("DeliveryTime")]
public  long  DeliveryTime{ get; set; }
/// <summary>
///收货时间（时间戳）
 /// </summary>
[Column("ReceiptTime")]
public  long  ReceiptTime{ get; set; }
/// <summary>
///状态（0-待发货 1-待收货 2-已签收）
 /// </summary>
[Column("Status")]
public  string  Status{ get; set; }
/// <summary>
///是否延长收货
 /// </summary>
[Column("IsExtend")]
public  bool  IsExtend{ get; set; }
/// <summary>
///延长收货时间（时间戳）
 /// </summary>
[Column("ExtendReceiptTime")]
public  long  ExtendReceiptTime{ get; set; }
/// <summary>
///是否启用
 /// </summary>
[Column("IsUsed")]
public  bool  IsUsed{ get; set; }
/// <summary>
///是否删除
 /// </summary>
[Column("IsDelete")]
public  bool  IsDelete{ get; set; }
/// <summary>
///创建人
 /// </summary>
[Column("CreateUserId")]
public  string  CreateUserId{ get; set; }
/// <summary>
///创建时间（时间戳）
 /// </summary>
[Column("CreateTime")]
public  long  CreateTime{ get; set; }
/// <summary>
///修改人
 /// </summary>
[Column("EditUserId")]
public  string  EditUserId{ get; set; }
/// <summary>
///修改时间（时间戳）
 /// </summary>
[Column("EditTime")]
public  long  EditTime{ get; set; }
}
}


