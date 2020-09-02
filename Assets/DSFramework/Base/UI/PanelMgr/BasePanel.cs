using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel : MonoBehaviour {
    /// <summary>
    /// 面板路径
    /// </summary>
    public string panelPath;

    /// <summary>
    /// 面板对象
    /// </summary>
    public GameObject panelObj;

    /// <summary>
    /// 面板层级
    /// </summary>
    public PanelMgr.Layer panelLayer = PanelMgr.Layer.Normal;

    /// <summary>
    /// 加载面板
    /// </summary>
    public void Load() {
        GameObject skinPrefab = Resources.Load<GameObject>(panelPath);
        panelObj = Instantiate(skinPrefab);

        Debug.Log("加载面板--Load()");
    }

    /// <summary>
    /// 关闭面板
    /// </summary>
    public void Close() {
        string name = GetType().ToString();
        PanelMgr.Instance.Close(name);

        Debug.Log("关闭面板--Close()");
    }

    /// <summary>
    /// 初始化面板组件
    /// </summary>
    public virtual void OnInit() {

        Debug.Log("初始化面板组件--OnInit()");
    }

    /// <summary>
    /// 显示组件
    /// </summary>
    /// <param name="para"></param>
    public virtual void OnShow(params object[] para) {

        Debug.Log("显示组件--OnShow()");
    }

    /// <summary>
    /// 添加组件事件
    /// </summary>
    public virtual void OnClick() {

        Debug.Log("添加组件事件--OnClick()");
    }

    /// <summary>
    /// 关闭组件
    /// </summary>
    public virtual void OnClose() {

        Debug.Log("关闭组件--OnClose()");
    }
}
