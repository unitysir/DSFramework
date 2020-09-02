using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTestgo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PanelMgr.Instance.Open<PanelTest>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
