//---------
//LT 2018.4.15
//-----------
using System.Collections.Generic;
 

namespace CopyGameFramework.Download
{

    internal partial class DownloadManager
    {
        /// <summary>
        /// 下载计数器。
        /// </summary>
        private sealed partial class DownloadCounter
        {
            private readonly Queue<DownloadCounterNode> m_DownloadCounterNodes;
            private float m_UpdateInterval;  //更新间隔
            private float m_RecordInterval;  //记录间隔
            private float m_CurrentSpeed;
            private float m_Accumulator;  //累加器
            private float m_TimeLeft;  //剩余时间

            public DownloadCounter(float updateInterval, float recordInterval)
            {
                if (updateInterval <= 0f)
                {
                    throw new GameFrameworkException("Update interval is invalid.");
                }
                if (recordInterval <= 0f)
                {
                    throw new GameFrameworkException("Record interval is invalid.");
                }

                m_DownloadCounterNodes = new Queue<DownloadCounterNode>();
                m_UpdateInterval = updateInterval;
                m_RecordInterval = recordInterval;
                Reset();
            }

            public float UpdateInterval
            {
                get { return m_UpdateInterval; }
                set
                {
                    if (value <= 0f)
                        throw new GameFrameworkException("update interval is invalid.");
                    m_UpdateInterval = value;
                    Reset();
                }
            }


            public float RecordInterval
            {
                get
                {
                    return m_RecordInterval;
                }
                set
                {
                    if (value <= 0f)
                    {
                        throw new GameFrameworkException("Record interval is invalid.");
                    }

                    m_RecordInterval = value;
                    Reset();
                }
            }

            public float CurrentSpeed
            {
                get
                {
                    return m_CurrentSpeed;
                }
            }
            public void Shutdown()
            {
                Reset();
            }

            public void Update(float elapseSeconds, float realElapseSeconds)
            {
                if (m_DownloadCounterNodes.Count < 0)
                    return;
                //计时器+真实流逝时间
                m_Accumulator += realElapseSeconds;
                //如果计时器>记录流逝时间，设置为记录流逝时间
                if (m_Accumulator > m_RecordInterval)
                    m_Accumulator = m_RecordInterval;

                //剩余时间-真实流逝时间
                m_TimeLeft -= realElapseSeconds;
                //遍历下载计数器节点，更新流逝时间和真实流逝时间
                foreach (DownloadCounterNode downloadCunterNode in m_DownloadCounterNodes)
                {
                    downloadCunterNode.Update(elapseSeconds, realElapseSeconds);
                }
                //流逝时间>=记录流逝时间，出队
                while (m_DownloadCounterNodes.Count > 0 && m_DownloadCounterNodes.Peek().ElapseSeconds >= m_RecordInterval)
                {
                    m_DownloadCounterNodes.Dequeue();
                }

                if (m_DownloadCounterNodes.Count <= 0)
                {
                    Reset();
                    return;
                }

                if (m_TimeLeft <= 0)
                {
                    int totalDownloadLength = 0;
                    foreach (DownloadCounterNode downloadCounterNode in m_DownloadCounterNodes)
                    {
                        totalDownloadLength += downloadCounterNode.DownloadedLenght;
                    }
                    m_CurrentSpeed = m_Accumulator > 0f ? totalDownloadLength / m_Accumulator : 0f;
                    m_TimeLeft += m_UpdateInterval;
                }

            }

            /// <summary>
            /// 新建一个下载节点
            /// </summary>
            /// <param name="downloadedLength"></param>
            public void RecordDownloadedLength(int downloadedLength)
            {
                if (downloadedLength <= 0)
                    return;
                m_DownloadCounterNodes.Enqueue(new DownloadCounterNode(downloadedLength));

            }

            private void Reset()
            {
                m_DownloadCounterNodes.Clear();
                m_CurrentSpeed = 0f;
                m_Accumulator = 0f;
                m_TimeLeft = 0f;
            }
        }
    }
}
