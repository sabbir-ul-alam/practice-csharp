using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    float screenLeft;
    float screenRight;
    float screenTop;
    float screenBottom;
    float colliderHalfWidth;
    float colliderHalfHeight;
    [SerializeField]
    GameObject prefabExplosion;
    void Start()
    {
        float screenZ = -Camera.main.transform.position.z;
        Vector3 lowerLeftCornerScreen = new Vector3(0, 0, screenZ);
        Vector3 upperRightCornerScreen = new Vector3(
        Screen.width, Screen.height, screenZ);
        Vector3 lowerLeftCornerWorld =
        Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);
        Vector3 upperRightCornerWorld =
        Camera.main.ScreenToWorldPoint(upperRightCornerScreen);
        screenLeft = lowerLeftCornerWorld.x;
        screenRight = upperRightCornerWorld.x;
        screenTop = upperRightCornerWorld.y;
        screenBottom = lowerLeftCornerWorld.y;
        // save collider dimension values 
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        Vector3 diff = collider.bounds.max - collider.bounds.min;
        colliderHalfWidth = diff.x / 2;
        colliderHalfHeight = diff.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        // move teddy bear to mouse location 
        transform.position = worldPosition;
        ClampInScreen();
        if (Input.GetAxis("BlowUpTeddy") > 0)
        {
            Instantiate(prefabExplosion, transform.position, Quaternion.identity);
            print("anime called");
            Destroy(gameObject);
        }


    }

    void ClampInScreen()
    {
        // check boundaries and shift as necessary 
        Vector3 position = transform.position;
        if (position.x - colliderHalfWidth < screenLeft)
        {
            position.x = screenLeft + colliderHalfWidth;
        }
        if (position.x + colliderHalfWidth > screenRight)
        {
            position.x = screenRight - colliderHalfWidth;
        }
        if (position.y + colliderHalfHeight > screenTop)
        {
            position.y = screenTop - colliderHalfHeight;
        }
        if (position.y - colliderHalfHeight < screenBottom)
        {
            position.y = screenBottom + colliderHalfHeight;
        }
        transform.position = position;
    }
}
