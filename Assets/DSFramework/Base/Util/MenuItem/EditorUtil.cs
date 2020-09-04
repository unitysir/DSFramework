#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using System.IO;
using UnityEngine;

namespace DSFramework {

    public partial class EditorUtil {
    #if UNITY_EDITOR
        public static void OpenFile(string filepath) { Application.OpenURL("file:///" + filepath); }

        public static void CallMenuItem(string menuName) {
            EditorApplication.ExecuteMenuItem(menuName);
            Application.OpenURL("file://" + Path.Combine(Application.dataPath, "../"));
        }

        public static void ExportPackage(string assetName, string fileName) {
            AssetDatabase.ExportPackage(assetName, fileName, ExportPackageOptions.Recurse);
        }

        [MenuItem("DSFramework/02.MenuItem 复用", false, 3)]
        private static void MenuClicked() { EditorUtil.CallMenuItem("02.复制文本到剪切板"); }

    #endif
    }

}