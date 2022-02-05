using UnityEngine;

public class GroundCheck : MonoBehaviour{
    [SerializeField] IndividualCharacterSO characterSo;
    
    [SerializeField] float groundCheckLenght = 1f;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundLayers;
    

    bool IsGrounded{
        get => characterSo.groundedSo.isGrounded;
        set => characterSo.groundedSo.isGrounded = value;
    }
    void Update(){
        characterSo.groundedSo.timeSinceGrounded += Time.deltaTime;
        if (characterSo.groundedSo.isGrounded){
            characterSo.groundedSo.timeSinceGrounded = 0f;
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