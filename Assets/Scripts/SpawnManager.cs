using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //动物数组
    public GameObject[] animalPrefabs;
    //生成位置范围界定
    //顶部
    private float spawnRangex = 10.0f;
    private float spawnPosz = 20.0f;
    //侧边
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;
    //生成时间界定
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //顶部生成动物副本
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        //左部生成动物副本
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);
        //右部生成动物副本
        InvokeRepeating("SpawnRightAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    //生成动物
    
    //顶部生成
    void SpawnRandomAnimal() {
        //生成位置随机
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 0, spawnPosz);
        //动物指数随机
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //生成动物
        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
    //左边生成
    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ,
        sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);//旋转头朝右
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    //右边生成
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ,
        sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);//旋转头朝左
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
