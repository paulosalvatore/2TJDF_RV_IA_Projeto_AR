using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
	public GameObject zumbiPrefab;

	[Range(0.1f, 10f)]
	public float delayZumbi = 2f;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void IniciarGeradorZumbis(GameObject spawn)
	{
		StartCoroutine(GerarZumbis(spawn));
	}

	public void EncerrarGeradorZumbis()
	{
		StopAllCoroutines();
	}

	private IEnumerator GerarZumbis(GameObject spawn)
	{
		while (true)
		{
			GameObject instancia = Instantiate(zumbiPrefab);

			instancia.transform.parent = spawn.transform.parent;

			Vector2 posicaoAleatoria = Random.insideUnitCircle;

			instancia.transform.position = new Vector3(
				posicaoAleatoria.x,
				0,
				posicaoAleatoria.y
			);

			yield return new WaitForSeconds(delayZumbi);
		}
	}
}
