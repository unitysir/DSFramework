using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelTest : BasePanel
{
    private Text txt;
    private Button btn;

    public override void OnInit() {
        base.OnInit();
        panelPath = "Example/打开面板/PanelTest";
        panelLayer = PanelMgr.Layer.Normal;
    }

    public override void OnShow(params object[] para) {
        base.OnShow(para);
        txt = panelObj.transform.Find("Text").GetComponent<Text>();
        btn = panelObj.transform.Find("Button").GetComponent<Button>();
    }

    public override void OnClick() {
        base.OnClick();
        btn.onClick.AddListener(() => {
            txt.text = "Hello,World!";
        });
    }

    public override void OnClose() {
        base.OnClose();
    }
}
