using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _Speed, _Gravity;

    [SerializeField]
    private Transform _CamPos;

    private CharacterController _CharControl;
    private Vector3 _Movement = Vector3.zero;
    
    private void Start()
    {
        _CharControl = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (_CharControl.isGrounded)
        {
            _Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _Movement = _CamPos.transform.TransformDirection(_Movement);
            _Movement *= _Speed;
        }
        _Movement.y -= _Gravity * Time.deltaTime;
        _CharControl.Move(_Movement * Time.deltaTime);
    }
}
