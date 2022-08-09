using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class FlockAgent : MonoBehaviour{
    Collider agentCollider;

    public Collider AgentCollider{
        get => agentCollider;
    }

    void Start(){
        agentCollider = GetComponent<Collider>();
    }

    public void MoveTowards(Vector3 velocity){
        transform.forward = velocity;
        transform.position += (Vector3)velocity * Time.deltaTime;
    }
}
