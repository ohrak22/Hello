using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceAndHeader : MonoBehaviour {

	[Header("Transform")]
	public Vector3 position;
	public Vector3 rotation;
	public Vector3 scale;

	[Space]

	[Header("Properties")]
	public string objectName;
	public int objectCount;
	public float objectWeight;
}
