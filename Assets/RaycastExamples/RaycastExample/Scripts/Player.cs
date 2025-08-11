using UnityEngine;

    public class Player : MonoBehaviour
    {
        private IShooter _shooter;

        public void SetShooter(IShooter shooter) => _shooter = shooter;
       
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _shooter.Shoot();
            }
        }
    }