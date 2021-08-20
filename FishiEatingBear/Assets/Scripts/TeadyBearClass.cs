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

    // death support
    const float TeddyBearLifespanSeconds = 10;
    Timer deathTimer;
    void Start()
    {
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(minImpulseForce, maxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
        // create and start timer
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = TeddyBearLifespanSeconds;
        deathTimer.Run();

    }

    // Update is called once per frame
    void Update()
    {
        if (deathTimer.Finished)
        {
            Destroy(gameObject);
        }

    }
}
