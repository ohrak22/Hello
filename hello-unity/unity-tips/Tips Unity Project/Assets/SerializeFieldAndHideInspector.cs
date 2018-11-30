using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeFieldAndHideInspector : MonoBehaviour {

	[HideInInspector]
	public int secret = 42;

	[SerializeField]
	private float health = 100f;
}
