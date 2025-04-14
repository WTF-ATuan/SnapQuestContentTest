using System;
using UnityEngine;
using UnityEngine.Events;

namespace SnapQuestScripts.DesignTestScripts
{
    public class TriggerPoint : MonoBehaviour
    {
        public UnityEvent onPointEnter;

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