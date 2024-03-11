using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccumAnim2 : MonoBehaviour
{
    public Transform oscObj;
    private float accum;
    [Range(0, 1)]
    [SerializeField] float accumSpeed;

    // Update is called once per frame
    void Update()
    {
        accum += oscObj.position.x  * Time.deltaTime * accumSpeed;
        transform.position = new Vector3(Mathf.Cos(accum), 0, Mathf.Sin(accum));
    }
}
