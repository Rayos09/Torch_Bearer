using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnClick()
    {
        //ステージ1読み込み
        SceneManager.LoadScene("Stage1");
    }
}
