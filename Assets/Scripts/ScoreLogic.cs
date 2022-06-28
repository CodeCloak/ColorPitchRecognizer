using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreLogic : MonoBehaviour
{
	
	[SerializeField]
	protected BallColorer _ball;
	
	[SerializeField]
	protected Dropdown _dropdown;
	
	[SerializeField]
	protected Text _correctLabel;
	
	[SerializeField]
	protected Text _incorrectLabel;
	
	protected int _selectedColor;
	
	protected int _correct = 0;
	
	protected int _incorrect = 0;

	void Start()
    {
		_correctLabel.text =  "Correct: 0";
		_incorrectLabel.text =  "Incorrect: 0";
    }

	public void CheckForCorrect()
	{
		//Relies on use of same list. Any way to verify?
		if(_dropdown.value == _ball.ChosenColor)
		{
			_correctLabel.text =  "Correct: " + ++_correct;
		}
		else
		{
			_incorrectLabel.text =  "Incorrect: " + ++_incorrect;
		}
	}	
}