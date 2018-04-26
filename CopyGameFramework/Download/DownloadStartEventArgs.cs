using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyGameFramework.Download
{
    /// <summary>
    /// 下载开始事件。
    /// </summary>
    public sealed class DownloadStartEventArgs : GameFrameworkEventArgs
    {

        public DownloadStartEventArgs(int serialId, string downloadPath, string downloadUri, int currentLength, object userData)
        {
            SerialId = serialId;
            DownloadPath = downloadPath;
            DownloadUri = downloadUri;
            CurrentLength = currentLength;
            UserData = userData;
        }

        /// <summary>
        /// 获取下载任务的序列编号。
        /// </summary>
        public int SerialId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取下载后存放路径。
        /// </summary>
        public string DownloadPath
        {
            get;
            private set;
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
        /// 获取当前大小。
        /// </summary>
        public int CurrentLength
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取用户自定义数据。
        /// </summary>
        public object UserData
        {
            get;
            private set;
        }

    }
}
