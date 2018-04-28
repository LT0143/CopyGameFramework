//---------
//LT 2018.4.27
//-----------

//using System;

using CopyGameFramework.res
using System;

namespace CopyGameFramework.DataTable
{
    /// <summary>
    /// 数据表管理接口
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
        event EventHandler<LoadDataTableSuccessEventArg> LoadDataTableSuccess;

        /// <summary>
        /// 加载数据表失败事件。
        /// </summary>
        event EventHandler<LoadDataTableFailureEventArgs> LoadDataTableFailure;

        /// <summary>
        /// 加载数据表更新事件。
        /// </summary>
        event EventHandler<LoadDataTableUpdateEventArgs> LoadDataTableUpdate;

        
    }
}
