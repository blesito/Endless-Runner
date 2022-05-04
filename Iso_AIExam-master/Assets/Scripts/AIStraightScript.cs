using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStraightScript : MonoBehaviour
{

    Rigidbody enemyRB;
    float speed;


    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
      enemyRB.velocity = transform.forward * speed;

    }
}
