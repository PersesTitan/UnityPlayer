using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour {

    public float degreePerSecond;
    
    void Start() {
        
    }

    void Update() {
        transform.Rotate(Vector3.up * Time.deltaTime * degreePerSecond);
    }
}
