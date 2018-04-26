//--------------
//LT 2018.4.22
//-------------
using System;

namespace CopyGameFramework
{
    /// <summary>
    /// 变量
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Variable<T> :Variable
    {

        private T m_Value;

        /// <summary>
        /// 初始化变量的新实例。
        /// </summary>
        protected Variable()
        {
            m_Value = default(T);
        }

        /// <summary>
        /// 初始化变量的新实例。
        /// </summary>
        /// <param name="value">初始值。</param>
        protected Variable(T value)
        {
            m_Value = value;
        }


        /// <summary>
        /// 获取变量类型。
        /// </summary>
        public override Type type
        {
            get { return typeof(T); }
        }

        /// <summary>
        /// 获取或设置变量值。
        /// </summary>
        public T Value
        {
            get { return m_Value; }
            set { m_Value = value; }
        }

        public override object GetValue()
        {
            return m_Value;
        }

        public override void SetValue(object value)
        {
            m_Value = (T)value;
        }


        public override string ToString()
        {
            return (m_Value != null) ? m_Value.ToString() : "<Null>";
        }
    }
}
