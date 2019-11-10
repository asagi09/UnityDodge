using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketGenerator : MonoBehaviour
{
    public GameObject rocketPrefab;
    float span = 0.8f;
    float delta = 0;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span){
            this.delta = 0;
            GameObject go = Instantiate(rocketPrefab) as GameObject;
            int px = Random.Range(-4, 3);
            go.transform.position = new Vector3(7, px, 3);
            
        }
    }
}
