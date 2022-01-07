using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //分数与生命值
    private int score = 0;
    private int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //增加生命值
    public void AddLives(int value)//定义生命增加函数，及其因变量值为整数
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over");//生命值小于0，游戏结束
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }
    //增加分数
    public void AddScore(int value)//定义分数增加函数，及其因变量值为整数
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}
