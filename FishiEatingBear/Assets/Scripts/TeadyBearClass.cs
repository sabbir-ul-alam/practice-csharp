using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeadyBearClass : MonoBehaviour
{
    [SerializeField]
    float minImpulseForce;
    [SerializeField]
    float maxImpulseForce;
    // Start is called before the first frame update
    void Start()
    {
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(minImpulseForce, maxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
