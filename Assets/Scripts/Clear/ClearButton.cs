using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearButton : MonoBehaviour
{
    public void OnClick()
    {
        //スタートシーン読み込み
        SceneManager.LoadScene("Start");
    }
}
