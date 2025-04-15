using UnityEngine;
using UnityEngine.Events;

namespace SnapQuestScripts.DesignTestScripts
{
    public class FinalTest: MonoBehaviour
    {
        public MeshRenderer render1,render2,render3;
        public UnityEvent onFinished;
        
        private int _passTimes = 0;

        public void Pass(int passIndex)
        {
            if(_passTimes >= passIndex ) return;
            _passTimes++;
            switch (passIndex)
            {
                case 1:
                    render1.material.color = Color.green;
                    break;
                case 2:
                    render2.material.color = Color.green;
                    break;
                case 3:
                    render3.material.color = Color.green;
                    break;
            }

            if (_passTimes > 3)
            {
                onFinished?.Invoke();
                
            }
        }
    }
}