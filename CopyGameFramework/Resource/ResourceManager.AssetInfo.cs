﻿//-------------
//LT 2018.6.12
//-------------


namespace CopyGameFramework.Resource
{
    internal partial class ResourceManager
    {
        /// <summary>
        /// 资源信息。
        /// </summary>
        private struct AssetInfo
        {
            private readonly string m_AssetName;
            private readonly ResourceName m_ResourceName;

            /// <summary>
            /// 初始化资源信息的新实例。
            /// </summary>
            /// <param name="assetName">资源名称。</param>
            /// <param name="resourceName">所在资源名称。</param>
            public AssetInfo(string assetName, ResourceName resourceName)
            {
                m_AssetName = assetName;
                m_ResourceName = resourceName;
            }

            /// <summary>
            /// 获取资源名称。
            /// </summary>
            public string AssetName
            {
                get
                {
                    return m_AssetName;
                }
            }

            /// <summary>
            /// 获取所在资源名称。
            /// </summary>
            public ResourceName ResourceName
            {
                get
                {
                    return m_ResourceName;
                }
            }
        }
    }
}
