using UnityEngine;
using System.Collections;

public class DeathContrl : MonoBehaviour {

	public GameObject Death;
	//获取死亡之翼模型
	public GameObject RoteDeath;
	//获取调整旋转轴向的死亡之翼父级物体

	private Animator _anim;
	//获取动画机
	private int CountTouch=0;
	//记录动画播放状态
	private int CountScript=0;
	//记录单指移动和单指旋转的切换状态

	// Use this for initialization
	void Start () {
		_anim=Death.GetComponent<Animator>();
		//获取动画状态机
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//用于切换动画的UI按钮
	public void DeathButton(){
		if (CountTouch == 0) {
			_anim.SetTrigger ("Sleep");
			//动画切换为飞行
			CountTouch = 1;
		} else if (CountTouch == 1) {
			_anim.SetTrigger ("Shift");
			//动画切换为晃头
			CountTouch = 2;
		} else if (CountTouch == 2) {
			_anim.SetTrigger ("Fly");
			//动画切换为睡觉
			CountTouch = 3;
		}else if (CountTouch == 3) {
			_anim.SetTrigger ("Idle");
			//动画切换为待机
			CountTouch = 0;
		}
	}

	//用于切换单指移动和旋转的UI按钮
	public void ScriptCtrl(){
		if(CountScript==0){
			RoteDeath.GetComponent<SimpleDrag> ().enabled = false;
			RoteDeath.GetComponent<Rotate1> ().enabled = true;
			CountScript=1;
		}else{
			RoteDeath.GetComponent<SimpleDrag> ().enabled = true;
			RoteDeath.GetComponent<Rotate1> ().enabled = false;
			CountScript = 0;
		}
	}
}
