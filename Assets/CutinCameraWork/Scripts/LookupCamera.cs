using UnityEngine;
using System.Collections;

namespace CutinCameraWork
{
    public class LookupCamera : MonoBehaviour
    {
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

        // Update is called once per frame
        void Update()
        {
            Vector3 targetPosition = Vector3.zero;
            if (targetTransform != null)
            {
                targetPosition = targetTransform.position;
            }
            this.transform.LookAt(targetPosition);
        }
    }
}