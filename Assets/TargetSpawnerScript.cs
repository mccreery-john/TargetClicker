using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnerScript : MonoBehaviour
{

    public GameObject RedTarget;
    public GameObject BlueTarget;
    float heightOffset = 3f;
    float lengthOffset = 7.6f;

    private float spawnRate = 0.5f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnTarget();
    }

    // Update is called once per frame
    void Update()
    {
        //spawnTarget();
        //LogicScript.subScore();
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnTarget();
            timer = 0f;
        }
    }

    void spawnTarget()
    {
        float rightMostPoint = transform.position.x + lengthOffset;
        float leftMostPoint = transform.position.x - lengthOffset;

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        int max = 5;

        if (Random.Range(0, max) > 1)
        {
            Instantiate(RedTarget, new Vector3(Random.Range(leftMostPoint, rightMostPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }else
        {
            Instantiate(BlueTarget, new Vector3(Random.Range(leftMostPoint, rightMostPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
        //Instantiate(RedTarget, new Vector3(0, 0, 0), transform.rotation);
    }
}
