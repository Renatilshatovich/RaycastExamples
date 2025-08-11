using UnityEngine;

public class StandardShooter : IShooter
{
    private int _damage;

    public StandardShooter(int damage) => 
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
