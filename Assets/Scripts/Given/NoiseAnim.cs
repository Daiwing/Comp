using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseAnim : MonoBehaviour
{
    Material mat;
    [SerializeField] Transform oscObj;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float adsr = oscObj.position.x * 0.1f;
        mat.SetFloat("_NoiseAmount", adsr);

    }
}
