using System;
using UnityEngine;

public class GroundCheck : MonoBehaviour{
    [SerializeField] AdvancedCharacterSO characterSo;
    
    [SerializeField] float groundCheckLenght = 1f;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundLayers;


    GroundedSO _groundedSo;
    void Awake(){
        _groundedSo = characterSo.GetComponent<GroundedSO>();
    }

    bool IsGrounded{
        get => _groundedSo.isGrounded;
        set => _groundedSo.isGrounded = value;
    }
    void Update(){
        _groundedSo.timeSinceGrounded += Time.deltaTime;
        if (_groundedSo.isGrounded){
            _groundedSo.timeSinceGrounded = 0f;
        }

        GroundChecker();
    }

    /// <summary>
    /// Casts a sphere from the transform's position downwards, dependant on radius, max distance and a layermask
    /// </summary>
    void GroundChecker(){
        var ray = new Ray(transform.position, Vector3.down);
        IsGrounded = Physics.SphereCast(ray, groundCheckRadius,groundCheckLenght,groundLayers);
        //Debug.DrawRay(transform.position,Vector3.down * groundCheckLenght, Color.magenta);
    }

    void OnDrawGizmos(){
        Gizmos.DrawWireSphere(transform.position + Vector3.down * groundCheckLenght, groundCheckRadius);
    }
}