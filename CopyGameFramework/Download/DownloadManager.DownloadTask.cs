﻿//--------
//LT2018.4.15
//-----------

namespace CopyGameFramework.Download
{
  internal partial  class DownloadManager
    {
        private sealed class DownloadTask : ITask
        {
            private static int s_Serial = 0;

            private readonly int m_SerialId;
            private DownloadTaskStatus m_Status;
            private readonly string m_DownloadPath;
            private readonly string m_DownloadUri;
            private readonly int m_FlushSize;
            private readonly float m_Timeout;
            private readonly object m_UserData;
            public bool m_Done;

            /// <summary>
            /// 初始化下载任务的新实例。
            /// </summary>
            /// <param name="downloadPath">下载后存放路径。</param>
            /// <param name="downloadUri">原始下载地址。</param>
            /// <param name="flushSize">将缓冲区写入磁盘的临界大小。</param>
            /// <param name="timeout">下载超时时长，以秒为单位。</param>
            /// <param name="userData">用户自定义数据。</param>
            public DownloadTask(string downloadPath, string downloadUri, int flushSize, float timeout, object userData)
            {
                m_SerialId = s_Serial++;
                m_Done = false;
                m_Status = DownloadTaskStatus.Todo;
                m_DownloadPath = downloadPath;
                m_DownloadUri = downloadUri;
                m_FlushSize = flushSize;
                m_Timeout = timeout;
                m_UserData = userData;
            }

            /// <summary>
            /// 获取下载任务的序列编号。
            /// </summary>
            public int SerialId
            {
                get { return m_SerialId; }
            }

            /// <summary>
            /// 获取或设置下载任务是否完成。
            /// </summary>
            public bool Done
            {
                get { return m_Done; }
                set
                {
                    m_Done = value;
                }
            }
            /// <summary>
            /// 获取或设置下载任务的状态。
            /// </summary>
            public DownloadTaskStatus Status
            {
                get
                {
                    return m_Status;
                }
                set
                {
                    m_Status = value;
                }
            }

            /// <summary>
            /// 获取下载后存放路径。
            /// </summary>
            public string DownloadPath
            {
                get
                {
                    return m_DownloadPath;
                }
            }
            /// <summary>
            /// 获取原始下载地址。
            /// </summary>
            public string DownloadUri
            {
                get
                {
                    return m_DownloadUri;
                }
            }

            /// <summary>
            /// 获取将缓冲区写入磁盘的临界大小。
            /// </summary>
            public long FlushSize
            {
                get { return m_FlushSize; }
            }

            /// <summary>
            /// 获取下载超时时长，以秒为单位。
            /// </summary>
            public float Timeout
            {
                get
                {
                    return m_Timeout;
                }
            }

            /// <summary>
            /// 获取用户自定义数据。
            /// </summary>
            public object UserData
            {
                get
                {
                    return m_UserData;
                }
            }
        }
    }
}
