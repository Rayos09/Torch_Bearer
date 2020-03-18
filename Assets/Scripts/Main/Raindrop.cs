using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raindrop : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    public Sprite UmbrellaSprite;
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーキャラクターを見つける
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーキャラクターのSprite読み込み
        MainSpriteRenderer = Player.GetComponent<SpriteRenderer>();
        if(MainSpriteRenderer.sprite == UmbrellaSprite)
        {
            Debug.Log("Umbrella");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //地面に触れたら消える
        if (col.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Player")
        {
            //プレイヤーキャラクターのSpriteがUmbrellaだった場合消える
            if (MainSpriteRenderer.sprite == UmbrellaSprite)
            {
                Destroy(this.gameObject);
                Debug.Log("Rain");
            }
            //それ以外はゲームオーバー
            else
            {
                SceneManager.LoadScene("Gameover");
            }
        }
    }
}
