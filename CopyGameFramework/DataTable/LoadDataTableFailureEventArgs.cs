﻿//-------------
// LT 2018.5.13
//----------------

namespace CopyGameFramework.DataTable
{
    public sealed class LoadDataTableFailureEventArgs : GameFrameworkEventArgs
    {
        /// <summary>
        /// 初始化加载数据表失败事件的新实例。
        /// </summary>
        /// <param name="dataTableAssetName">数据表资源名称。</param>
        /// <param name="errorMessage">错误信息。</param>
        /// <param name="userData">用户自定义数据。</param>
        public LoadDataTableFailureEventArgs(string dataTableAssetName, string errorMessage, object userData)
        {
            DataTableAssetName = dataTableAssetName;
            ErrorMessage = errorMessage;
            UserData = userData;
        }
        /// <summary>
        /// 获取数据表资源名称。
        /// </summary>
        public string DataTableAssetName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取错误信息。
        /// </summary>
        public string ErrorMessage
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取用户自定义数据。
        /// </summary>
        public object UserData
        {
            get;
            private set;
        }
    }
}
