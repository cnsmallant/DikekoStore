using System;
using System.Net;
using Dikeko.ORM.Core.Model;
using DikekoStore.Common;
using DikekoStore.Model.Common;
using DikekoStore.Model.Request.Platform;
using DikekoStore.Platform.Service;

namespace DikekoStore.Platform.Business
{
    /// <summary>
    /// 管理员业务逻辑
    /// </summary>
    public class ManagerBusiness
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        public dynamic Add(ManagerAdd managerAdd)
        {
            Manager manager = new Manager
            {
                Id = Common.GenerateTools.PrimaryKey(),
                Account = managerAdd.Account,
                Password = Common.EncryptTools.EncryptToSHA256(managerAdd.Password),
                PhoneNumber = managerAdd.PhoneNumber,
                IsUsed = true,
                IsDelete = false,
                CreateUserId = string.Empty,
                CreateTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                EditUserId = string.Empty,
                EditTime = DateTimeOffset.Now.ToUnixTimeMilliseconds()
            };
            var result = Context.ServiceContext.Current.ManagerService.Add(manager);
            if (result > 0)
            {
                return new JsonResult(true, StatusCodeEnum.OK, StatusCodeEnum.OK.GetDescription());
            }
            else
            {
                return new JsonResult(true, StatusCodeEnum.BadRequest, HttpStatusCode.BadRequest.GetDescription());
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public dynamic Delete(PrimaryKey primaryKey)
        {
            var result = Context.ServiceContext.Current.ManagerService.Delete(primaryKey);
            if (result > 0)
            {
                return new JsonResult(true, StatusCodeEnum.OK, StatusCodeEnum.OK.GetDescription());
            }
            else
            {
                return new JsonResult(true, StatusCodeEnum.BadRequest, HttpStatusCode.BadRequest.GetDescription());
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        public dynamic Edit(ManagerUpdate managerUpdate)
        {
            Manager manager = new Manager
            {
                Id = managerUpdate.Id,
                Account = managerUpdate.Account,
                Password = Common.EncryptTools.EncryptToSHA256(managerUpdate.Password),
                PhoneNumber = managerUpdate.PhoneNumber,
                EditUserId = string.Empty,
                EditTime = DateTimeOffset.Now.ToUnixTimeMilliseconds()
            };
            var result = Context.ServiceContext.Current.ManagerService.Edit(manager);
            if (result > 0)
            {
                return new JsonResult(true, StatusCodeEnum.OK, StatusCodeEnum.OK.GetDescription());
            }
            else
            {
                return new JsonResult(true, StatusCodeEnum.BadRequest, HttpStatusCode.BadRequest.GetDescription());
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="managerLogin"></param>
        /// <returns></returns>
        public dynamic GetManager(ManagerLogin managerLogin)
        {
            ManagerLogin login = new ManagerLogin
            {
                Account = managerLogin.Account,
                Password = EncryptTools.EncryptToSHA256(managerLogin.Password)
            };
            var result = Context.ServiceContext.Current.ManagerService.GetManager(login);
            if (result != null)
            {
                return new JsonResult(true, StatusCodeEnum.OK, StatusCodeEnum.OK.GetDescription(), result, null);
            }
            else
            {
                return new JsonResult(true, StatusCodeEnum.BadRequest, ResponseDescriptionEnum.AccountOrPasswordError.GetDescription());

            }

        }

        /// <summary>
        /// 按照主键读取
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public dynamic GetManagerById(PrimaryKey primaryKey)
        {
            var result = Context.ServiceContext.Current.ManagerService.GetManagerById(primaryKey);
            return new JsonResult(true, StatusCodeEnum.OK, StatusCodeEnum.OK.GetDescription(), result, null);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public dynamic GetManagerByPage(ManagerPage page)
        {
            var result = Context.ServiceContext.Current.ManagerService.GetManagerByPage(page);
            return new JsonResult(true, StatusCodeEnum.OK, StatusCodeEnum.OK.GetDescription(), result, null);
        }
    }
}
