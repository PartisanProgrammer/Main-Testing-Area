using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveExperience : MonoBehaviour
{
    [SerializeField] AdvancedCharacterSO targetCharacterSo;
    [SerializeField] SimpleCharacterSO characterSo;
    
    ExperienceWorthSO _experienceWorthSo;
    ExperienceSO _targetLevel;

    void Awake(){
        _experienceWorthSo = characterSo.GetComponent<ExperienceWorthSO>();
        _targetLevel = targetCharacterSo.GetComponent<ExperienceSO>();
    }

    public void GiveXP()
    {
        _targetLevel.AddExperience(_experienceWorthSo._experienceWorth);
    }
}
