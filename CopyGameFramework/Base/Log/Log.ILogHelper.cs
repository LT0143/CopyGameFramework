
// <summary>
// LT 2018.3.31
// </summary>
namespace CopyGameFramework
{
    public static partial class Log
    {
        /// <summary>
        /// 日志辅助器接口
        /// </summary>
        public interface ILogHelper
        {
            /// <summary>
            /// 记录日志
            /// </summary>
            /// <param name="level"></param>
            /// <param name="message"></param>
            void Log(LogLevel level, object message);
        }
    }
}
