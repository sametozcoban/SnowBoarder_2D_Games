using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SnowBoarder.Characters
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float torqueAmount = 1f;
        [SerializeField] float boostSpeed = 25f;
        [SerializeField] float basedSpeed = 20f;
        
        Rigidbody2D _rigidbody2D;
        SurfaceEffector2D _surfaceEffector2D;
        
        bool canMove = true;
        public static bool isPressed;
        void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (canMove)
            {
                RotatePlayer();
                RespondToBoost(); 
            }
        }
        void RotatePlayer()
        {
            if (Input.GetKey(KeyCode.A))
            {
                _rigidbody2D.AddTorque(torqueAmount);

            }
            else if (Input.GetKey(KeyCode.D))
            {
                _rigidbody2D.AddTorque(-torqueAmount);
            }
        }

        void RespondToBoost()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _surfaceEffector2D.speed = boostSpeed;
                isPressed = true;
            }
            else
            {
                _surfaceEffector2D.speed = basedSpeed;
                isPressed = false;
            }
        }
        public bool DisableControl { get { return canMove = false; } set { return; } }
    }
}