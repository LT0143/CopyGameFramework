//-------------
//LT 2018.6.12
//-------------

using System.Collections.Generic;

namespace CopyGameFramework.Resource
{
    internal sealed partial class ResourceManager :GameFrameworkModule,IResourceManager
    {
        private static readonly char[] PackageListHeader = new char[] { 'E', 'L', 'P' };
        private static readonly char[] VersionListHeader = new char[] { 'E', 'L', 'V' };
        private static readonly char[] ReadOnlyListHeader = new char[] { 'E', 'L', 'R' };
        private static readonly char[] ReadWriteListHeader = new char[] { 'E', 'L', 'W' };
        private const string VersionListFileName = "version";
        private const string ResourceListFileName = "list";
        private const string BackupFileSuffixName = ".bak";
        private const byte ReadWriteListVersionHeader = 0;

        private readonly Dictionary<string, AssetInfo> m_AssetInfos;
        private readonly Dictionary<string, AssetDependencyInfo> m_AssetDependencyInfos;
        private readonly Dictionary<ResourceName, ResourceInfo> m_ResourceInfos;
        private readonly Dictionary<string, ResourceGroup> m_ResourceGroups;
        private readonly SortedDictionary<ResourceName, ReadWriteResourceInfo> m_ReadWriteResourceInfos;
        private ResourceIniter m_ResourceIniter;
        private VersionListProcessor m_VersionListProcessor;
        private string m_ReadWritePath;
        private string m_ReadOnlyPath;
        private IResourceHelper m_ResourceHelper;

    }
}
