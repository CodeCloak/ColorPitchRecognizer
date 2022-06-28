using UnityEngine;


public class BallColorer : MonoBehaviour
{
	[SerializeField]
    protected ColorList _colorList;
		
	public int ChosenColor {
		get; protected set;
	}
	
	void Start()
    {
        RandomizeColor();
    }
	
	public void RandomizeColor()
	{
		GetComponent<Renderer>().enabled = true;
		
		ChosenColor = new System.Random().Next(_colorList.colors.Length);
	
		GetComponent<Renderer>().material.color = _colorList.colors[ChosenColor];	
	}
	
	private void OnTriggerEnter(Collider other)
    {
		GetComponent<Renderer>().enabled = false;
    }
	
}