using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForce : MonoBehaviour
{
    Rigidbody rb;
    Vector3 forceDir;
    float forceResetTimer;
    [SerializeField] float forceIntensity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        forceResetTimer = 5f;

    }

    void Update()
    {
        forceResetTimer -= Time.deltaTime;
        if (forceResetTimer < 0)
        {
            forceDir.x = Random.Range(-10, 10);
            forceDir.z = Random.Range(-10, 10);
            forceResetTimer = 5f;
            Debug.Log("Force Direction: "+forceDir);
            // generates two random integer to be used as force direction in a 2d axis
        }
        rb.AddForce(forceDir * forceIntensity * Time.deltaTime, ForceMode.Force); //Add a global force
    }
}
