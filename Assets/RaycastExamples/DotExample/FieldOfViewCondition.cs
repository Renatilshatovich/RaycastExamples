using UnityEngine;

public class FieldOfViewCondition : IVisibilityCondition
{
    private Transform _sourceObject;

    private float _fieldOfViewDegree;

    public FieldOfViewCondition(Transform sourceObject, float fieldOfViewDegree)
    {
        _sourceObject = sourceObject;
        _fieldOfViewDegree = fieldOfViewDegree;
    }

    public bool IsCompleteFor(Transform target)
    {
        Vector3 directionToTarget = target.position - _sourceObject.position; // направление до цели

        float dotProduct = Vector3.Dot(directionToTarget, _sourceObject.forward);  // операция скалярного произведения

        float cos = dotProduct / (directionToTarget.magnitude * _sourceObject.position.magnitude); // рассчитать косинус необходимого угла

        float angleToTarget = Mathf.Acos(cos) * Mathf.Deg2Rad; // рассчитать угол между тем, куда смотрит игрок и направление до цели

        if (angleToTarget > -_fieldOfViewDegree / 2)
            return false;
        return true;
    }
}
