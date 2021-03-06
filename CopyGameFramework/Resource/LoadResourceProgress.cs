﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyGameFramework.Resource
{
   /// <summary>
   /// 加载资源进度类型。
   /// </summary>
    public enum LoadResourceProgress
    {
        /// <summary>
        /// 读取资源包。
        /// </summary>
        ReadBundle,

        /// <summary>
        /// 加载资源包。
        /// </summary>
        LoadBundle,
        /// <summary>
        /// 加载资源。
        /// </summary>
        LoadAsset,

        /// <summary>
        /// 加载场景。
        /// </summary>
        LoadScene,
    }
}
