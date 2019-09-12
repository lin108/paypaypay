using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollider : MonoBehaviour
{
    public Rigidbody2D cn;
    public float speed = 0.05f;
    public static int mudLife = 1;

    //public mudController other;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Debug.Log("hahahaha = " + mudLife);
        Destroy(gameObject);
        mudLife ++;
       // mudController.life += 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        cn.velocity = -transform.up * speed;
       // GameObject.Find("human").GetComponent<mudController>().life;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
