using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabImg;
    [SerializeField]
    Sprite image;

    const float MinSpawnDelay = 1;
    const float MaxSpawnDelay = 2;

    Timer spwanTimer;

    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;

    // Start is called before the first frame update
    void Start()
    {
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        print("width:"+Screen.width+ "height:"+ Screen.height);
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;
        spwanTimer = gameObject.AddComponent<Timer>();
        spwanTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spwanTimer.Run();


    }

    // Update is called once per frame
    void Update()
    {
        if (spwanTimer.Finished)
        {
            Spawn();
            spwanTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spwanTimer.Run();
        }
    }
    void Spawn()
    {
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
             -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        GameObject img = Instantiate(prefabImg) as GameObject;
        img.transform.position = worldLocation;
        SpriteRenderer spriteRenderer = img.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = image;


    }
}
