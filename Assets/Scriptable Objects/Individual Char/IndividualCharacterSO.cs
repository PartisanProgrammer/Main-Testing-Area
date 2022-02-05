using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Individual Character", menuName = "Character/Individual Character")]
public class  IndividualCharacterSO : GenericCharacterSO{

    [Header("Individual objects")]
    //Health Object - Current hp, max hp, base max hp
    [SerializeField] public HealthSO healthSo;
    
   
    
    //Damage Object - Should have damage type, Base damage, current damage, 
    [SerializeField] public DamageSO damageSo;
    
    //Position Object - Position, rotation? Transform object maybe?
    [SerializeField] public TransformSO transformSo;
    
    //Stats Object - Strenght, Intelligence, Dexterity, Vulnerabilities and Effectiveness
    
    //Movement Object, current speed, max speed, base speed
    [SerializeField] public MovementSpeedSO movementSpeedSo;
    
    //Ranges Object - Detection Range, attack range, 
    
    //Grounded
    [SerializeField] public GroundedSO groundedSo;
    
    //***Player Only***
    [Header("Player Only")]
    
    //Experience Object - Current Level, Max Level, Current Xp, XP Level threshhold,Levelup xp multiplier
    [SerializeField] public ExperienceSO experienceSo;
    
    //Jump Object
    [SerializeField] public JumpSO jumpSo;



}
