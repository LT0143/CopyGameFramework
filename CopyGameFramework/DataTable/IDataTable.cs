//-----------
//LT 2018.4.22
//---------------

using System;
using System.Collections.Generic;
 

namespace CopyGameFramework.DataTable
{
    /// <summary>
    /// 数据表接口。
    /// </summary>
    /// <typeparam name="T">数据表行的类型。</typeparam>
    public interface IDataTable<T>:IEnumerable<T> where T:IDataRow
    {
        /// <summary>
        /// 获取数据表名称。
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// 获取数据表行的类型。
        /// </summary>
        Type Type
        {
            get;
        }

        /// <summary>
        /// 获取数据表行数。
        /// </summary>
        int Count
        {
            get;
        }





    }
}
