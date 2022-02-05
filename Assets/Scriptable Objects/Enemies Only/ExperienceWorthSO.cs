using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Experience Worth Data", menuName = "Level/Experience Worth")]
public class ExperienceWorthSO : ScriptableObject
{
    [Min(0)][SerializeField] public int _experienceWorth;
    [Min(1)][SerializeField] public int _level;
}
