using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingAnim : MonoBehaviour
{
    public Transform oscOBj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float adsr = oscOBj.position.x* 0.1f;
        transform.position = new Vector3(0, 1-adsr, 0);
    }
}
