using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyGameFramework.Resource
{
    /// <summary>
    /// 资源辅助器接口。
    /// </summary>
    public interface IResourceHelper
    {
        /// <summary>
        /// 直接从指定文件路径读取数据流。
        /// </summary>
        /// <param name="fileUri">文件路径。</param>
        /// <param name="loadBytesCallback">读取数据流回调函数。</param>
        void LoadBytes(string fileUri, LoadBytesCallback loadBytesCallback);

        void UnloadScene(string sceneAssetName, UnloadSceneCallbacks unloadSceneCallbacks, object userData);


        /// <summary>
        /// 释放资源。
        /// </summary>
        /// <param name="objectToRelease">要释放的资源。</param>
        void Release(object objectToRelease);
    }
}
