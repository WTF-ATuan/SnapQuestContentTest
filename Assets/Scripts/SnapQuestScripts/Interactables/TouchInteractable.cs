namespace Code.Interactables
{
    public class TouchInteractable : BaseInteractable
    {
        private AstarPath astar;

        protected void Start()
        {
            base.Start();
            astar = FindObjectOfType<AstarPath>();
        }
        public void RescanPathFinding()
        {
            astar.Scan();
        }
    }
}