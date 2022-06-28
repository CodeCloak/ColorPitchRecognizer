using System;
using UnityEngine;


public class ActivationTrigger : MonoBehaviour
{

	[SerializeField]
    protected GameObject[] _list;
	
	[SerializeField]
    protected bool _flag; //Don't need this for a project this small
	
	
	private void OnTriggerEnter(Collider other)
    {
        foreach(GameObject g in _list)
		{
			g.SetActive(_flag);
		}
    }

}