using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody2D rb;
    bool isStarted;
    public float bounceForce;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStarted){
            if (Input.anyKeyDown) {
                Bounce();
                isStarted = true;
                GameManager.instance.GameStart();
            }
 

        }
    }

    void OnCollisionEnter2D(Collision2D other){
    {       
        if (other.gameObject.tag == "Pad"){

            Bounce();
            bounceForce -= 1;
            GameManager.instance.ScoreUp();

        }

        if(other.gameObject.tag == "FallCheck") {
            GameManager.instance.Restart();
        }
         
        }

    }


    void Bounce() {
        Vector2 randomDirection = new Vector2(Random.Range(-1,1),1);
        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    
    }
}
