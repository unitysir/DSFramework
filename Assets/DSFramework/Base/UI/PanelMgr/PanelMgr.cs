
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMgr :Single<PanelMgr> {


    public PanelMgr() {
        Init();
    }

    /// <summary>
    /// 层级
    /// </summary>
    public enum Layer {
        Background, Normal, Tip,
    }

    /// <summary>
    /// 层级字典
    /// </summary>
    private Dictionary<Layer, Transform> layerDic = new Dictionary<Layer, Transform>();

    /// <summary>
    /// 面板字典
    /// </summary>
    private Dictionary<string, BasePanel> panelDic = new Dictionary<string, BasePanel>();

    private Transform m_UIRoot;
    private Transform m_Canvas;

    private void Init() {
        m_UIRoot = GameObject.FindWithTag("UIRoot").transform;
        m_Canvas = m_UIRoot.Find("Canvas");

        layerDic.Add(Layer.Background, m_Canvas.Find("Background"));
        layerDic.Add(Layer.Normal, m_Canvas.Find("Normal"));
        layerDic.Add(Layer.Tip, m_Canvas.Find("Tip"));
    }

    public void Open<T>(params object[] para) where T : BasePanel {
        //面板已经打开时
        string name = typeof(T).ToString();
        if (panelDic.ContainsKey(name)) {
            return;
        }

        BasePanel panel = m_UIRoot.gameObject.AddComponent<T>();
        panel.OnLoad();
        panel.Load();

        Transform parent = layerDic[panel.panelLayer];
        panel.panelObj.transform.SetParent(parent, false);

        panelDic.Add(name, panel);
        panel.OnInitCmt();
        panel.OnAction();

    }

    public void Close(string name) {
        //面板没有打开时
        if (!panelDic.ContainsKey(name)) {
            return;
        }

        BasePanel panel = panelDic[name];
        panel.OnClose();
        panelDic.Remove(name);
        Object.Destroy(panel.panelObj);
        Object.Destroy(panel);

    }

}