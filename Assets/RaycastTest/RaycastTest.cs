using Unity.VisualScripting;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    private void Update()
    {
        RayInfo();
    }

    private static void RayInfo()
    {
        Ray ray = new Ray(Vector3.zero, Vector3.forward);

        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            Debug.Log(hitInfo.collider.gameObject.name);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Vector3.zero, Vector3.forward * 100);
    }
}
