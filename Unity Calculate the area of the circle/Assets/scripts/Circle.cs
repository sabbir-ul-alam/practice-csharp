using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField]
    int radius;
    float area;
    // Start is called before the first frame update
    void Start()
    {
        area = Mathf.PI * Mathf.Pow(radius, 2);
        // scale circle sprite based on radius 
        Vector3 scale = transform.localScale;
        scale.x *= radius;
        scale.y *= radius;
        transform.localScale = scale;
        print("Radius: " + radius + ", Area: " + area);



    }

 
}
