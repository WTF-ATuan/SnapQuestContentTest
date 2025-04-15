using UnityEngine;
using UnityEngine.Events;

namespace SnapQuestScripts.DesignTestScripts
{
    public class FinalTest: MonoBehaviour
    {
        public MeshRenderer render1,render2,render3;
        public UnityEvent onFinished;
        
        private bool pass1, pass2, pass3;

        public void Pass(int passIndex)
        {
            switch (passIndex)
            {
                case 1:
                    render1.material.color = Color.green;
                    pass1 = true;
                    break;
                case 2:
                    render2.material.color = Color.green;
                    pass2 = true;
                    break;
                case 3:
                    render3.material.color = Color.green;
                    pass3 = true;
                    break;
            }
            
            if (pass1 && pass2 && pass3)
            {
                onFinished?.Invoke();
            }
        }
    }
}