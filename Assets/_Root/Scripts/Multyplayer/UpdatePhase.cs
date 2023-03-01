
namespace Network
{
    public interface UpdatePhase
    {
        public void Update() { }
        public void FixedUpdate() { }
        public void LateUpdate() { }
        public void PostRender() { }
        public void PreRender() { }
    }
}