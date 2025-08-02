using UnityEngine;

public class Box : MonoBehaviour, IDamageable
{
    [SerializeField] private ParticleSystem _destroyEffect;

    public void TakeDamage(int damege)
    {
        Instantiate(_destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
