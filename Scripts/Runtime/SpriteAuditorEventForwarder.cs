using UnityEngine;

namespace BrunoMikoski.SpriteAuditor
{
    public class SpriteAuditorEventForwarder : MonoBehaviour
    {
        private IProjectUpdateLoopListener listener;

        private void Update()
        {
            listener?.OnProjectUpdate();
        }

        public void SetListener(IProjectUpdateLoopListener listener)
        {
            this.listener = listener;
        }
    }
}
