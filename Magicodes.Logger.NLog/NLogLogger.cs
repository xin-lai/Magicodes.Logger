// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : NLogLogger.cs
//          description :
//  
//          created by 李文强 at  2016/09/21 16:19
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub : https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System;
using NLog;

namespace Magicodes.Logger.NLog
{
    /// <summary>
    ///     NLOG日志记录器
    /// </summary>
    public class NLogLogger : LoggerBase
    {
        private readonly global::NLog.Logger _logger;

        public NLogLogger(string name) : base(name)
        {
            _logger = LogManager.GetLogger(name);
        }

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志级别</param>
        /// <param name="message">日志消息</param>
        public override void Log(LoggerLevels loggerLevels, object message)
        {
            switch (loggerLevels)
            {
                case LoggerLevels.Trace:
                    _logger.Trace(message);
                    break;
                case LoggerLevels.Debug:
                    _logger.Debug(message);
                    break;
                case LoggerLevels.Info:
                    _logger.Info(message);
                    break;
                case LoggerLevels.Warn:
                    _logger.Warn(message);
                    break;
                case LoggerLevels.Error:
                    _logger.Error(message);
                    break;
                case LoggerLevels.Fatal:
                    _logger.Fatal(message);
                    break;
                default:
                    break;
            }
            ExcutedOnLog(loggerLevels, message);
        }

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志级别</param>
        /// <param name="message">日志消息</param>
        /// <param name="exception">异常</param>
        public override void Log(LoggerLevels loggerLevels, object message, Exception exception)
        {
            switch (loggerLevels)
            {
                case LoggerLevels.Trace:
                    _logger.Trace(exception, message.ToString());
                    break;
                case LoggerLevels.Debug:
                    _logger.Debug(exception, message.ToString());
                    break;
                case LoggerLevels.Info:
                    _logger.Info(exception, message.ToString());
                    break;
                case LoggerLevels.Warn:
                    _logger.Warn(exception, message.ToString());
                    break;
                case LoggerLevels.Error:
                    _logger.Error(exception, message.ToString());
                    break;
                case LoggerLevels.Fatal:
                    _logger.Fatal(exception, message.ToString());
                    break;
                default:
                    break;
            }
            ExcutedOnLog(loggerLevels, message, exception);
        }

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志级别</param>
        /// <param name="format">格式化字符串</param>
        /// <param name="args">参数</param>
        public override void LogFormat(LoggerLevels loggerLevels, string format, params object[] args)
        {
            switch (loggerLevels)
            {
                case LoggerLevels.Trace:
                    _logger.Trace(format, args);
                    break;
                case LoggerLevels.Debug:
                    _logger.Debug(format, args);
                    break;
                case LoggerLevels.Info:
                    _logger.Info(format, args);
                    break;
                case LoggerLevels.Warn:
                    _logger.Warn(format, args);
                    break;
                case LoggerLevels.Error:
                    _logger.Error(format, args);
                    break;
                case LoggerLevels.Fatal:
                    _logger.Fatal(format, args);
                    break;
                default:
                    break;
            }
            ExcutedOnLog(loggerLevels, string.Format(format, args));
        }

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志级别</param>
        /// <param name="formatProvider">格式化提供程序</param>
        /// <param name="format">格式化字符串</param>
        /// <param name="args">参数</param>
        public override void LogFormat(LoggerLevels loggerLevels, IFormatProvider formatProvider, string format,
            params object[] args)
        {
            switch (loggerLevels)
            {
                case LoggerLevels.Trace:
                    _logger.Trace(formatProvider, format, args);
                    break;
                case LoggerLevels.Debug:
                    _logger.Debug(formatProvider, format, args);
                    break;
                case LoggerLevels.Info:
                    _logger.Info(formatProvider, format, args);
                    break;
                case LoggerLevels.Warn:
                    _logger.Warn(formatProvider, format, args);
                    break;
                case LoggerLevels.Error:
                    _logger.Error(formatProvider, format, args);
                    break;
                case LoggerLevels.Fatal:
                    _logger.Fatal(formatProvider, format, args);
                    break;
                default:
                    break;
            }
            ExcutedOnLog(loggerLevels, string.Format(formatProvider, format, args));
        }

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志级别</param>
        /// <param name="format">格式化字符串</param>
        /// <param name="exception">异常信息</param>
        /// <param name="args">参数</param>
        public override void LogFormat(LoggerLevels loggerLevels, string format, Exception exception,
            params object[] args)
        {
            switch (loggerLevels)
            {
                case LoggerLevels.Trace:
                    _logger.Trace(exception, format, args);
                    break;
                case LoggerLevels.Debug:
                    _logger.Debug(exception, format, args);
                    break;
                case LoggerLevels.Info:
                    _logger.Info(exception, format, args);
                    break;
                case LoggerLevels.Warn:
                    _logger.Warn(exception, format, args);
                    break;
                case LoggerLevels.Error:
                    _logger.Error(exception, format, args);
                    break;
                case LoggerLevels.Fatal:
                    _logger.Fatal(exception, format, args);
                    break;
                default:
                    break;
            }
            ExcutedOnLog(loggerLevels, string.Format(format, args), exception);
        }

        /// <summary>
        ///     记录日志
        /// </summary>
        /// <param name="loggerLevels">日志级别</param>
        /// <param name="formatProvider">格式化提供程序</param>
        /// <param name="format">格式化字符串</param>
        /// <param name="exception">异常信息</param>
        /// <param name="args">参数</param>
        public override void LogFormat(LoggerLevels loggerLevels, IFormatProvider formatProvider, string format,
            Exception exception, params object[] args)
        {
            switch (loggerLevels)
            {
                case LoggerLevels.Trace:
                    _logger.Trace(exception, formatProvider, format, args);
                    break;
                case LoggerLevels.Debug:
                    _logger.Debug(exception, formatProvider, format, args);
                    break;
                case LoggerLevels.Info:
                    _logger.Info(exception, formatProvider, format, args);
                    break;
                case LoggerLevels.Warn:
                    _logger.Warn(exception, formatProvider, format, args);
                    break;
                case LoggerLevels.Error:
                    _logger.Error(exception, formatProvider, format, args);
                    break;
                case LoggerLevels.Fatal:
                    _logger.Fatal(exception, formatProvider, format, args);
                    break;
                default:
                    break;
            }
            ExcutedOnLog(loggerLevels, string.Format(formatProvider, format, args), exception);
        }
    }
}