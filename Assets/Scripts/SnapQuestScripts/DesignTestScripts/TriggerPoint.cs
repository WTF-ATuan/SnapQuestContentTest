using System;
using UnityEngine;
using UnityEngine.Events;

namespace SnapQuestScripts.DesignTestScripts
{
    public class TriggerPoint : MonoBehaviour
    {
        public UnityEvent onPointEnter;
        public MeshRenderer meshObj;


        private void OnTriggerEnter(Collider other)
        {
            var freezeTrigger = other.gameObject.GetComponent<FreezeTrigger>();
            if (freezeTrigger != null)
            {   
                meshObj.material.color = Color.green;
            }
        }
        
        private void OnTriggerExit(Collider other)
        {
            var freezeTrigger = other.gameObject.GetComponent<FreezeTrigger>();
            if (freezeTrigger != null)
            {   
                meshObj.material.color = Color.red;
            }
        }

        private void OnTriggerStay(Collider other)
        {
            var freezeTrigger = other.gameObject.GetComponent<FreezeTrigger>();
            if (freezeTrigger != null && freezeTrigger.isFreezing)
            {
                onPointEnter?.Invoke();
            }
        }
    }
}