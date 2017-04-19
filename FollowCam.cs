using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {

	public Transform targetTr;
	public float dist = 10.0f;  // 카메라와의 거리 
	public float height = 3.0f;  // 카메라와의 높이
	public float dampTrace = 20.0f;  // 부드러운 추적을 위한 변수 
	public Transform tr;  

	// Use this for initialization
	void Start () {

		tr = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate() {

		tr.position = Vector3.Lerp (tr.position, 
			                        targetTr.position - (targetTr.forward * dist) + (Vector3.up * height), 
			                        Time.deltaTime * dampTrace);

		tr.LookAt (targetTr.position);

	}
}
