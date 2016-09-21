// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : LoggerBase.cs
//          description :
//  
//          created by 李文强 at  2016/09/21 16:17
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub : https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System;

namespace Magicodes.Logger
{
    /// <summary>
    ///     日志记录基类
    /// </summary>
    public abstract class LoggerBase
    {
        public delegate void LogEventHandler(object sender, LogEventArgs e);

        /// <summary>
        ///     新建日志记录器
        /// </summary>
        /// <param name="name">日志记录器名称</param>
        public LoggerBase(string name)
        {
            Name = name;
        }

        /// <summary>
        ///     日志记录器名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     日志记录事件
        /// </summary>
        public event LogEventHandler OnLog;

        /// <summary>
        ///     记录日志完成时执行，以触发日志事件
        /// </summary>
        /// <param name="loggerLevels">日志等级</param>
        /// <param name="message">日志消息</param>
        /// <param name="ex">异常信息</param>
        protected void ExcutedOnLog(LoggerLevels loggerLevels, object message, Exception ex = null)
        {
            if (OnLog == null) return;
            var e = new LogEventArgs
            {
                Exception = ex,
                loggerLevels = loggerLevels,
                Message = message
            };
            OnLog(null, e);
        }

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志等级</param>
        /// <param name="message">日志消息</param>
        public abstract void Log(LoggerLevels loggerLevels, object message);

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志等级</param>
        /// <param name="message">日志消息</param>
        /// <param name="exception">异常信息</param>
        public abstract void Log(LoggerLevels loggerLevels, object message, Exception exception);

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志等级</param>
        /// <param name="format">format字符串</param>
        /// <param name="args">日志参数</param>
        public abstract void LogFormat(LoggerLevels loggerLevels, string format, params object[] args);

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志等级</param>
        /// <param name="format">format字符串</param>
        /// <param name="exception">异常信息</param>
        /// <param name="args">日志参数</param>
        public abstract void LogFormat(LoggerLevels loggerLevels, string format, Exception exception,
            params object[] args);

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志等级</param>
        /// <param name="formatProvider">format提供程序</param>
        /// <param name="format">format字符串</param>
        /// <param name="args">日志参数</param>
        public abstract void LogFormat(LoggerLevels loggerLevels, IFormatProvider formatProvider, string format,
            params object[] args);

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志等级</param>
        /// <param name="formatProvider">format提供程序</param>
        /// <param name="format">format字符串</param>
        /// <param name="exception">异常信息</param>
        /// <param name="args">日志参数</param>
        public abstract void LogFormat(LoggerLevels loggerLevels, IFormatProvider formatProvider, string format,
            Exception exception
            , params object[] args);
    }
}