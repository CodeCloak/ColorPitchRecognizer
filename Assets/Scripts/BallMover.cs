using System;
using UnityEngine;


public class BallMover : MonoBehaviour
{

	//I would pull this out for use in other things
	[Serializable]
    public struct RandomCoord
    {
        public int min;
        public int max;
        public float Value
		{
			get
			{
				return UnityEngine.Random.Range(min, max);
			}
		}
    }

	[SerializeField]
    protected float _speed;
	
	[SerializeField]
    protected Transform _target;
	
    [SerializeField]
    protected RandomCoord _startX;
	
	[SerializeField]
    protected RandomCoord _startY;
	
	[SerializeField]
    protected RandomCoord _startZ;
	
	protected Vector3 _startPos;
	
	protected Vector3 _moveVec;
	
	protected Rigidbody _rigidBody;
	
	protected bool _moving = false;
	
	void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
				
		randomizeStart();
    }

		
	public void Move()
	{
		if(!_moving)
		{
			_startPos = transform.position;
			
			//normalized so we can use our speed variable regardless of start position
			_moveVec = (_target.position - _startPos).normalized;
			
			_moving = true;
		}
	}
	
	void FixedUpdate()
    {
		if(_moving)
		{
			var step =  _speed * Time.deltaTime;			
			_rigidBody.MovePosition(transform.position + _moveVec * step);
		}
    }
	
	private void OnTriggerEnter(Collider other)
    {
        _moving = false;
		randomizeStart();
    }
	
	private void randomizeStart()
	{
		_rigidBody.position = new Vector3(_startX.Value, _startY.Value, _startZ.Value);
	}

}