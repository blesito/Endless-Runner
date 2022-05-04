using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    SectionSpawner sectionSpawner;

    // Start is called before the first frame update
    void Start()
    {
        sectionSpawner = GetComponent<SectionSpawner>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
        sectionSpawner.MoveSector();
        Debug.Log("SD");
    }
}
