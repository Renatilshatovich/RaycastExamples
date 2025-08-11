using UnityEngine;

public class Shooter
{
    private int _damage;

    public Shooter(int damage) => 
        _damage = damage;

    public void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            IDamageable damageable = hit.collider.GetComponent<IDamageable>();

            if (damageable != null) 
                damageable.TakeDamage(_damage);
        }
    }
}
