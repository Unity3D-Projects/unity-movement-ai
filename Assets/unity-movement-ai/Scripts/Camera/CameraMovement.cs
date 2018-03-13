﻿using UnityEngine;

namespace UnityMovementAI
{
    public class CameraMovement : MonoBehaviour
    {

        public Transform target;

        private Vector3 displacement;

        void Start()
        {
            displacement = transform.position - target.position;
        }

        void LateUpdate()
        {
            if (target != null)
            {
                transform.position = target.position + displacement;
            }
        }
    }
}