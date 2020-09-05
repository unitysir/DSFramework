using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSFramework {
    public class SimpleMonoBehaviour : MonoBehaviour {
        #region 获取组件

        /// <summary>
        /// 通过父对象获取 获取子对象组件
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <param name="trans">父对象</param>
        /// <param name="name">被查找对象的名称</param>
        /// <returns></returns>
        protected T GetCmpt<T>(Transform trans, string name) {
            T t = trans.Find(name).GetComponent<T>();
            if (t != null) return t;
            else Debug.LogError("没有找到该组件!");
            return default;
        }

        /// <summary>
        /// 通过父对象获取 子对象组件
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <param name="obj">父对象</param>
        /// <param name="name">被查找对象的名称</param>
        /// <returns></returns>
        protected T GetCmpt<T>(GameObject obj, string name) {
            return GetCmpt<T>(obj.transform, name);
        }

        /// <summary>
        /// 通过名称获取组件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objName"></param>
        /// <returns></returns>
        protected T GetCmpt<T>(string objName) {
            return GameObject.Find(objName).GetComponent<T>();
        }

        /// <summary>
        /// 通过标签获取组件
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="tagName">对象标签名</param>
        /// <returns></returns>
        protected T GetCmpt4Tag<T>(string tagName) {
            return GameObject.FindWithTag(tagName).GetComponent<T>();
        }

        #endregion

        #region 获取对象

        /// <summary>
        /// 通过标签获取对象
        /// </summary>
        /// <param name="tagName">标签名称</param>
        /// <returns></returns>
        protected GameObject GetObj2Tag(string tagName) {
            return GameObject.FindWithTag(tagName);
        }

        /// <summary>
        /// 通过名称获取对象
        /// </summary>
        /// <param name="objName">对象名称</param>
        /// <returns></returns>
        protected GameObject GetObj(string objName) {
            return GameObject.Find(objName);
        }

        /// <summary>
        /// 通过变换获取对象
        /// </summary>
        /// <param name="tran"></param>
        /// <returns></returns>
        protected GameObject GetObj(Transform tran) {
            return tran.gameObject;
        }

        #endregion

    }
}
