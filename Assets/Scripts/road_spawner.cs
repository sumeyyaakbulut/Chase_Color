using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class road_spawner : MonoBehaviour
{
    public List<GameObject> roads;
    private float offset = 3f;//yolun  position z 

   
    void Start()
    {

        if (roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MoveRoad()
    {
        GameObject moveRoad = roads[0];
        roads.Remove(moveRoad);
        float newZ = roads[roads.Count - 1].transform.position.z + offset;
        moveRoad.transform.position = new Vector3(0, 0, newZ);
        roads.Add(moveRoad);
    }
}
