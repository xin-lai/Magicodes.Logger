// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : LogArgs.cs
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
    public class LogEventArgs
    {
        public Exception Exception { get; set; }
        public LoggerLevels LoggerLevels { get; set; }
        public object Message { get; set; }
        public object[] Args { get; set; }
    }
}