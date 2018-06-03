//-------------
//LT 2018.6.3
//--------------

using System;

namespace CopyGameFramework.ObjectPool
{
    /// <summary>
    /// 对象基类。
    /// </summary>
   public abstract  class ObjectBase
    {
        private readonly string m_Name;
        private readonly object m_Target;
        private bool m_Locked;
        private int m_Priority;
        private DateTime m_LastUseTime;


        /// <summary>
        /// 初始化对象的新实例。
        /// </summary>
        /// <param name="target">对象。</param>
        public ObjectBase(object target) : this(null, target,false, 0)
        {

        }


        /// <summary>
        /// 初始化对象的新实例。
        /// </summary>
        /// <param name="name">对象名称。</param>
        /// <param name="target">对象。</param>
        public ObjectBase(string name, object target) : this(name, target,false, 0)
        {

        }

        /// <summary>
        /// 初始化对象的新实例。
        /// </summary>
        /// <param name="name">对象名称。</param>
        /// <param name="target">对象。</param>
        /// <param name="locked">对象是否被加锁。</param>
        public ObjectBase(string name, object target, bool locked)
            : this(name, target, locked, 0)
        {

        }



        /// <summary>
        /// 初始化对象的新实例。
        /// </summary>
        /// <param name="name">对象名称。</param>
        /// <param name="target">对象。</param>
        /// <param name="priority">对象的优先级。</param>
        public ObjectBase(string name, object target, int priority)
            :this(name,target,false,priority)
        {

        }

        /// <summary>
        /// 初始化对象的新实例。
        /// </summary>
        /// <param name="name">对象名称。</param>
        /// <param name="target">对象。</param>
        /// <param name="locked">对象是否被加锁。</param>
        /// <param name="priority">对象的优先级。</param>
        public ObjectBase(string name, object target, bool locked, int priority)
        {
            if (target == null)
            {
                throw new GameFrameworkException(string.Format("Target '{0}' is invalid", name
                    ));
            }

            m_Name = name ?? string.Empty;
            m_Target = target;
            m_Locked = locked;
            m_Priority = priority;
            m_LastUseTime = DateTime.Now;
        }
    }
}
