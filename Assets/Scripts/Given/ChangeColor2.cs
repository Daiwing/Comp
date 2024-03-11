using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor2 : MonoBehaviour
{
    public Transform oscObj;
    Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float adsr = oscObj.position.x * 0.1f;
        mat.color = new Color(adsr, 0.2f, 0.5f);
    }
}
