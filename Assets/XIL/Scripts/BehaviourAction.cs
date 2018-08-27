using UnityEngine;

namespace wxb
{
    // 通用的组件事件
    public class BehaviourAction : MonoBehaviour
    {
        public System.Action<BehaviourAction, int> OnAnimatorIKAction;
        private void OnAnimatorIK(int layerIndex)
        {
            if (OnAnimatorIKAction != null)
                OnAnimatorIKAction(this, layerIndex);
        }

        public System.Action<BehaviourAction> OnAnimatorMoveAction;
        private void OnAnimatorMove()
        {
            if (OnAnimatorMoveAction != null)
                OnAnimatorMoveAction(this);
        }

        public System.Action<BehaviourAction, bool> OnApplicationFocusAction;
        private void OnApplicationFocus(bool focus)
        {
            if (OnApplicationFocusAction != null)
                OnApplicationFocusAction(this, focus);
        }

        public System.Action<BehaviourAction, bool> OnApplicationPauseAction;
        private void OnApplicationPause(bool pause)
        {
            if (OnApplicationPauseAction != null)
                OnApplicationPauseAction(this, pause);
        }

        public System.Action<BehaviourAction> OnApplicationQuitAction;
        private void OnApplicationQuit()
        {
            if (OnApplicationQuitAction != null)
                OnApplicationQuitAction(this);
        }

        public System.Action<BehaviourAction, float[], int> OnAudioFilterReadAction;
        private void OnAudioFilterRead(float[] data, int channels)
        {
            if (OnAudioFilterReadAction != null)
                OnAudioFilterReadAction(this, data, channels);
        }

        public System.Action<BehaviourAction> OnBecameInvisibleAction;
        private void OnBecameInvisible()
        {
            if (OnBecameInvisibleAction != null)
                OnBecameInvisibleAction(this);
        }

        public System.Action<BehaviourAction> OnBecameVisibleAction;
        private void OnBecameVisible()
        {
            if (OnBecameVisibleAction != null)
                OnBecameVisibleAction(this);
        }

        public System.Action<BehaviourAction> OnBeforeTransformParentChangedAction;
        private void OnBeforeTransformParentChanged()
        {
            if (OnBeforeTransformParentChangedAction != null)
                OnBeforeTransformParentChangedAction(this);
        }

        public System.Action<BehaviourAction> OnCanvasGroupChangedAction;
        private void OnCanvasGroupChanged()
        {
            if (OnCanvasGroupChangedAction != null)
                OnCanvasGroupChangedAction(this);
        }

        public System.Action<BehaviourAction, Collision> OnCollisionEnterAction;
        private void OnCollisionEnter(Collision collision)
        {
            if (OnCollisionEnterAction != null)
                OnCollisionEnterAction(this, collision);
        }

        public System.Action<BehaviourAction, Collision2D> OnCollisionEnter2DAction;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (OnCollisionEnter2DAction != null)
                OnCollisionEnter2DAction(this, collision);
        }

        public System.Action<BehaviourAction, Collision> OnCollisionExitAction;
        private void OnCollisionExit(Collision collision)
        {
            if (OnCollisionExitAction != null)
                OnCollisionExitAction(this, collision);
        }

        public System.Action<BehaviourAction, Collision2D> OnCollisionExit2DAction;
        private void OnCollisionExit2D(Collision2D collision)
        {
            if (OnCollisionExit2DAction != null)
                OnCollisionExit2DAction(this, collision);
        }

        public System.Action<BehaviourAction, Collision> OnCollisionStayAction;
        private void OnCollisionStay(Collision collision)
        {
            if (OnCollisionStayAction != null)
                OnCollisionStayAction(this, collision);
        }

        public System.Action<BehaviourAction, Collision2D> OnCollisionStay2DAction;
        private void OnCollisionStay2D(Collision2D collision)
        {
            if (OnCollisionStay2DAction != null)
                OnCollisionStay2DAction(this, collision);
        }

        public System.Action<BehaviourAction> OnConnectedToServerAction;
        private void OnConnectedToServer()
        {
            if (OnConnectedToServerAction != null)
                OnConnectedToServerAction(this);
        }

        public System.Action<BehaviourAction, ControllerColliderHit> OnControllerColliderHitAction;
        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            if (OnControllerColliderHitAction != null)
                OnControllerColliderHitAction(this, hit);
        }

        public System.Action<BehaviourAction> OnDestroyAction;
        private void OnDestroy()
        {
            if (OnDestroyAction != null)
                OnDestroyAction(this);
        }

        public System.Action<BehaviourAction> OnDisableAction;
        private void OnDisable()
        {
            if (OnDisableAction != null)
                OnDisableAction(this);
        }

        public System.Action<BehaviourAction> OnEnableAction;
        private void OnEnable()
        {
            if (OnEnableAction != null)
                OnEnableAction(this);
        }


        public System.Action<BehaviourAction, float> OnJointBreakAction;
        private void OnJointBreak(float breakForce)
        {
            if (OnJointBreakAction != null)
                OnJointBreakAction(this, breakForce);
        }

        public System.Action<BehaviourAction, Joint2D> OnJointBreak2DAction;
        private void OnJointBreak2D(Joint2D joint)
        {
            if (OnJointBreak2DAction != null)
                OnJointBreak2DAction(this, joint);
        }

        public System.Action<BehaviourAction> OnMouseDownAction;
        private void OnMouseDown()
        {
            if (OnMouseDownAction != null)
                OnMouseDownAction(this);
        }

        public System.Action<BehaviourAction> OnMouseDragAction;
        private void OnMouseDrag()
        {
            if (OnMouseDragAction != null)
                OnMouseDragAction(this);
        }

        public System.Action<BehaviourAction> OnMouseEnterAction;
        private void OnMouseEnter()
        {
            if (OnMouseEnterAction != null)
                OnMouseEnterAction(this);
        }

        public System.Action<BehaviourAction> OnMouseExitAction;
        private void OnMouseExit()
        {
            if (OnMouseExitAction != null)
                OnMouseExitAction(this);
        }

        public System.Action<BehaviourAction> OnMouseOverAction;
        private void OnMouseOver()
        {
            if (OnMouseOverAction != null)
                OnMouseOverAction(this);
        }

        public System.Action<BehaviourAction> OnMouseUpAction;
        private void OnMouseUp()
        {
            if (OnMouseUpAction != null)
                OnMouseUpAction(this);
        }

        public System.Action<BehaviourAction> OnMouseUpAsButtonAction;
        private void OnMouseUpAsButton()
        {
            if (OnMouseUpAsButtonAction != null)
                OnMouseUpAsButtonAction(this);
        }

        public System.Action<BehaviourAction, GameObject> OnParticleCollisionAction;
        private void OnParticleCollision(GameObject other)
        {
            if (OnParticleCollisionAction != null)
                OnParticleCollisionAction(this, other);
        }

        public System.Action<BehaviourAction> OnParticleTriggerAction;
        private void OnParticleTrigger()
        {
            if (OnParticleTriggerAction != null)
                OnParticleTriggerAction(this);
        }

        public System.Action<BehaviourAction> OnPostRenderAction;
        private void OnPostRender()
        {
            if (OnPostRenderAction != null)
                OnPostRenderAction(this);
        }

        public System.Action<BehaviourAction> OnPreCullAction;
        private void OnPreCull()
        {
            if (OnPreCullAction != null)
                OnPreCullAction(this);
        }

        public System.Action<BehaviourAction> OnPreRenderAction;
        private void OnPreRender()
        {
            if (OnPreRenderAction != null)
                OnPreRenderAction(this);
        }

        public System.Action<BehaviourAction> OnRectTransformDimensionsChangeAction;
        private void OnRectTransformDimensionsChange()
        {
            if (OnRectTransformDimensionsChangeAction != null)
                OnRectTransformDimensionsChangeAction(this);
        }

        public System.Action<BehaviourAction> OnRectTransformRemovedAction;
        private void OnRectTransformRemoved()
        {
            if (OnRectTransformRemovedAction != null)
                OnRectTransformRemovedAction(this);
        }

        public System.Action<BehaviourAction, RenderTexture, RenderTexture> OnRenderImageAction;
        private void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            if (OnRenderImageAction != null)
                OnRenderImageAction(this, source, destination);
        }

        public System.Action<BehaviourAction> OnRenderObjectAction;
        private void OnRenderObject()
        {
            if (OnRenderObjectAction != null)
                OnRenderObjectAction(this);
        }

        public System.Action<BehaviourAction> OnTransformChildrenChangedAction;
        private void OnTransformChildrenChanged()
        {
            if (OnTransformChildrenChangedAction != null)
                OnTransformChildrenChangedAction(this);
        }

        public System.Action<BehaviourAction> OnTransformParentChangedAction;
        private void OnTransformParentChanged()
        {
            if (OnTransformParentChangedAction != null)
                OnTransformParentChangedAction(this);
        }

        public System.Action<BehaviourAction, Collider> OnTriggerEnterAction;
        private void OnTriggerEnter(Collider other)
        {
            if (OnTriggerEnterAction != null)
                OnTriggerEnterAction(this, other);
        }

        public System.Action<BehaviourAction, Collider2D> OnTriggerEnter2DAction;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (OnTriggerEnter2DAction != null)
                OnTriggerEnter2DAction(this, collision);
        }

        public System.Action<BehaviourAction, Collider> OnTriggerExitAction;
        private void OnTriggerExit(Collider other)
        {
            if (OnTriggerExitAction != null)
                OnTriggerExitAction(this, other);
        }

        public System.Action<BehaviourAction, Collider2D> OnTriggerExit2DAction;
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (OnTriggerExit2DAction != null)
                OnTriggerExit2DAction(this, collision);
        }

        public System.Action<BehaviourAction, Collider> OnTriggerStayAction;
        private void OnTriggerStay(Collider other)
        {
            if (OnTriggerStayAction != null)
                OnTriggerStayAction(this, other);
        }
        public System.Action<BehaviourAction, Collider2D> OnTriggerStay2DAction;
        private void OnTriggerStay2D(Collider2D collision)
        {
            if (OnTriggerStay2DAction != null)
                OnTriggerStay2DAction(this, collision);
        }

        public System.Action<BehaviourAction> OnValidateAction;
        private void OnValidate()
        {
            if (OnValidateAction != null)
                OnValidateAction(this);
        }

        public System.Action<BehaviourAction> OnWillRenderObjectAction;
        private void OnWillRenderObject()
        {
            if (OnWillRenderObjectAction != null)
                OnWillRenderObjectAction(this);
        }

        public System.Action<BehaviourAction> StartAction;
        private void Start()
        {
            if (StartAction != null)
                StartAction(this);
        }

        public System.Action<BehaviourAction> AwakeAction;
        private void Awake()
        {
            if (AwakeAction != null)
                AwakeAction(this);
        }

        public System.Action<BehaviourAction> FixedUpdateAction;
        private void FixedUpdate()
        {
            if (FixedUpdateAction != null)
                FixedUpdateAction(this);
        }
        public System.Action<BehaviourAction> LateUpdateAction;
        private void LateUpdate()
        {
            if (LateUpdateAction != null)
                LateUpdateAction(this);
        }

        public System.Action<BehaviourAction> UpdateAction;
        private void Update()
        {
            if (UpdateAction != null)
                UpdateAction(this);
        }
    }
}