using UnityEngine;

//Этот конфиг создал для удобной настройки, чтобы не искать что и где настраивать, а настраивать всё в одном месте
[CreateAssetMenu(fileName = "Data", menuName = "Create Config", order = 1)]
public class Config : ScriptableObject
{
    public float _bulletStartSpeed;
    public float _bulletDamage;
    public float _firingSpeed;
    public float _enemySpeed;
    public float _enemySpawnSpeed;

    public GameObject bulletPrefab;
    public GameObject enemyPrefab;
}
