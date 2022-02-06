using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Advanced Character", menuName = "Character/Simple Character/Simple Character")]
public class SimpleCharacterSO : CharacterSO
{

    public SimpleCharacterComponentSO[] components;
    
    
    void OnValidate(){
        for (var i = 0; i < components.Length; i++){
            
            for (var z = i+1; z < components.Length; z++){
                if (components[i] == components[z])
                {
                    Debug.Log($"{this.name}: has multiple components of same type {components[i]} and {components[z]}");
                }
            }
        }
    }

    public T GetComponent<T>() where T : SimpleCharacterComponentSO {
        foreach(var component in components)
            if(component is T t) return t;
        return default;
    }

}
