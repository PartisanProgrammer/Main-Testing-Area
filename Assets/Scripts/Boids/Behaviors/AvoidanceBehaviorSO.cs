using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Avoidance Behaviour", menuName = "Boids/Flock Behaviours/Avoidance Behavior")]
public class AvoidanceBehaviorSO : FlockBehaviourSO
{
    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock){
        //If no neighbors, return no adjustment
        if (context.Count == 0){
            return Vector3.zero;
        }
        //Add all points together and average
        Vector3 avoidanceMove = Vector3.zero;
        int numberOfThingsToAvoid = 0;
        
        foreach (var neighbor in context){
            if (Vector3.SqrMagnitude(neighbor.position - agent.transform.position) > flock.SquareAvoidanceRadius){
                numberOfThingsToAvoid++;
                avoidanceMove += (Vector3)(agent.transform.position - neighbor.position);
            }
            
        }

        if (numberOfThingsToAvoid > 0){
            avoidanceMove /= numberOfThingsToAvoid;
        }
        return avoidanceMove;


    }
}
