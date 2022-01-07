using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    //饥饿值滑块
    public Slider hungerSlider;
    public int amountToBeFed;//最大饥饿值定义为整数
    private int currentFedAmount = 0;//当前饥饿值为零
    //游戏管理
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;//最大饥饿值设置
        hungerSlider.value = 0;//初始饥饿值为零
        hungerSlider.fillRect.gameObject.SetActive(false);//不激活滑块设置
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();//寻找游戏管理
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //喂食动物
    public void FeedAnimal(int amount)//定义动物从食物里获得饥饿值为整数
    {
        //饥饿值变化
        currentFedAmount += amount;//当前饥饿值加从食物里获得饥饿值
        hungerSlider.fillRect.gameObject.SetActive(true);//滑块ui增加
        hungerSlider.value = currentFedAmount;//当前饥饿值赋给滑块值
        //判定动物喂饱与否
        if (currentFedAmount >= amountToBeFed)
        {
            //调用游戏管理组件中的分数增加函数，给整数变量加值
            gameManager.AddScore(amountToBeFed);//喂饱后加分，分值为最大饥饿值
            Destroy(gameObject, 0.1f);
        }
    }
}
