//-------
//LT 2018.4.15
//----

namespace CopyGameFramework.Download
{
   internal partial class DownloadManager
    {
        private partial class DownloadCounter
        {
            private sealed class DownloadCounterNode
            {
                private readonly int m_DownloadLength;
                private float m_ElapseSeconds;

                public DownloadCounterNode(int downloadedLength)
                {
                    m_DownloadLength = downloadedLength;
                    m_ElapseSeconds = 0f;
                }

                public int DownloadedLenght
                {
                    get
                    {
                        return m_DownloadLength;
                    }
                }

                /// <summary>
                /// 流逝时间
                /// </summary>
                public float ElapseSeconds
                {
                    get { return m_ElapseSeconds; }
                }

                public void Update(float elapseSeconds, float realElapseSeconds)
                {
                    m_ElapseSeconds += realElapseSeconds;
                }
            }
        }
    }
}
