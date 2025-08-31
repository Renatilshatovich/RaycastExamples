using UnityEngine;

public interface IVisibilityCondition
{
    bool IsCompleteFor(Transform target);
}
