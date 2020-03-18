using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public GameObject Raindrop;
    public float xmin = 0;
    public float xmax = 3;
    public float ymin = 0;
    public float ymax = 3;
    public float time = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Rainy");
    }

    // Update is called once per frame
    void Update()
    {

    }

    //雨粒生成
    IEnumerator Rainy()
    {
        for (int i = 0; i < 100; i++)
        {
            float x = Random.Range(xmin, xmax);
            float y = Random.Range(ymin, ymax);
            Instantiate(Raindrop, new Vector3(x, y, 1.0f), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
