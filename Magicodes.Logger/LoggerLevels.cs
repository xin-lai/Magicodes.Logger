// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : LoggerLevels.cs
//          description :
//  
//          created by 李文强 at  2016/09/21 16:17
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub : https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

namespace Magicodes.Logger
{
    /// <summary>
    ///     日志级别
    /// </summary>
    public enum LoggerLevels
    {
        /// <summary>
        ///     跟踪
        /// </summary>
        Trace,

        /// <summary>
        ///     调试
        /// </summary>
        Debug,

        /// <summary>
        ///     信息
        /// </summary>
        Info,

        /// <summary>
        ///     警告
        /// </summary>
        Warn,

        /// <summary>
        ///     错误
        /// </summary>
        Error,

        /// <summary>
        ///     致命错误
        /// </summary>
        Fatal
    }
}