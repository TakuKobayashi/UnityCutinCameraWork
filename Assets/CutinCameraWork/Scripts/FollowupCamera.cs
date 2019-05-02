using UnityEngine;
using System.Collections;

namespace CutinCameraWork
{
    public class FollowupCamera : MonoBehaviour
    {
        [SerializeField] private Vector3 distance;
        [SerializeField] private Transform targetTransform;

        public Transform TargetTransform
        {
            set
            {
                targetTransform = value;
            }
            get
            {
                return targetTransform;
            }
        }

        public Vector3 Distance
        {
            set
            {
                distance = value;
            }
            get
            {
                return distance;
            }
        }

        void Update()
        {
            Vector3 targetPosition = Vector3.zero;
            if (targetTransform != null)
            {
                targetPosition = targetTransform.position;
            }
            this.transform.position = targetPosition + distance;
        }
    }
}