using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyGameFramework.Resource
{
    /// <summary>
    /// 卸载场景失败回调函数。
    /// </summary>
    /// <param name="sceneAssetName">要卸载的场景资源名称。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void UnloadSceneFailureCallback(string sceneAssetName, object userData);
}
