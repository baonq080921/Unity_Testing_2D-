using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible2D : MonoBehaviour
{

    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;
    private Reward parentManager;
    private void Awake()
    {
        parentManager = GetComponentInParent<Reward>();    
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, rotationSpeed);
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
         // Check if the other object has a PlayerController2D component
        if (other.GetComponent<PlayerController2D>() != null) {
            parentManager.CollectReward(this.transform);
            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }

        
    }


}


