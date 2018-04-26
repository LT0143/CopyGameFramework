//-----------
//LT 2018.4.22
//-----------

namespace CopyGameFramework.DataTable
{
    /// <summary>
    /// 数据表行接口。
    /// </summary>
    public interface IDataRow
    {
        /// <summary>
        /// 获取数据表行的编号。
        /// </summary>
        int Id
        { get; }

        /// <summary>
        /// 数据表行文本内容解析器。
        /// </summary>
        /// <param name="dataRowText"></param>
        void ParseDataRow(string dataRowText);
    }
}
