using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchAnim : MonoBehaviour
{

    Material mat;
    [SerializeField] Transform oscObj;
    float pos;
    float value;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        float value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        pos = oscObj.localPosition.x * 8f;

        if (value > pos + 0.1f || value < pos - 0.1f)
        {
            if (value > pos)
            {
                value = value - 0.02f;
            } else
            {
                value = value + 0.02f;
            }
        }

        mat.SetFloat("_Cutoff_Height", value);

    }
}
