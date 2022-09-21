using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionPlayerObjek : MonoBehaviour
{

    public Text teksScore;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter (Collision coll) {
        if (coll.collider.tag == "enemy") {
            score++;
            teksScore.text = "Score = "+score.ToString();
            Destroy (coll.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
