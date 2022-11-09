using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBoardManager : MonoBehaviour
{

    public MouseDraw pencilScript;
    public PlayerController playerController;
    public int signTime;

    void OnEnable()
    {
        playerController.SetMovility(false);
        Invoke("SetDisabled", signTime);
    }

    void SetDisabled()
    {
        pencilScript.ClearTexture();
        playerController.SetMovility(true);
        gameObject.SetActive(false);
    }
}
