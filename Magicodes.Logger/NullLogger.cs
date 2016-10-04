// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : NullLogger.cs
//          description :
//  
//          created by 李文强 at  2016/10/04 20:27
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub：https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System;

namespace Magicodes.Logger
{
    /// <summary>
    /// 日志记录器空实现，以防止报错
    /// </summary>
    public class NullLogger : LoggerBase
    {
        public NullLogger(string name) : base(name)
        {
        }

        public override void Log(LoggerLevels loggerLevels, object message)
        {
        }

        public override void Log(LoggerLevels loggerLevels, object message, Exception exception)
        {
        }

        public override void LogFormat(LoggerLevels loggerLevels, string format, params object[] args)
        {
        }

        public override void LogFormat(LoggerLevels loggerLevels, string format, Exception exception,
            params object[] args)
        {
        }

        public override void LogFormat(LoggerLevels loggerLevels, IFormatProvider formatProvider, string format,
            params object[] args)
        {
        }

        public override void LogFormat(LoggerLevels loggerLevels, IFormatProvider formatProvider, string format,
            Exception exception,
            params object[] args)
        {
        }
    }
}