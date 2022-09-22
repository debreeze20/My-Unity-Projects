using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    
    public GameObject rocks;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 1f, 1.5f);
    }

    void CreateObstacle() {
        Instantiate(rocks);
        score++;
        SaveLoadHighscore.SaveHighScore(score);
        if (score >= 2) {
            GUIManager.saveLevel(1);
        } if (score >= 4) {
            GUIManager.saveLevel(2);
        }
    }

    void OnGUI () {
        GUI.color = Color.black;
        GUILayout.Label("Score: "+score.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
