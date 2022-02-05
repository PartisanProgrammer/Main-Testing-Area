using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionUpdater : MonoBehaviour
{
   [SerializeField] PositionSO _positionSo;

   void Update()
   {
      //Sets the SO's position value to be the value of whatever this script is put on.
      _positionSo.Value = transform.position;
   }
}
