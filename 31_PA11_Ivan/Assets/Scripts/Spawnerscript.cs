using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject red;
    public GameObject green;
    public GameObject brown;

    float randomNumber;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);

        randomNumber = Random.Range(1, 4);

        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        if (randomNumber == 1)
        {
            Instantiate(red, transform.position, transform.rotation);
        }

        if (randomNumber == 2)
        {
            Instantiate(green, transform.position, transform.rotation);
        }

        if (randomNumber == 3)
        {
            Instantiate(brown, transform.position, transform.rotation);
        }

    }
}
