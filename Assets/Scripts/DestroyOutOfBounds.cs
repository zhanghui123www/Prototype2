using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //范围界定
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float sideBound = 30.0f;
    //游戏管理
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //寻找游戏管理
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //摧毁
        //垂直摧毁条件
        if (transform.position.z > topBound)
        {
            //摧毁对象
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);//生命值减一
            //摧毁对象
            Destroy(gameObject);
        }
        //水平摧毁条件
        else if (transform.position.x > sideBound)
        {
            gameManager.AddLives(-1);//生命值减一
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            gameManager.AddLives(-1);//生命值减一
            Destroy(gameObject);
        }
    }
}
