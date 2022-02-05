using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Experience Data", menuName = "Level/Experience")]
public class ExperienceSO : ScriptableObject
{
    [Min(0)][SerializeField] int _experience;
    [Min(1)][SerializeField] int _level;
    [Min(1)][SerializeField] float _requiredExperience;
    [Min(1)][SerializeField] float _levelExperienceScaler;

    public int Experience
    {
        get => _experience;
        private set
        {
           _experience = value;
           CheckLevelUp();
        } 
    }

    public int Level
    {
        get => _level;
        private set
        {
           _level = value;
           //Things that happen when you level up
        } 
    }

    public float RequiredExperience
    {
        get => _requiredExperience;
        private set => _requiredExperience = value;
    }

    void OnDisable()
    {
        _experience = 0;
        _level = 1;
        _requiredExperience = 10;
       // _levelExperienceScaler = 1.3f;
    }

    public void AddExperience(int amount)
    {
        Experience += amount;
        //Display how much experience
    }


    public void CheckLevelUp()
    {
        if (Experience >= RequiredExperience)
        {
            Experience -= (int)RequiredExperience;
            Level++;
            RequiredExperience *= _levelExperienceScaler;
        }
    }
}
