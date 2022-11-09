using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBoardManager : MonoBehaviour
{

    public MouseDraw pencilScript;

    void OnEnable()
    {
        Invoke("SetDisabled", 3);
    }

    void SetDisabled()
    {
        pencilScript.ClearTexture();
        gameObject.SetActive(false);
    }
}
