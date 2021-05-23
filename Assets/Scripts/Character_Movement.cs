using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Movement : MonoBehaviour
{

    public float movementspeed = 5f;
    public Spawn_Manager spawnManager;//yeni yol ekle

    public Material mt;
    public string currentColor;//string olrak karakter rengini gösterir
    public Color colorBlue;
    public Color colorPink;
    
    public Color colorOrange;
    public Color colorYellow;

    public AudioClip colorsound;
    public int  score;
    public Text scorecolortext;
    public int currentHealth;
    public int maxHealth = 100;
    public Healty_Bar healthBar;

    public ParticleSystem pc;//paticle systeme erismek icin
    private Color currentcol;//color olarak renkleri gösterir

    public static bool gamestarted = false;
    public static bool gamelevelstarted = false;
    public GameObject GameOnePanel;
    public GameObject game_over;
    public GameObject Level1;
    public GameObject soundpanel;
   

    public Text endgame_color;
    public Text endgame_object;
    public int n = 1;
    public Text endgame_level;
    //public Transform lastobject;//sonradan ekledim
    void Start()
    {
        SetRandomColor();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gamestarted == false)
        {
            return;
        }
        float hMovement = Input.GetAxis("Horizontal") * movementspeed;
        float vMovement = Input.GetAxis("Vertical") * movementspeed;
        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);

        
        
    }
    private void OnTriggerEnter(Collider other)
    {

        soundpanel.SetActive(false);
        if (other.tag == "ColorChange")
        {
           
            SetRandomColor();
            GetComponent<AudioSource>().PlayOneShot(colorsound);
            var main = pc.main;// karakter renkli kareye deðince particle renk ayný olsun
            main.startColor = currentcol;
            score +=10;
            scorecolortext.text = score.ToString();
            Destroy(other.gameObject);

            
            //return;
        }
        
        else if (other.tag == "level_1")
        {
            Level1.SetActive(true);
            endgame_level.text = (++n).ToString();

            if (gamelevelstarted==false)
            {
                return;
            }
            Debug.Log("Hello");
            
           // Level1.SetActive(false);
        }
        else if (other.tag == currentColor)
        {

            Destroy(other.gameObject);
            currentHealth += 25;
            soundpanel.SetActive(true);
            healthBar.SetHealth(currentHealth);
            
        }
        
        else if (other.tag != currentColor)
        {


            Destroy(other.gameObject);
            currentHealth -= 25;
            healthBar.SetHealth(currentHealth);
            if (currentHealth<=0)
            {
                game_over.SetActive(true);
                endgame_color.text =score.ToString();
                endgame_object.text = currentHealth.ToString();
            }

        }

    }
  

    private void OnCollisionExit(Collision collision)
    {
        spawnManager.SpawnTriggerEntered();

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "die" || collision.gameObject.tag == "die1")
        {
            game_over.SetActive(true);
            endgame_color.text = score.ToString();
           
            endgame_object.text = currentHealth.ToString();
        }
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
           
            
            case 0:
                currentColor = "Pink";
                mt.color = colorPink;
                currentcol = colorPink;
                break;
            case 1:
                currentColor = "Blue";
                mt.color = colorBlue;
                currentcol = colorBlue;
                break;
            case 2:
                currentColor = "Orange";
                mt.color = colorOrange;
                currentcol = colorOrange;
                break;
            case 3:
                currentColor = "Yellow";
                mt.color = colorYellow;
                currentcol = colorYellow;
                break;

        }
        
    }
    public void game_start()
    {
        gamestarted = true;
        GameOnePanel.SetActive(false);
    }
    public void gamelevel1_start()
    {
        gamelevelstarted = true;
        Level1.SetActive(false);
    }
}
