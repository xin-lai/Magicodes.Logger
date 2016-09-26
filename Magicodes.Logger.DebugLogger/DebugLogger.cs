// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : DebugLogger.cs
//          description :
//  
//          created by 李文强 at  2016/09/26 13:06
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System;
using System.Diagnostics;

namespace Magicodes.Logger.DebugLogger
{
    public class DebugLogger : LoggerBase
    {
        public DebugLogger(string name) : base(name)
        {
        }

        public override void Log(LoggerLevels loggerLevels, object message)
        {
            Debug.WriteLine("Name:{2};Level:{0};Msg:{1};Ex:{2}", loggerLevels, message, Name);
        }

        public override void Log(LoggerLevels loggerLevels, object message, Exception exception)
        {
            Debug.WriteLine("Name:{3};Level:{0};Msg:{1};Ex:{2}", loggerLevels, message, exception, Name);
        }

        public override void LogFormat(LoggerLevels loggerLevels, string format, params object[] args)
        {
            Debug.WriteLine("Name:{2};Level:{0};Msg:{1}", loggerLevels, string.Format(format, args), Name);
        }

        public override void LogFormat(LoggerLevels loggerLevels, string format, Exception exception,
            params object[] args)
        {
            Debug.WriteLine("Name:{3};Level:{0};Msg:{1};Ex:{2}", loggerLevels, string.Format(format, args), exception,
                Name);
        }

        public override void LogFormat(LoggerLevels loggerLevels, IFormatProvider formatProvider, string format,
            params object[] args)
        {
            var msg = string.Format(formatProvider, format, args);
            Debug.WriteLine("Name:{2};Level:{0};Msg:{1}", loggerLevels, msg, Name);
        }

        public override void LogFormat(LoggerLevels loggerLevels, IFormatProvider formatProvider, string format,
            Exception exception,
            params object[] args)
        {
            var msg = string.Format(formatProvider, format, args);
            Debug.WriteLine("Name:{3};Level:{0};Msg:{1};Ex:{2}", loggerLevels, msg, exception, Name);
        }
    }
}