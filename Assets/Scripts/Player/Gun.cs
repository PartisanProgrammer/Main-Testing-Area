using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour{

    [SerializeField] GunSO gunSo;
    [SerializeField] IndividualCharacterSO characterSo;
    [SerializeField] Transform shootPoint;
    

    Camera Camera;

    void Awake(){
        Camera = Camera.main;
    }

    void Update(){
        Debug.DrawRay(shootPoint.position, shootPoint.forward *  gunSo.range,Color.red);
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
        
    }

    void Shoot(){
        RaycastHit hit;
        Debug.DrawRay(Camera.transform.position, Camera.transform.forward *  gunSo.range,Color.red);
        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, gunSo.range)){
            hit.transform.GetComponent<IDamageable>()?.TakeDamage(gunSo.Damage);
        }

    }
}
