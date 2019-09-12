using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudController : MonoBehaviour
{
    float speed = 10.0f;
    float rotationSpeed = 100.0f;  //rotate speed
    // Start is called before the first frame update
   // public int life = 1;
    //public int state = 0;
    private static int myLife;
   


    void Start()
    {
        GameObject coin1 = GameObject.Find("coin1");
        coinCollider coinCollider = coin1.GetComponent<coinCollider>();
        myLife = coinCollider.mudLife;

       // myLife = GameObject.Find("").GetComponent<coinCollider>().mudLife();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Translate(0, 0, translation); //沿着Z轴移动
        transform.Rotate(0, rotation, 0); //绕Y轴旋转
                                          // myLife = coinCollider.mudLife;
        myLife = coinCollider.mudLife;
    }

    void OnTriggerEnter2D(Collider2D hitInfo){
        Debug.Log("wuwuwu = " + myLife);
    }







   //void OnCollisionEnter(Collision collision)
   //{
   //    if (collision.gameObject.tag == "human")
   //    {
   //        life = life + 1;
   //        Debug.Log("Chest is here!");
   //        //if (life >= 2 && collision.gameObject.tag == "human")
   //        //{
   //        //    Debug.Log("Chest is here!");
   //        //}
   //    }
   //}

}
