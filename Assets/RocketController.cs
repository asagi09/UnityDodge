using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketController : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.2f, 0, 0);
        if(transform.position.x < -10.0){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        SceneManager.LoadScene("last");
    }
}
