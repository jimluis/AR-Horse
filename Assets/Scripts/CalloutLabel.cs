using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalloutLabel : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    [SerializeField] GameObject targetObj;

    void Start()
    {
        line.startWidth = 0.01f;
        line.endWidth = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        //if(UIManager.Instance.currentAnim == 1)
        //{
        //    UIManager.Instance.ToggleLabel(true);
        //    line.enabled = true;
        //    line.SetPosition(0, gameObject.transform.position);
        //    line.SetPosition(1, targetObj.transform.position);
        //}
        //else
        //{
        //    line.enabled = false;
        //    UIManager.Instance.ToggleLabel(false);
        //}



    }
}
