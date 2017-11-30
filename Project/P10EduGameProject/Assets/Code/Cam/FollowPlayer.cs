using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    [SerializeField]
    private Transform _TargetGO;

    [SerializeField]
    private float _XOffset, _ZOffset;

	void FixedUpdate ()
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(_TargetGO.position.x - _XOffset , transform.position.y, _TargetGO.position.z - _ZOffset), 2f);
	}
}
