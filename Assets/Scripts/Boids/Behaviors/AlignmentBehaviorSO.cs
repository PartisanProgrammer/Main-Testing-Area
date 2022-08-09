using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Alignment Behaviour", menuName = "Boids/Flock Behaviours/Alignment Behavior")]
public class AlignmentBehaviorSO : FlockBehaviourSO
{

    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock){
        //If no neighbors, maintain current alignment
        if (context.Count == 0){
            return agent.transform.forward;
        }
        //Add all points together and average
        Vector3 alignmentMove = Vector3.zero;
        foreach (var neighbor in context){
            alignmentMove += neighbor.transform.forward;
        }

        alignmentMove /= context.Count;
        
        return alignmentMove;


    }
}
