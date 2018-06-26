﻿//----------
//LT 2018.6.23
//------------

namespace CopyGameFramework.Resource
{
    internal partial class ResourceManager
    {
        private struct ReadWriteResourceInfo
        {
            private readonly LoadType m_LoadType;
            private readonly int m_Length;
            private readonly int m_HashCode;

            public ReadWriteResourceInfo(LoadType loadType, int length, int hashCode)
            {
                m_LoadType = loadType;
                m_Length = length;
                m_HashCode = hashCode;
            }


            public LoadType LoadType
            {
                get
                {
                    return m_LoadType;
                }
            }

            public int Length
            {
                get
                {
                    return m_Length;
                }
            }

            public int HashCode
            {
                get
                {
                    return m_HashCode;
                }
            }


        }
    }
}
