using Unity.VisualScripting;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    private void Update()
    {
        Ray ray = new Ray(Vector3.zero, Vector3.forward);
        // RayInfo(ray);

        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RayInfo(cameraRay);

        Physics.RaycastAll(ray);
    }

    private static void RayInfo(Ray ray)
    {
        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            Debug.Log(hitInfo.collider.gameObject.name);
        }
    }

    private void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.color = Color.red;
            // Gizmos.DrawRay(Vector3.zero, Vector3.forward * 100);
        
            // Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Gizmos.DrawRay(cameraRay.origin, cameraRay.direction * 100);

            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Gizmos.DrawSphere(mouseWorldPosition, 1);
            Gizmos.DrawRay(mouseWorldPosition, Camera.main.transform.forward * 100);
        }
    }
}
