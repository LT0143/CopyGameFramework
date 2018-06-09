//-------------
//LT 2018.5.13
//-------------

using CopyGameFramework.Download;
using CopyGameFramework.ObjectPool;
using System;

namespace CopyGameFramework.Resource
{
    /// <summary>
    /// 资源管理器接口。
    /// </summary>
    public interface IResourceManager
    {
        /// <summary>
        /// 获取资源只读区路径。
        /// </summary>
        string ReadOnlyPath
        { get; }
        
        /// <summary>
        /// 获取资源读写区路径。
        /// </summary>
        string ReadWritePath
        {
            get;
        }

        /// <summary>
        /// 获取资源模式。
        /// </summary>
        ResourceMode ResourceMode
        {
            get;
        }

        /// <summary>
        /// 获取当前变体。
        /// </summary>
        string CurrentVariant
        { get; }

        /// <summary>
        /// 获取当前资源适用的游戏版本号。
        /// </summary>
         string ApplicableGameVersion { get; }


        /// <summary>
        /// 获取当前资源内部版本号。
        /// </summary>
        int InternalResourceVersion
        {
            get;
        }

        /// <summary>
        /// 获取已准备完毕资源数量。
        /// </summary>
        int AssetCount
        {
            get;
        }

        /// <summary>
        /// 获取已准备完毕资源数量。
        /// </summary>
        int ResourceCount
        {
            get;
        }

        /// <summary>
        /// 获取资源组数量。
        /// </summary>
        int ResourceGroupCount
        {
            get;
        }

        /// <summary>
        /// 获取或设置资源更新下载地址。
        /// </summary>
        string UpdatePrefixUri
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置资源更新重试次数。
        /// </summary>
        int UpdateRetryCount
        {
            get;
            set;
        }


        /// <summary>
        /// 获取等待更新资源数量。
        /// </summary>
        int UpdateWaitingCount
        {
            get;
        }

        /// <summary>
        /// 获取正在更新资源数量。
        /// </summary>
        int UpdatingCount
        {
            get;
        }

        /// <summary>
        /// 获取加载资源代理总数量。
        /// </summary>
        int LoadTotalAgentCount
        {
            get;
        }

        /// <summary>
        /// 获取可用加载资源代理数量。
        /// </summary>
        int LoadFreeAgentCount
        {
            get;
        }

        /// <summary>
        /// 获取工作中加载资源代理数量。
        /// </summary>
        int LoadWorkingAgentCount
        {
            get;
        }

        /// <summary>
        /// 获取等待加载资源任务数量。
        /// </summary>
        int LoadWaitingTaskCount
        {
            get;
        }


        /// <summary>
        /// 获取或设置资源对象池自动释放可释放对象的间隔秒数。
        /// </summary>
        float AssetAutoReleaseInterval
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置资源对象池的容量。
        /// </summary>
        int AssetCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置资源对象池对象过期秒数。
        /// </summary>
        float AssetExpireTime
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置资源对象池的优先级。
        /// </summary>
        int AssetPriority
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置资源对象池自动释放可释放对象的间隔秒数。
        /// </summary>
        float ResourceAutoReleaseInterval
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置资源对象池的容量。
        /// </summary>
        int ResourceCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置资源对象池对象过期秒数。
        /// </summary>
        float ResourceExpireTime
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置资源对象池的优先级。
        /// </summary>
        int ResourcePriority
        {
            get;
            set;
        }


        /// <summary>
        /// 资源初始化完成事件。
        /// </summary>
        event EventHandler<ResourceInitCompleteEventArgs> ResourceInitComplete;

        /// <summary>
        /// 版本资源列表更新成功事件。
        /// </summary>
        event EventHandler<VersionListUpdateSuccessEventArgs> VersionListUpdateSuccess;

        /// <summary>
        /// 版本资源列表更新失败事件。
        /// </summary>
        event EventHandler<VersionListUpdateFailureEventArgs> VersionListUpdateFailure;

        /// <summary>
        /// 资源检查完成事件。
        /// </summary>
        event EventHandler<ResourceCheckCompleteEventArgs> ResourceCheckComplete;

        /// <summary>
        /// 资源更新开始事件。
        /// </summary>
        event EventHandler<ResourceUpdateStartEventArgs> ResourceUpdateStart;

        /// <summary>
        /// 资源更新改变事件。
        /// </summary>
        event EventHandler<ResourceUpdateChangedEventArgs> ResourceUpdateChanged;

        /// <summary>
        /// 资源更新成功事件。
        /// </summary>
        event EventHandler<ResourceUpdateSuccessEventArgs> ResourceUpdateSuccess;

        /// <summary>
        /// 资源更新失败事件。
        /// </summary>
        event EventHandler<ResourceUpdateFailureEventArgs> ResourceUpdateFailure;
        
        /// <summary>
        /// 资源更新全部完成事件。
        /// </summary>
        event EventHandler<ResourceUpdateAllCompleteEventArgs> ResourceUpdateAllComplete;

        /// <summary>
        /// 设置资源只读路径。
        /// </summary>
        /// <param name="readonlyPath"></param>
        void SetReadOnlyPath(string readonlyPath);

        /// <summary>
        /// 设置当前变体。
        /// </summary>
        /// <param name="currentVariant"></param>
        void SetResourceMode(string currentVariant);

        /// <summary>
        /// 设置当前变体。
        /// </summary>
        /// <param name="currentVariant"></param>
        void SetCurrentVariant(string currentVariant);

        /// <summary>
        /// 设置对象池管理器。
        /// </summary>
        /// <param name="objectPoolManager">对象池管理器。</param>
        void SetObjectPoolManager(IObjectPoolManager objectPoolManager);

        /// <summary>
        /// 设置下载管理器。
        /// </summary>
        /// <param name="downloadManager">下载管理器。</param>
        void SetDownloadManager(IDownloadManager downloadManager);

        /// <summary>
        /// 设置解密资源回调函数。
        /// </summary>
        /// <param name="decryptResourceCallback">要设置的解密资源回调函数。</param>
        /// <remarks>如果不设置，将使用默认的解密资源回调函数。</remarks>
        void SetDecryptResourceCallback(DecryptResourceCallback decryptResourceCallback);

        /// <summary>
        /// 设置资源辅助器。
        /// </summary>
        /// <param name="resourceHelper">资源辅助器。</param>
        void SetResourceHelper(IResourceHelper resourceHelper);





    }
}
