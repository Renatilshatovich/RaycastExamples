using UnityEngine;

public class ExplosionShooter : IShooter
{
    private int _damage;
    private float _radius;

    public ExplosionShooter(int damage, float radius)
    {
        _damage = damage;
        _radius = radius;
    }

    public void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Collider[] targets = Physics.OverlapSphere(hit.point, _radius);

            foreach (Collider target in targets)
            {
                IDamageable damageable = target.GetComponent<IDamageable>();

                if (damageable != null) 
                    damageable.TakeDamage(_damage);
            }
        }
    }
}
