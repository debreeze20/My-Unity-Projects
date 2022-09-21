using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    
    public Vector3 kekanan, kekiri, maju, mundur, keatas, kebawah;
    public int aksi;
    float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        // kekanan = Vector3.right;
        // kekiri = Vector3.left;
        // maju = Vector3.forward;
        // mundur = Vector3.back;
        // keatas = Vector3.up;
        // kebawah = Vector3.down;
        
        kekanan = new Vector3(1,0,0);
        kekiri = new Vector3(-1,0,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);
        keatas = new Vector3(0,1,0);
        kebawah =new Vector3(0,-1,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right")) {
            transform.position = transform.position+(kekanan*speed*Time.deltaTime);
        }

        if (Input.GetKey("left")) {
            transform.position = transform.position+(kekiri*speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W)) {
            transform.position = transform.position + (maju*speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.position = transform.position + (mundur*speed*Time.deltaTime);
        }

        if (Input.GetMouseButton (0)) {
            if (Input.GetKey(KeyCode.J)) {
                transform.rotation = transform.rotation*toQuaternion(kekanan*speed*Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.G)) {
                transform.rotation = transform.rotation*toQuaternion(kekiri*speed*Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Y)) {
                transform.rotation = transform.rotation*toQuaternion(keatas*speed*Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.H)) {
                transform.rotation = transform.rotation*toQuaternion(kebawah*speed*Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.T)) {
                transform.rotation = transform.rotation*toQuaternion(maju*speed*Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.U)) {
                transform.rotation = transform.rotation*toQuaternion(mundur*speed*Time.deltaTime);
            }
        } else {

        }
        
        // switch (aksi) {
        //     case 0 :
        //         transform.Translate(Vector3.right*2f*Time.deltaTime);
        //         break;
        //     case 1:
        //         transform.Translate(Vector3.left*2f*Time.deltaTime);
        //         break;
        //     case 2:
        //         transform.Translate(Vector3.forward*2f*Time.deltaTime);
        //         break;
        //     case 3:
        //         transform.Translate(Vector3.back*2f*Time.deltaTime);
        //         break;
        //     case 4:
        //         transform.Translate(Vector3.up*2f*Time.deltaTime);
        //         break;
        //     case 5:
        //         transform.Translate(Vector3.down*2f*Time.deltaTime);
        //         break;           
        // }
    }

    static Quaternion toQuaternion (Vector3 euler) {
        Quaternion q;
        float pitch = euler.x;
        float roll = euler.y;
        float yaw = euler.x;
        float t0 = Mathf.Cos(yaw*0.5f);
        float t1 = Mathf.Sin(yaw*0.5f);
        float t2 = Mathf.Cos(roll*0.5f);
        float t3 = Mathf.Sin(roll*0.5f);
        float t4 = Mathf.Cos(pitch*0.5f);
        float t5 = Mathf.Sin(pitch*0.5f);
        Debug.Log(t0+" "+t1+" "+t2+" "+t3+" "+t4+" "+t5+" ");

        q.x = t0*t3*t4-t1*t2*t5;
        q.y = t0*t2*t5+t1*t3*t4;
        q.z = t1*t2*t4-t0*t3*t5;
        q.w = t0*t2*t4+t1*t3*t5;
        return q;
    }

    void OnCollisionEnter2D (Collision2D coll) {
        if (coll.gameObject.tag == "enemyTag") {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }

    void OnCollisionStay2D (Collision2D coll) {
        if (coll.gameObject.tag == "enemyTag") {
            Debug.Log("Sedang Nabrak");
        }
    }

    void OnCollisionExit2D (Collision2D coll) {
        if (coll.gameObject.tag == "enemyTag") {
            Debug.Log("Sudah Nabrak");
        }
    }
}
