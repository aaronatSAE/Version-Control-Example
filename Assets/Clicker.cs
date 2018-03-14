using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    [SerializeField]
    GameObject spherePrefab;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject newSphere = Instantiate(spherePrefab, RandomVector(5f), Random.rotation) as GameObject;
            newSphere.GetComponent<Rigidbody>().AddForce(RandomVector(500f));
            newSphere.GetComponent<Rigidbody>().AddTorque(RandomVector(10f));
            newSphere.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
            Destroy(newSphere, Random.Range(1f, 4f));
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
