using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSFramework {
    public class SimpleMonoBehaviour : MonoBehaviour {
        /// <summary>
        /// 获取组件
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <param name="trans">对象</param>
        /// <param name="name">被查找对象的名称</param>
        /// <returns></returns>
        protected T GetCmpt<T>(Transform trans, string name) {
            T t = trans.Find(name).GetComponent<T>();
            if (t != null) return t;
            else Debug.LogError("没有找到该组件!");
            return default;
        }

        /// <summary>
        /// 获取组件
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <param name="obj">对象</param>
        /// <param name="name">被查找对象的名称</param>
        /// <returns></returns>
        protected T GetCmpt<T>(GameObject obj, string name) {
            T t = obj.transform.Find(name).GetComponent<T>();
            if (t != null) return t;
            else Debug.LogError("没有找到该组件!");
            return default;
        }
    }
}
