using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public Config config;

	//��� ������ ������� �������� �� �������� ��� ����� �������� ��� ����, �������� ��������� ����� �������������� �� �������
	private void Start()
	{
		StartCoroutine(EnemySpawnerCoroutine());
		Instantiate(config.enemyPrefab, new Vector2(0, 7), Quaternion.identity);
	}
	IEnumerator EnemySpawnerCoroutine()
	{
		while (true)
		{
			yield return new WaitForSeconds(config._enemySpawnSpeed);
			Instantiate(config.enemyPrefab, new Vector2(0, 7), Quaternion.identity);
		}
	}
}
