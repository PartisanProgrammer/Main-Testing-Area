using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Damage Type Vulnerability List", menuName = "Character/Vulnerability List")]
public class DamageTypeVulnerabilities : SimpleCharacterComponentSO{
    public List<DamageTypeSO> vulnerabilities;
}
