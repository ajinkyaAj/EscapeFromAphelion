using System;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Controller3DExample : MonoBehaviour
{


	//public AnimationClip runAnimation;

	//private Animation _animation;
	private Animator _animationReal;
	//public Animator charAnim;

    public const float ROTATE_SPEED = 15f;

    public float movementSpeed = 5f;

    public CNAbstractController MovementJoystick;

    private CharacterController _characterController;
    private Transform _mainCameraTransform;
    private Transform _transformCache;
    private Transform _playerTransform;

	public static float movespeed = 1.5f;


	public float runMaxAnimationSpeed = 1.0f;

	//Calculate
	private Vector3 prevPosition;
	private Vector3 currentPosition;
	private float distance;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _mainCameraTransform = Camera.main.GetComponent<Transform>();
        _transformCache = GetComponent<Transform>();
		_playerTransform = GameObject.Find ("Vincent").transform;
	//	_animation = GetComponent<Animation> ();
		_animationReal = GetComponent<Animator> ();
		//charAnim = GetComponent<Animator> ();
    }

    void Awake() {
		//_animation = GetComponent(Animation);
	}

    // Update is called once per frame
    void Update()
    {
		//_characterState = CharacterState.Walking;
		prevPosition = this.gameObject.transform.position;

        var movement = new Vector3(
            MovementJoystick.GetAxis("Horizontal"),
            0f,
            MovementJoystick.GetAxis("Vertical"));

        CommonMovementMethod(movement);



    }



    private void CommonMovementMethod(Vector3 movement)
    {
        movement = _mainCameraTransform.TransformDirection(movement);

        movement.y = 0f;
        movement.Normalize();

        FaceDirection(movement);
		
		float speed = 6.0f;
		float gravity = 120.0f;
		if (!_characterController.isGrounded) {
			// To fall down when the player is not on ground
						movement.y -= gravity * Time.deltaTime;
		} 


		//Debug.Log ("Current Distance is :  " + distance);
		if (distance <= 0.0f )
		{
				
			_animationReal.SetBool ("isIdle", true);
		} 
		else
		{
			_animationReal.SetBool ("isIdle", false);

		}

		
		// Move the controller
		movementSpeed = movespeed;

		_characterController.Move(movement * movementSpeed * Time.deltaTime);

		currentPosition = this.gameObject.transform.position;

		//Debug.Log ("Previous Position is :  " + prevPosition);
		//Debug.Log ("Current Position is :  " + currentPosition);

		prevPosition.y = 0.0f;currentPosition.y = 0.0f;
		distance = Vector3.Distance(prevPosition,currentPosition);
		//Debug.Log ("Current Distance is :  " + distance);

    }

    public void FaceDirection(Vector3 direction)
    {
        StopCoroutine("RotateCoroutine");
        StartCoroutine("RotateCoroutine", direction);
    }

    IEnumerator RotateCoroutine(Vector3 direction)
    {
        if (direction == Vector3.zero) yield break;

        Quaternion lookRotation = Quaternion.LookRotation(direction);
        do
        {
            _playerTransform.rotation = Quaternion.Lerp(_playerTransform.rotation, lookRotation, Time.deltaTime * ROTATE_SPEED);
            yield return null;
        }
        while ((direction - _playerTransform.forward).sqrMagnitude > 0.2f);
    }

}
