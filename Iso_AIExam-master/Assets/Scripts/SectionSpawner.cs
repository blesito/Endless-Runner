using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SectionSpawner : MonoBehaviour
{
    public List<GameObject> path;
    private float offset = 20f;
    // Start is called before the first frame update
    void Start()
    {
        if(path != null && path.Count > 0)
        {
            path = path.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MoveSector()
    {
        GameObject movedSector = path[0];
        path.Remove(movedSector);
        float newZ = path[path.Count - 1].transform.position.z + offset;
        movedSector.transform.position = new Vector3(0,0,newZ);
        path.Add(movedSector);
        Debug.Log("SD"); 
    }
}
