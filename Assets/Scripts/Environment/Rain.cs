using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    Rigidbody _rigidbody;
    ObjectPool _objectPool; 

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _objectPool = FindObjectOfType<ObjectPool>();

        //StartCoroutine(DisableAfterPeriod());
    }

    public void OnEnable()
    {
         _rigidbody.velocity = new Vector3(0,0,0);
    }

    // void OnTriggerEnter(Collider collider)
    // {
    //     this.gameObject.SetActive(false);
    // }
    void OnCollisionEnter(Collision Collider)
    {
        
        this.gameObject.SetActive(false);
        _objectPool.ReturnGameObject(this.gameObject);
    }
    
    IEnumerator DisableAfterPeriod()
    {
        yield return new WaitForSeconds(5);
        this.gameObject.SetActive(false);
        _objectPool.ReturnGameObject(this.gameObject);
    }
    
    
}
