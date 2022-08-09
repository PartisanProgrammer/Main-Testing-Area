using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Cohesion Behaviour", menuName = "Boids/Flock Behaviours/Cohesion Behavior")]
public class CohesionBehaviorSO : FlockBehaviourSO
{
    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock){
        //If no neighbors, return no adjustment
        if (context.Count == 0){
            return Vector3.zero;
        }
        //Add all points together and average
        Vector3 cohesionMove = Vector3.zero;
        foreach (var neighbor in context){
            cohesionMove += neighbor.position;
        }

        cohesionMove /= context.Count;
        
        //Create offset from agent position
        cohesionMove -= agent.transform.position;
        return cohesionMove;


    }
}
