using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayPush : MonoBehaviour
{
    private void OnEnable() {
        Invoke("Push", 2f);
    }

    private void Push() {
        PoolMgr.Instance.PushObj("Example/002缓存池/Cube" , gameObject);
    }

}
