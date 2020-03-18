using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchButton : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    public Sprite TorchSprite;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーキャラクターのSprite読み込み
        MainSpriteRenderer = Player.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //クリックしたらSprite変更
    public void onClickAct()
    {
        MainSpriteRenderer.sprite = TorchSprite;
        Debug.Log("Torch");
    }
}
