﻿//----------
//LT 2018.6.19
//---------

namespace CopyGameFramework.Resource
{
	internal partial class ResourceManager
    {
        /// <summary>
        /// 资源加载方式类型。
        /// </summary>
        private enum LoadType
        {
            /// <summary>
            /// 从文件加载。
            /// </summary>
            LoadFromFile = 0,

            /// <summary>
            /// 从内存加载。
            /// </summary>
            LoadFromMemory,

            /// <summary>
            /// 从内存快速解密加载。
            /// </summary>
            LoadFromMemoryAndQuickDecrypt,

            /// <summary>
            /// 从内存解密加载。
            /// </summary>
            LoadFromMemoryAndDecrypt,
        }
    }
}
