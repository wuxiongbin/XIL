#if !USE_HOT
using UnityEngine;

namespace hot
{
    public class HotBehaviour<T> where T : MonoBehaviour
    {
        public T csObj { get; protected set; }

        private GameObject _gameObject;
        public GameObject gameObject
        {
            get
            {
                if (_gameObject == null)
                    _gameObject = csObj != null ? csObj.gameObject : null;

                return _gameObject;
            }
        }

        private Transform _transform;
        public Transform transform
        {
            get
            {
                if (_transform == null)
                    _transform = csObj != null ? csObj.transform : null;

                return _transform;
            }
        }
    }

    public class HotBehaviour : HotBehaviour<wxb.ILMonoBehaviour>
    {

    }
}
#endif