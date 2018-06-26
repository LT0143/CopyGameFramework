//-------------
// LT 2018.6.25
//--------

using CopyGameFramework.Download;
using System;
using System.IO;

namespace CopyGameFramework.Resource
{
    internal partial class ResourceManager
    {
        private sealed class VersionListProcessor
        {
            private readonly ResourceManager m_ResourceManager;
            private IDownloadManager m_DownloadManager;
            private int m_VersionListLength;
            private int m_VersionListHashCode;
            private int m_VersionListZipLength;
            private int m_VersionListZipHashCode;

            public GameFrameworkAction<string, string> VersionListUpdateSuccess;
            public GameFrameworkAction<string, string> VersionListUpdateFailure;


            /// <summary>
            /// 初始化版本资源列表处理器的新实例。
            /// </summary>
            /// <param name="resourceManager">资源管理器。</param>
            public VersionListProcessor(ResourceManager resourceManager)
            {
                m_ResourceManager = resourceManager;
                m_DownloadManager = null;
                m_VersionListLength = 0;
                m_VersionListHashCode = 0;
                m_VersionListZipLength = 0;
                m_VersionListZipHashCode = 0;

                VersionListUpdateSuccess = null;
                VersionListUpdateFailure = null;
            }

            /// <summary>
            /// 关闭并清理版本资源列表处理器。
            /// </summary>
            public void Shutdown()
            {
                if (m_DownloadManager != null)
                {
                    m_DownloadManager.DownloadSuccess -= OnDownloadSuccess;
                    m_DownloadManager.DownloadFailure -= OnDownloadFailure;
                }
            }

            /// <summary>
            /// 设置下载管理器。
            /// </summary>
            /// <param name="downloadManager">下载管理器。</param>
            public void SetDownloadManager(IDownloadManager downloadManager)
            {
                if (downloadManager == null)
                {
                    throw new GameFrameworkException("Download manager is invalid.");
                }

                m_DownloadManager = downloadManager;
                m_DownloadManager.DownloadSuccess += OnDownloadSuccess;
                m_DownloadManager.DownloadFailure += OnDownloadFailure;
            }

            /// <summary>
            /// 检查版本资源列表。
            /// </summary>
            /// <param name="latestInternalResourceVersion">最新的资源内部版本号。</param>
            /// <returns>检查版本资源列表结果。</returns>
            public CheckVersionListResult CheckVersionList(int latestInternalResourceVersion)
            {
                string applicableGameVersion = null;
                int internalResourceVersion = 0;

                string versionListFileName = Utility.Path.GetCombinePath(m_ResourceManager.m_ReadWritePath, Utility.Path.GetResourceNameWithSuffix(versionListFileName));
                if (!File.Exists(versionListFileName))
                {
                    Log.Debug("Latest internal resource version is '{0}',local resource version is not exits.", latestInternalResourceVersion.ToString());
                    return CheckVersionListResult.NeedUpdate;
                }

                FileStream fileStream = null;
                try
                {
                    fileStream = new FileStream(versionListFileName, FileMode.Open, FileAccess.Read);
                    using(BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        fileStream = null;
                        char[] header = binaryReader.ReadChars(3);
                        if (header[0] != VersionListHeader[0] || header[1] != VersionListHeader[1] || header[2] != VersionListHeader[2])
                        {
                            Log.Debug("Latest internal resource version is '{0}', local resource version is invalid.", latestInternalResourceVersion.ToString());
                            return CheckVersionListResult.NeedUpdate;
                        }

                        byte listVersion = binaryReader.ReadByte();

                        if (listVersion == 0)
                        {
                            byte[] encryptBytes = binaryReader.ReadBytes(4);
                            applicableGameVersion = Utility.Converter.GetString(Utility.Encryption.GetXorBytes(binaryReader.ReadBytes(binaryReader.ReadByte()), encryptBytes));

                        }
                    }
                }

            }


            }
    }
}
