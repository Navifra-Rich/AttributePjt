﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterParticle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.name == "SeedGround")
        {
            other.transform.GetChild(0).gameObject.SetActive(true);
        }
        if(other.gameObject.GetComponent<Grass>() != null)
        {
            Grass grass = other.gameObject.GetComponent<Grass>();
            if (!grass.IsBurned && grass.IsFiring)
                other.gameObject.GetComponent<Grass>().res_Water();
        }
    }
}
