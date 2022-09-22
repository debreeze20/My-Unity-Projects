using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    private static MusicManager instance = null;
    // Start is called before the first frame update
    public MusicManager Instance()
    {
        return instance;
    }

    // Update is called once per frame
    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy (this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
