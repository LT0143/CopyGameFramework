﻿//--------------
//LT 2018.5.3
//----------------

namespace CopyGameFramework.Resource
{
    /// <summary>
    /// 游戏版本资源列表更新失败事件。
    /// </summary>
    public sealed  class VersionListUpdateFailureEventArgs : GameFrameworkEventArgs
    {
        /// <summary>
        /// 初始化版本资源列表更新失败事件的新实例。
        /// </summary>
        /// <param name="downloadUri">下载地址。</param>
        /// <param name="errorMessage">错误信息。</param>
        public VersionListUpdateFailureEventArgs(string downloadUri, string errorMessage)
        {
            DownloadUri = downloadUri;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// 获取下载地址。
        /// </summary>
        public string DownloadUri
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取错误信息。
        /// </summary>
        public string ErrorMessage
        {
            get;
            private set;
        }
    }
}
