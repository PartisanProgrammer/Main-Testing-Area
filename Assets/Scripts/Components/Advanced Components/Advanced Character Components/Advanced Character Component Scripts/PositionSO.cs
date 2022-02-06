using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Position", menuName = "Character/Advanced Character/Global Variables/Position")]
public class PositionSO : AdvancedCharacterComponentSO
{
  public Vector3 Value { get; set; }
}
