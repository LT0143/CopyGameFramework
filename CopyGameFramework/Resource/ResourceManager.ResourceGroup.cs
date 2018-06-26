//----------
//LT 2018.6.19
//---------

using System.Collections.Generic;

namespace CopyGameFramework.Resource
{
    internal partial class ResourceManager
    {
        /// <summary>
        /// 资源组。
        /// </summary>
        private sealed class ResourceGroup
        {
            private readonly Dictionary<ResourceName, ResourceInfo> m_ResourceInfos;
            private readonly List<ResourceName> m_ResourceNames;
            private int m_TotalLength;

            /// <summary>
            /// 初始化资源组的新实例。
            /// </summary>
            /// <param name="resourceInfos">资源信息引用。</param>
            public ResourceGroup(Dictionary<ResourceName, ResourceInfo> resourceInfos)
            {
                if (resourceInfos == null)
                {
                    throw new GameFrameworkException("Resource infos is invalid.");
                }

                m_ResourceInfos = resourceInfos;
                m_ResourceNames = new List<ResourceName>();
                m_TotalLength = 0;
            }

            public bool Ready
            {
                get { return ReadyResourceCount >= ResourceCount; }
            }

            /// <summary>
            /// 获取资源组资源数量。
            /// </summary>
            public int ResourceCount
            {
                get
                {
                    return m_ResourceNames.Count;
                }
            }

            /// <summary>
            /// 获取资源组已准备完成资源数量。
            /// </summary>
            public int ReadyResourceCount
            {
                get
                {
                    int readyResouceCount = 0;
                    foreach (ResourceName resourceName in m_ResourceNames)
                    {
                        if (m_ResourceInfos.ContainsKey(resourceName))
                        {
                            readyResouceCount++;
                        }
                    }
                    return readyResouceCount;
                }
            }

            /// <summary>
            /// 获取资源组总大小。
            /// </summary>
            public int TotalLength
            {
                get
                {
                    return m_TotalLength;
                }
            }

            public int TotalReayLength
            {
                get
                {
                    int totalReayLength = 0;
                    foreach (ResourceName resourceName in m_ResourceNames)
                    {
                        ResourceInfo resourceInfo = default(ResourceInfo);//null
                        if(m_ResourceInfos.TryGetValue(resourceName,out resourceInfo))
                        totalReayLength += resourceInfo.Length;
                    }
                    return totalReayLength;
                }
            }

            /// <summary>
            /// 获取资源组准备进度。
            /// </summary>
            public float Progress
            {
                get
                {
                    return TotalLength > 0 ? (float)TotalReayLength / TotalLength : 1f;
                }
            }

            /// <summary>
            /// 向资源组中增加资源。
            /// </summary>
            /// <param name="name">资源名称。</param>
            /// <param name="variant">变体名称。</param>
            /// <param name="length">资源大小。</param>
            public void AddResource(string name, string variant, int length)
            {
                m_ResourceNames.Add(new ResourceName(name, variant));
                m_TotalLength += length;
            }

        }

    }
}
