using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(GiveExperience))]
[DisallowMultipleComponent]
public class DieOnContact : MonoBehaviour
{
    [SerializeField] IdentifierSO _targetIdentifier;
    [SerializeField] float impactForceMultiplier = 10f ;
    
    Rigidbody _rigidbody;
    GiveExperience _giveExperience;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _giveExperience = GetComponent<GiveExperience>();

    }

    void OnCollisionEnter(Collision collision)
    {
        
        var collisionIdentifier = collision.gameObject.GetComponent<IndividualCharacterHolder>()?.characterSo.identifierSo;
        if (collisionIdentifier == _targetIdentifier)
        {
            _giveExperience.GiveXP();
            this.gameObject.SetActive(false);
        }
    }
}
