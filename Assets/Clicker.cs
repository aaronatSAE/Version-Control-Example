﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [SerializeField]
    GameObject cubePrefab;
	public Image image;
	public float currentImageColorAlpha = 0.0f;

<<<<<<< HEAD
<<<<<<< HEAD
	void start()
	{
		image = GetComponent<Image> ();
		currentImageColorAlpha = image.color.a;
	}
	void Update()
=======
    void Update()
>>>>>>> parent of c50dc00... Change to sphere
=======
    void Update()
>>>>>>> parent of c50dc00... Change to sphere
    {
        if (Input.GetMouseButton(0))
        {
			currentImageColorAlpha += 0.1f;
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
