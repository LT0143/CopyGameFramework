//-------------
//LT 2018.6.23
//------------

namespace CopyGameFramework.Resource
{
    internal partial class ResourceManager
    {
        /// <summary>
        /// 资源初始化器。
        /// </summary>
        private sealed class ResourceIniter
        {
            private readonly ResourceManager m_ResourceManager;
            private string m_CurrentVariant;
            public GameFrameworkAction ResourceInitComplete;

            /// <summary>
            /// 初始化资源初始化器的新实例。
            /// </summary>
            /// <param name="resourceManager">资源管理器。</param>
            public ResourceIniter(ResourceManager resourceManager)
            {
                m_ResourceManager = resourceManager;
                m_CurrentVariant = null;

                ResourceInitComplete = null;
            }

            /// <summary>
            /// 关闭并清理资源初始化器。
            /// </summary>
            public void Shutdown()
            {

            }

            /// <summary>
            /// 初始化资源。
            /// </summary>
            public void InitResources(string currentVariant)
            {
                m_CurrentVariant = currentVariant;

                if (m_ResourceManager.m_ResourceHelper == null)
                {
                    throw new GameFrameworkException("Resource helper is invalid.");
                }

                m_ResourceManager.m_ResourceHelper.LoadBytes(Utility.Path.GetRemotePath(m_ResourceManager.m_ReadOnlyPath, Utility.Path.GetResourceNameWithSuffix(VersionListFileName)), ParsePackageList);
            }

        }
    }
}
