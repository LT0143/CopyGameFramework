﻿//---------
//LT 2018.4.15
//-----

namespace CopyGameFramework.Download
{
    internal partial class DownloadManager
    {
        /// <summary>
        /// 下载任务的状态。
        /// </summary>
        private enum DownloadTaskStatus
        {
            /// <summary>
            /// 准备下载。
            /// </summary>
            Todo,
            /// <summary>
            /// 下载中。
            /// </summary>
            Doing,
            /// <summary>
            /// 下载完成。
            /// </summary>
            Done,
            /// <summary>
            /// 下载错误。
            /// </summary>
            Error
        }
    }
}
