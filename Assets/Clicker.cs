using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    [SerializeField]
    GameObject cubePrefab;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject newCube = Instantiate(cubePrefab, RandomVector(5f), Random.rotation) as GameObject;
            newCube.GetComponent<Rigidbody>().AddForce(RandomVector(500f));
            newCube.GetComponent<Rigidbody>().AddTorque(RandomVector(10f));
            newCube.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
            Destroy(newCube, Random.Range(1f, 4f));
        }
    }

    Vector3 RandomVector(float range)
    {
        float x = Random.Range(-range, range);
        float y = Random.Range(-range, range);
        float z = Random.Range(-range, range);

        return new Vector3(x, y, z);
    }
}
