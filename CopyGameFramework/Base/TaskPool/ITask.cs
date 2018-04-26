/// <summary>
/// LT2018.4.14
/// </summary>
namespace CopyGameFramework
{
    /// <summary>
    /// 任务接口
    /// </summary>
    internal interface ITask
    {
        /// <summary>
        /// 获取任务的序列编号
        /// </summary>
        int SerialId
        {
            get;
        }

        /// <summary>
        /// 获取任务是否完成
        /// </summary>
        bool Done
        {
            get;
        }
    }
}
