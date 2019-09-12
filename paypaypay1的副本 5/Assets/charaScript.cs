using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaScript : MonoBehaviour
{
    Animator animator;
    private SpriteRenderer rend;
    public Sprite[] mud1Sprite, mud2Sprite,mud3Sprite,mud4Sprite,mud5Sprite;
    float speed = 10.0f;
    float rotationSpeed = 100.0f;
    private static int myLife;


    private Sprite[] playSprite;

    private int index;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();    // we are accessing the SpriteRenderer that is attached to the Gameobject
        //mud1Sprite = Resources.Load<Sprite>("coin1");
        //mud2Sprite = Resources.Load<Sprite>("mud2_1_0");
        playSprite = mud1Sprite;
        index = 0;
        InvokeRepeating("PlaySprite", 0, 0.1f);

        //GameObject coin1 = GameObject.Find("coin1");
        //coinCollider coinCollider = coin1.GetComponent<coinCollider>();
        myLife = coinCollider.mudLife;
    }

    private void PlaySprite()
    {
        rend.sprite = playSprite[index];
        index++;
        if (index >= playSprite.Length)
                index = 0;


    }




    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //float rotation = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        transform.Translate(transform.right * translation , Space .World); //沿着Z轴移动
      //  transform.Rotate(0, rotation, 0); //绕Y轴旋转
        myLife = coinCollider.mudLife;
        if (myLife >=5 && myLife<=15 && playSprite != mud2Sprite) { CancelInvoke("PlaySprite"); playSprite = mud2Sprite; index = 0; InvokeRepeating("PlaySprite", 0, 0.1f); }
        if (myLife >= 11 && myLife <=15 && playSprite != mud3Sprite) { CancelInvoke("PlaySprite"); playSprite = mud3Sprite; index = 0; InvokeRepeating("PlaySprite", 0, 0.1f); }
        if (myLife >= 31 && myLife<= 40 && playSprite != mud4Sprite) { CancelInvoke("PlaySprite"); playSprite = mud4Sprite; index = 0; InvokeRepeating("PlaySprite", 0, 0.1f); }
        if (myLife >= 41 && myLife <= 50 && playSprite != mud5Sprite) { CancelInvoke("PlaySprite"); playSprite = mud5Sprite; index = 0; InvokeRepeating("PlaySprite", 0, 0.1f); }
        if (myLife >= 60 ) { Destroy(gameObject); }
        //else { rend.sprite = mud1Sprite; }

    }
}
