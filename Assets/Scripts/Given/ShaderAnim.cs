using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderAnim : MonoBehaviour
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
        float adsr = oscObj.position.x * 0.1f * Mathf.PI * 2;
        Vector2 pos = new Vector2(Mathf.Cos(adsr), Mathf.Sin(adsr))*0.5f;
        mat.SetVector("_Pos", pos);
    }
}
