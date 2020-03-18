using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int speed = 5;
    SpriteRenderer MainSpriteRenderer;
    public Sprite Torch;
    public Sprite Umbrella;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //常に右に移動
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        //Spriteの読み込み
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //y < 0でゲームオーバー
        if (gameObject.transform.position.y < 0)
        {
            SceneManager.LoadScene("Gameover");
        }
    }

    //ゴールのオブジェクトに触れるとクリア
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "goal")
        {
            SceneManager.LoadScene("Clear");
        }
    }
}
