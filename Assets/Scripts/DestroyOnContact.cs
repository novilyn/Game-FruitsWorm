﻿using System.Collections;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
   
        
    }
}
