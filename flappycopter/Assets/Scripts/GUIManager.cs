using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{

    public Button bEasy, bMed, bHard;

    // Start is called before the first frame update
    void Start()
    {
        try {
            LoadButtonLevel();
            int levelstate = LoadLevel();
            switch (levelstate) {
                case 0 :
                    bEasy.interactable = true;
                    break;
                case 1 :
                    bEasy.interactable = true;
                    bMed.interactable = true;
                    break;
                case 2 :
                    bEasy.interactable = true;
                    bMed.interactable = true;
                    bHard.interactable = true;
                    break;
            }
        } catch (NullReferenceException e) {

        }
    }

    public void OnPlay() {
        SceneManager.LoadScene("multilevel");
    }

    public void OnLevel1() {
        SceneManager.LoadScene("Main");
    }

    public void OnLevel2() {
        SceneManager.LoadScene("Main");
    }

    public void OnLevel3() {
        SceneManager.LoadScene("Main");
    }


    public void OnCredits() {
        SceneManager.LoadScene("credits");
    }

    public void OnHelp() {
        SceneManager.LoadScene("help");
    }

    public void OnBack() {
        SceneManager.LoadScene("Menu");
    }

    public static int LoadLevel() {
        int hg = 0;
        if (!PlayerPrefs.HasKey("level")) {
            PlayerPrefs.SetInt("level", 0);
        } else {
            hg = PlayerPrefs.GetInt("level");
        } return hg;
    }

    public static void saveLevel (int lvl) {
        if (!PlayerPrefs.HasKey("level")) {
            PlayerPrefs.SetInt("level", 0);
        } else {
            PlayerPrefs.SetInt("level", lvl);
        }
    }

    void LoadButtonLevel () {
        bEasy = GameObject.Find("Easy").GetComponent<Button>();
        bMed = GameObject.Find("Medium").GetComponent<Button>();
        bHard = GameObject.Find("Hard").GetComponent<Button>();
        bEasy.interactable = bMed.interactable = bHard.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
