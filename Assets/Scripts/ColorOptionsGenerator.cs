using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorOptionsGenerator : MonoBehaviour
{
	[SerializeField]
    protected ColorList _colorList;
		
	protected Dropdown _dropdown;

	void Start()
    {
		_dropdown = GetComponent<Dropdown>();
		
		_dropdown.enabled = false;
		
		_dropdown.ClearOptions();
		
		List<Sprite> sprites = new List<Sprite>();
		
		foreach (Color c in _colorList.colors)
		{
			sprites.Add(createSprite(c));
		}
		
		_dropdown.AddOptions(sprites);
		
		_dropdown.enabled = true;
    }
	
	private Sprite createSprite(Color c)
	{
		c.a = 1; //Ensure it is visible

		Texture2D texture = new Texture2D(1, 1);

		texture.SetPixel(0, 0, c);
		
		texture.Apply();
			
		return Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f));
	}

	
}