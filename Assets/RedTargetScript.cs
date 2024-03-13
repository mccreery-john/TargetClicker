using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTargetScript : MonoBehaviour
{
    public LogicScript logic;
    private float spawnRate = 1f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            missedTarget();
        }
    }

    public void OnClick()
    {
        logic.addScore();
        Destroy(gameObject);
    }


    public void missedTarget()
    {
        Destroy(gameObject);
        
    }
}
