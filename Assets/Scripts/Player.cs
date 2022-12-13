using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rig;

    [HideInInspector] public bool gameOver;

    
    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rig.velocity = Vector2.up * speed ;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       gameOver = true;
    }
}
