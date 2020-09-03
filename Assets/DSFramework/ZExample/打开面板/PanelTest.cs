using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelTest : BasePanel
{
    private Text txt;
    private Button btn;

    public override void OnLoad() {
        base.OnLoad();
        panelPath = "Example/打开面板/PanelTest";
        panelLayer = PanelMgr.Layer.Normal;
    }

    public override void OnInitCmt(params object[] para) {
        base.OnInitCmt(para);
        txt = panelObj.transform.Find("Text").GetComponent<Text>();
        btn = panelObj.transform.Find("Button").GetComponent<Button>();
    }

    public override void OnAction() {
        base.OnAction();
        btn.onClick.AddListener(() => {
            txt.text = "Hello,World!";
        });
    }

    public override void OnClose() {
        base.OnClose();
    }
}
