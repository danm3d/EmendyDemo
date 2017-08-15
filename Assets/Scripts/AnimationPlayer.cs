using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Animator))]
public class AnimationPlayer : MonoBehaviour
{
	protected Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
	}


	public void PlayAnimation ()
	{
		anim.SetTrigger ("PlayCube");
	}
}
