using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMobile : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rig;

    [HideInInspector] public bool gameOver;

    
    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    
    private Touch touch;
    private float touchEnded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            rig.velocity = Vector2.up * speed ;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

       gameOver = true;
    }
}
