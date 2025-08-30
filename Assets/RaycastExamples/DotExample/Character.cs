using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private FieldOfViewCondition _fieldOfViewCondition;

    private void Awake() => 
        _fieldOfViewCondition = new FieldOfViewCondition(transform, 90);

    private void Update()
    {
        if (_fieldOfViewCondition.IsCompleteFor(_target))
            _target.transform.localScale = new Vector3(2, 2, 2);
        else
            _target.transform.localScale = new Vector3(1, 1, 1);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 position = transform.position;
        Gizmos.DrawLine(position,  _target.position);
        Gizmos.DrawRay(position, transform.forward * 100);
    }
}
