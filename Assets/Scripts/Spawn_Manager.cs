using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    road_spawner roadSpawner;
    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<road_spawner>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
    }
}
