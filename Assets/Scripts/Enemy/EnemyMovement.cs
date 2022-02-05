using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
[DisallowMultipleComponent]
public class EnemyMovement : MonoBehaviour
{
   [SerializeField] IndividualCharacterSO targetCharacterSo;
   [SerializeField] FloatVariableSO speed;

   NavMeshAgent _navMeshAgent;

   void Awake()
   {
      _navMeshAgent = GetComponent<NavMeshAgent>();
   }

   void Start(){
      _navMeshAgent.speed = speed.RuntimeValue;
   }

   void Update()
   {
      if (targetCharacterSo != null)
      {
         _navMeshAgent.SetDestination(targetCharacterSo.transformSo.position);
      }
      
      
      // foreach (var targetPosition in targetPositions)
      // {
      //    if (transform.position == _navMeshAgent.pathEndPosition)
      //    {
      //       
      //    }
      // }
      
      
   }
}
