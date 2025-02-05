﻿
using ZhonTai.Admin.Core.Entities;

namespace ZhonTai.Admin.Core.Auth
{
    /// <summary>
    /// 用户信息接口
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// 主键
        /// </summary>
        long Id { get; }

        /// <summary>
        /// 用户名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 昵称
        /// </summary>
        string NickName { get; }

        /// <summary>
        /// 租户Id
        /// </summary>
        long? TenantId { get; }

        /// <summary>
        /// 租户类型
        /// </summary>
        TenantType? TenantType { get; }

        /// <summary>
        /// 数据隔离
        /// </summary>
        DataIsolationType? DataIsolationType { get; }
    }
}