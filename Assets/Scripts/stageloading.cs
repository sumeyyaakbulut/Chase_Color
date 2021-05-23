using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class stageloading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//scenemanager sahne yuklemedir,loadscene ,aktif sahneyi bul onu girdi olarak al
    }
}
