/// <summary>
/// LT 2018.6.3
/// </summary>

namespace CopyGameFramework.Resource
{
    public sealed class ResourceUpdateStartEventArgs:GameFrameworkEventArgs
    {


        public ResourceUpdateStartEventArgs(string name,string downloadPath,string downloadUri,int currentLength,int zipLength,int retryCount)
        {
            Name = name;
            DownloadPath = downloadPath;
            DownloadUri = downloadUri;
            CurrentLength = currentLength;
            ZipLength = zipLength;
            RetryCount = retryCount;
        }

        /// <summary>
        /// 获取资源名称。
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取资源下载后存放路径。
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
        /// 获取当前下载大小。
        /// </summary>
        public int CurrentLength
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取压缩包大小。
        /// </summary>
        public int ZipLength
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取已重试下载次数。
        /// </summary>
        public int RetryCount
        {
            get;
            private set;
        }
    }
}
