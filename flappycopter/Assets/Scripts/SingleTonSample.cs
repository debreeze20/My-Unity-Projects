using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTonSample : MonoBehaviour
{
    private volatile static SingleTonSample singleTonObject;
    private static object lockingObject = new object();
    private SingleTonSample(){
        
    }

    public static SingleTonSample InstanceCreation() {
        

        if(singleTonObject == null) {
            lock (lockingObject) {
                if(singleTonObject == null){
                    singleTonObject = new SingleTonSample();
                }
            }
        }
        return singleTonObject;
    }

    public void DisplayMessage() {
        Debug.Log("Kelas Singelton!");
    }

}