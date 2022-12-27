using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    [SerializeField] private GameObject pipe; //cano
    [SerializeField] private float heigth; //altura do cano
    private float currentTime = 0;
    
    [SerializeField] private GameController gameController;

    void Start()
    {
        if(gameController.gameInitial)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0f,heigth , 0f);
            Destroy(newPipe, 7f);
        }
    }


    void Update()
    {

        if(currentTime > Random.Range(2f, 3.5f) && gameController.gameInitial)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0f, Random.Range(-heigth, heigth), 0f);
            Destroy(newPipe, 6f);
            currentTime = 0f;
        }

        currentTime += Time.deltaTime;
    }




}
