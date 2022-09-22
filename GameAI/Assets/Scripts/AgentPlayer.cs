using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentPlayer : Agent
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");
        velocity *= maxSpeed;
        Vector3 translation = velocity*Time.deltaTime;
        transform.Translate(translation, Space.World);
        transform.LookAt(transform.position+velocity);
        orientation = transform.rotation.eulerAngles.y;
    }
}
