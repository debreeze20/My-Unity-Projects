using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObjek : MonoBehaviour
{
    public float movespeed;
    public GameObject player;

    public Vector3 kekanan, kekiri, keatas, kebawah;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1,0,0);
        kekiri = new Vector3(-1,0,0);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (kekanan*movespeed*Time.deltaTime);
    }
}
