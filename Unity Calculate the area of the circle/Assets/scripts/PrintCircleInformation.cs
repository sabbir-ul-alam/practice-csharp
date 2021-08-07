using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintCircleInformation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int radius;
        float area;
        const float PI = Mathf.PI;
        for (radius = 0; radius <= 5; radius++)
        {
            area = PI * (float)Mathf.Pow(radius, 2);
            Debug.Log("Radius: "+radius+ "Area: "+area);
        }

    }

    
}
