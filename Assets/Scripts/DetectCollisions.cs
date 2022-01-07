using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
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
       
    }
    private void OnTriggerEnter(Collider other)//碰撞检测（对象接触时）
    {
        //触发人物后销毁动物，生命值减一
        if (other.CompareTag("Player"))//碰到标签为“玩家”
        {
            //调用游戏管理组件中的生命增加函数，给整数变量加值
            gameManager.AddLives(-1);//生命值减一
            Destroy(gameObject);
        }
        //触发动物后增加饥饿值
        else if (other.CompareTag("Animal"))//碰到标签为“动物”
        {
            //调用饥饿值组件中的喂食动物函数，给整数变量加值
            other.GetComponent<AnimalHunger>().FeedAnimal(1);//饥饿值加一
        }
    }


}
