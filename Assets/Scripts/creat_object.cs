using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class creat_object : MonoBehaviour
{

    public GameObject[] objects;
     void Start()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }
}
