using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
	public IEnumerator Shake (float duration, float magnitude)
	{
		Vector3 originalPos = transform.localPosition;
		
		Debug.Log("CAMERA SHAKER ACTVITATED");
		
		float elapsed = 0.0f;
		
		while (elapsed < duration)
		{
			float x = Random.Range(-1f, 1f) * magnitude;
			float y = Random.Range(-1f, 1f) * magnitude;
			
			transform.localPosition = new Vector3(x, y, originalPos.z);
			
			elapsed += Time.deltaTime;
			Debug.Log("CAMERA SHAKER ACTVITATED in loop");
			
			yield return null;
		}
		
		transform.localPosition = originalPos;
	}
}
