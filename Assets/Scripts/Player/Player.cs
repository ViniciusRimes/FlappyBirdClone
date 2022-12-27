using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [Header("Components")]
    private Rigidbody2D rig;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] AudioClip clipDead;
    [SerializeField] private GameController gameController;

    [Header("Informations")]
    [HideInInspector] public bool gameOver;
    [SerializeField] private float speed;

    
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
        if(Input.GetMouseButtonDown(0) && gameController.gameInitial)
        {
            rig.velocity = Vector2.up * speed ;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        audioSFX(clipDead);
        gameOver = true;
    }

    void audioSFX(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
