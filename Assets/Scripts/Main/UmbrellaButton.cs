using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbrellaButton : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    public Sprite UmbrellaSprite;
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

    クリックしたらSprite変更
    public void onClickAct()
    {
        MainSpriteRenderer.sprite = UmbrellaSprite;
    }
}
