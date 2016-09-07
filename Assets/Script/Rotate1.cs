using UnityEngine;
using System.Collections;

public class Rotate1 : MonoBehaviour
{

	Vector3 StartPosition;
	Vector3 previousPosition;
	Vector3 offset;
	Vector3 finalOffset;
	Vector3 eulerAngle;

	bool isSlide;
	float angle;

	void Start()
	{

	}


	void Update()
	{
		if (Input.GetMouseButtonDown(0))
			//当按下鼠标时
		{
			StartPosition = Input.mousePosition;
			//记录此时鼠标的位置
			previousPosition = Input.mousePosition;
			//将上一次位置记录为鼠标的位置
		}
		if (Input.GetMouseButton(0))
		{
			offset = Input.mousePosition - previousPosition;
			//偏移值为鼠标鼠标当前位置减去上一次鼠标的位置
			previousPosition = Input.mousePosition;
			//将上一次的位置记录为鼠标当前的位置


			transform.Rotate(Vector3.Cross(offset*0.1f, Vector3.up).normalized, offset.magnitude, Space.Self);
			//旋转的状态为



		}
		if (Input.GetMouseButtonUp(0))
		{
			finalOffset = Input.mousePosition - StartPosition;
			isSlide = true;
			angle = finalOffset.magnitude;


		}

	}
}
