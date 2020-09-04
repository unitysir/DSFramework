using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSFramework {
    public class DelayPush : SimpleMonoBehaviour {
        private void OnEnable() {
            Invoke("Push", 2f);
        }

        private void Push() {
            PoolMgr.Instance.PushObj("Example/002缓存池/Cube", gameObject);
        }

    }
}
