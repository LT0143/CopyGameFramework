//--------------
//LT 2018.5.3
//----------------

using System;

namespace CopyGameFramework.DataTable
{
    /// <summary>
    /// 数据表管理器接口。
    /// </summary>
    public interface IDataTableManager
    {
        /// <summary>
        /// 获取数据表数量。
        /// </summary>
        int Count { get; }

        /// <summary>
        /// 加载数据表成功事件。
        /// </summary>
        event EventHandler<LoadDataTableSuccessEventArgs> LoadDataTableSuccess;

        /// <summary>
        /// 加载数据表失败事件。
        /// </summary>
        event EventHandler<LoadDataTableFailureEventArgs> LoadDataTableFailure;

        /// <summary>
        /// 加载数据表更新事件。
        /// </summary>
        event EventHandler<LoadDataTableUpdateEventArgs> LoadDataTableUpdate;

        /// <summary>
        /// 加载数据表时加载依赖资源事件。
        /// </summary>
        event EventHandler<LoadDataTableDependencyAssetEventArgs> LoadDataTableDependencyAsset;

        void SetResourceManager(ires)
    }
}
