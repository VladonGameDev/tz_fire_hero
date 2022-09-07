using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public Config config;

	//Тут создаём базовую куратину на стрельбу что будет работать всю игру, скорость стртельбы можно отрегулировать из конфига
    private void Start()
    {
		StartCoroutine(ShootingCoroutine());
    }
    IEnumerator ShootingCoroutine()
	{
		while (true)
		{
			yield return new WaitForSeconds(config._firingSpeed);
			Instantiate(config.bulletPrefab, new Vector2(transform.position.x, transform.position.y + 0.6f), Quaternion.identity);
		}
	}
}
