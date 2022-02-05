using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Position", menuName = "Global Variables/Position")]
public class PositionSO : ScriptableObject
{
  public Vector3 Value { get; set; }
}
