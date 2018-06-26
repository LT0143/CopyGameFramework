
//-------------
//LT 2018.6.12
//-------------

using System;


namespace CopyGameFramework.Resource
{
    internal partial class ResourceManager
    {
        /// <summary>
        /// 资源名称。
        /// </summary>
        private struct ResourceName : IComparable, IComparable<ResourceName>, IEquatable<ResourceName>
        {
            private readonly string m_Name;
            private readonly string m_Variant;

            public ResourceName(string name, string variant)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new GameFrameworkException("Reource name is invalid.");
                }

                m_Name = name;
                m_Variant = variant;
            }

            /// <summary>
            /// 获取资源名称。
            /// </summary>
            public string Name
            {
                get
                {
                    return m_Name;
                }
            }

            /// <summary>
            /// 获取变体名称。
            /// </summary>
            public string Variant
            {
                get
                {
                    return m_Variant;
                }
            }

            /// <summary>
            /// 获取是否变体。
            /// </summary>
            public bool IsVariant
            {
                get
                {
                    return m_Variant != null;
                }
            }

            public string FullName
            {
                get
                {
                    return IsVariant ? string.Format("{0}.{1}", m_Name, m_Variant) : m_Name;
                }
            }

            public override string ToString()
            {
                return FullName;
            }

            public override int GetHashCode()
            {
                if (m_Variant == null)
                {
                    return m_Name.GetHashCode();
                }
                return (m_Name.GetHashCode() ^ m_Variant.GetHashCode());
            }
            public override bool Equals(object value)
            {
                return (value is ResourceName) && (this == (ResourceName)value);
            }
            public bool Equals(ResourceName resourceName)
            {
                return (this == resourceName);
            }

            public static bool operator ==(ResourceName resourceName1, ResourceName resourceName2)
            {
                return resourceName1.CompareTo(resourceName2) == 0;
            }
            public static bool operator !=(ResourceName resourceName1, ResourceName resourceName2)
            {
                return resourceName1.CompareTo(resourceName2) != 0;
            }

            public int CompareTo(object obj)
            {
                if (obj == null)
                {
                    return 1;
                }
                if(!(obj is ResourceName))
                throw new GameFrameworkException("Type of value is invalid");
                return CompareTo((ResourceName)obj);
            }

            public int CompareTo(ResourceName other)
            {
                int result = string.Compare(m_Name, other.m_Name);
                if (result != 0)
                    return result;
                return string.Compare(m_Variant, other.m_Variant); 
            }
        }
    }
}
