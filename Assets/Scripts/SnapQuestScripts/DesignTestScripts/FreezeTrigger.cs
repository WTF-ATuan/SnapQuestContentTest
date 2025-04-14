using System;
using Pathfinding;
using UnityEngine;

namespace SnapQuestScripts.DesignTestScripts
{
    [RequireComponent(typeof(NotableObject))]
    public class FreezeTrigger : MonoBehaviour
    {
        private NotableObject _notableObject;
        [SerializeField] private SkinnedMeshRenderer meshRenderer;
        private AIPath _aiPath;
        public bool isFreezing;


        private void Start()
        {
            _notableObject = GetComponent<NotableObject>();
            _aiPath = GetComponent<AIPath>();
            _notableObject.OnCaptured += OnCaptured;
        }

        private void OnCaptured()
        {
            _aiPath.canMove = false;
            foreach (var material in meshRenderer.materials)
            {
                material.color = Color.red;
            }
            isFreezing = true;
            Invoke(nameof(StopFreeze),1.5f);
        }

        private void StopFreeze()
        {
            _aiPath.canMove = true;
            isFreezing = false;
            foreach (var material in meshRenderer.materials)
            {
                material.color = Color.white;
            }
        }

        public void Freeze()
        {
            _aiPath.canMove = false;
            foreach (var material in meshRenderer.materials)
            {
                material.color = Color.red;
            }
            isFreezing = true;
        }
    }
}