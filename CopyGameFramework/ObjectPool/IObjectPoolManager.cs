//----------
//LT 2018.6.3
//-------------

using System;

namespace CopyGameFramework.ObjectPool
{
    public interface IObjectPoolManager
    {
        /// <summary>
        /// 获取对象池数量。
        /// </summary>
        int Count
        { get; }

        bool HasObjectPool<T>() where T:Objectbase
    }
}
