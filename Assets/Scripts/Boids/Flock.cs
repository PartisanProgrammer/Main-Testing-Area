using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Flock : MonoBehaviour{
    public FlockAgent agentPrefab;
    public FlockBehaviourSO flockBehaviour;
    List<FlockAgent> agents = new List<FlockAgent>();

    [Range(10, 500)] public int startingCount = 250;
    const float AgentDensity = 0.08f;

    [Range(1f, 100f)] public float driveFactor = 10f;
    [Range(1f, 100f)] public float maxSpeed = 5f;
    [Range(1f, 10f)] public float neighborRadius = 1.5f;
    [Range(0f, 1f)] public float avoidanceRadiusMultiplier = 0.5f;

    float squareMaxSpeed;
    float squareNeighborRadius;
    float squareAvoidanceRadius;
    public float SquareAvoidanceRadius{ get; }


    void Start(){
        squareMaxSpeed = maxSpeed * maxSpeed;
        squareNeighborRadius = neighborRadius * neighborRadius;
        squareAvoidanceRadius = squareNeighborRadius * avoidanceRadiusMultiplier * avoidanceRadiusMultiplier;

        //Flock Set Up
        for (int i = 0; i < startingCount; i++){
            FlockAgent newAgent = Instantiate(
                agentPrefab, Random.insideUnitSphere * startingCount * AgentDensity,
                Quaternion.Euler(Vector3.forward * Random.Range(0f, 360f)), transform);
            newAgent.name = "Agent " + i;
            agents.Add(newAgent);
        }
        
    }

    void Update(){
        foreach (var agent in agents){
            List<Transform> context = GetNearbyObjects(agent);

            agent.GetComponentInChildren<MeshRenderer>().material.color = Color.Lerp(Color.green, Color.red, context.Count / 6f); // Demo only
            
        Vector3 move = flockBehaviour.CalculateMove(agent, context, this);
        move *= driveFactor;
        if (move.sqrMagnitude > squareMaxSpeed){
            move = move.normalized * maxSpeed;
        }
        
        agent.MoveTowards(move);
        }
    }

    List<Transform> GetNearbyObjects(FlockAgent agent){
        List<Transform> context = new List<Transform>();
        Collider[] contextColliders = Physics.OverlapSphere(agent.transform.position, neighborRadius);
        foreach (var collider in contextColliders){
            if (collider != agent.AgentCollider){
                context.Add(collider.transform);
            }
        }

        return context;
    }
}
