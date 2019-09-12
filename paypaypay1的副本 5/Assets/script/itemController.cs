using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    float speed = 10.0f;   
    float rotationSpeed = 100.0f;  //rotate speed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //使用左右方向键或者A、D键来控制左右旋转
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation); //沿着Z轴移动
        transform.Rotate(0, rotation, 0); //绕Y轴旋转

    }
}
