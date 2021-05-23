using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_rotate : MonoBehaviour
    
{
    public AudioClip object_sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 150f, 0f) * Time.deltaTime);
    }

    

   

}
