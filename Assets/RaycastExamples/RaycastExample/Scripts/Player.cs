using UnityEngine;

    public class Player : MonoBehaviour
    {
        private Shooter _shooter;

        private void Awake()
        {
            _shooter = new Shooter(10);
        }
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _shooter.Shoot();
            }
        }
    }