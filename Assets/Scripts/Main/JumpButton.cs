using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    public Sprite Torch;
    public Sprite JumpSprite;
    public GameObject Player;
    public int jumppower = 10;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーキャラクターのSprite読み込み
        MainSpriteRenderer = Player.GetComponent<SpriteRenderer>();

        rb = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //クリックしたらジャンプ
    public void onClickAct()
    {
        float sizeY = Player.GetComponent<BoxCollider2D>().size.y;
        //接地判定
        if (Physics2D.Raycast(transform.position, Vector3.down, sizeY))
        {
            rb.AddForce(Vector3.up * jumppower);
            MainSpriteRenderer.sprite = JumpSprite;
        }
        //着地してSpriteを戻す
        if (Player.transform.position.y == 2)
        {
            MainSpriteRenderer.sprite = Torch;
        }
        Debug.Log("Jump");
    }
}
