using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveExperience : MonoBehaviour
{
    [SerializeField] ExperienceWorthSO _experienceWorthSo;
    [SerializeField] IndividualCharacterSO characterSo;

    public void GiveXP()
    {
        characterSo.experienceSo.AddExperience(_experienceWorthSo._experienceWorth);
    }
}
