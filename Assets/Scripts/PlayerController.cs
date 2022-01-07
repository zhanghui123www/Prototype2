using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //水平输入
    public float horizo​​ntalInput;
    //垂直输入
    public float verticalInput;
    //移动速度
    public float speed = 10.0f;
    //边界范围
    public float xRange = 10.0f;
    public float zMin=0;
    public float zMax=10.0f;
    //弹药
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //设置水平边界
        if(transform.position.x<-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //设置垂直边界
        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, zMin);
        }
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, zMax);
        }
        //水平移动
        horizo​​ntalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //垂直移动
        verticalInput= Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        //发射设置
        //发射键
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //玩家发射弹药
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }
    }
}
