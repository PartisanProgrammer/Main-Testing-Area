using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Composite Behaviour", menuName = "Boids/Flock Behaviours/Composite Behavior")]
public class CompositeBehaviorSO : FlockBehaviourSO{
    public FlockBehaviourSO[] behaviors;
    public float[] weights;
    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock){
        //Handle Data mismatch
        if (weights.Length != behaviors.Length){
            Debug.Log("Data Mismatch in " + name, this);
            return Vector3.zero;
        }
        
        //Set up move
        Vector3 move = Vector3.zero;
        
        //Iterate through behaviors
        for (int i = 0; i < behaviors.Length; i++){
            Vector3 partialMove = behaviors[i].CalculateMove(agent, context, flock) * weights[i];

            if (partialMove != Vector3.zero){
                if (partialMove.sqrMagnitude > weights[i] * weights[i]){
                    partialMove.Normalize();
                    partialMove *= weights[i];
                }

                move += partialMove;
            }
        }

        return move;
    }
}
