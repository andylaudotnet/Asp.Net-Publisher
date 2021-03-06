﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   服务器响应客户端的消息目标枚举.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Asp.Net.Publisher.Common
{
    /// <summary>
    /// 服务器响应客户端的消息目标枚举.
    /// </summary>
    public enum ResponseMessageAction : byte
    {
        /// <summary>
        /// 无法继续.
        /// </summary>
        Stop = 0,

        /// <summary>
        /// 允许继续.
        /// </summary>
        Go = 1,

        /// <summary>
        /// 询问.
        /// </summary>
        Ask = 2
    }
}
