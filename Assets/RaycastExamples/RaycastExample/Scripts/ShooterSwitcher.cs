using UnityEngine;
using UnityEngine.Serialization;

public class ShooterSwitcher : MonoBehaviour
{
    [FormerlySerializedAs("player")] [SerializeField] private Player _player;

    private void Awake() => 
        _player.SetShooter(new StandardShooter(10));

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
            _player.SetShooter(new StandardShooter(10));
        
        if (Input.GetKeyDown(KeyCode.Alpha2)) 
            _player.SetShooter(new ExplosionShooter(20, 4));
        
    }
}
