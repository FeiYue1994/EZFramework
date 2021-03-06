/*
 * Author:      熊哲
 * CreateTime:  3/6/2017 2:13:28 PM
 * Description:
 * 
*/
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

namespace EZUnityEditor
{
    public enum AssetsViewOption
    {
        Object = 0,
        Path = 1,
        PathAndObject = 2,
    }
    public enum BundleDependenciesViewOption
    {
        DontShow = 0,
        Direct = 1,
        Recursive = 2,
    }

    public class EZBundleObject : EZScriptableObject
    {
        public const string AssetName = "EZBundle";

        public BuildTarget buildTarget = BuildTarget.Android;
        public string outputPath = "Assets/StreamingAssets";
        public string listFileName = "files.txt";
        public bool managerMode = false;
        public bool forceRebuild = false;

        [Serializable]
        public class CopyInfo
        {
            public string destDirPath = "";
            public string sourDirPath = "";
        }
        [Serializable]
        public class BundleInfo
        {
            public string bundleName = "";
            public string filePattern = "*.*";
            public SearchOption searchOption = SearchOption.AllDirectories;
            public string dirPath = "";
        }
        public List<CopyInfo> copyList = new List<CopyInfo>();
        public List<BundleInfo> bundleList = new List<BundleInfo>();

        // view options
        public bool copyListFoldout = true;
        public bool bundleListFoldout = true;
        public AssetsViewOption showAssets = AssetsViewOption.Object;
        public BundleDependenciesViewOption showDependencies = BundleDependenciesViewOption.Recursive;
    }
}