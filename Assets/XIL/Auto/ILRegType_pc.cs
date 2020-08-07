#if USE_HOT && UNITY_STANDALONE_WIN
namespace AutoIL
{
    using ILRuntime.Runtime.Enviorment;

    static class ILRegType
    {
        static public void RegisterFunctionDelegate(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Object, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Reflection.MemberInfo, System.Object, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, System.ResolveEventArgs, System.Reflection.Module>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Component, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Component, UnityEngine.Component, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, System.Object, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32, System.Int32, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Single, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Single, System.Single, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector4, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector4, UnityEngine.Vector4, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Matrix4x4, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Matrix4x4, UnityEngine.Matrix4x4, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector3, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector3, UnityEngine.Vector3, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color, UnityEngine.Color, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color32, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color32, UnityEngine.Color32, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector2, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector2, UnityEngine.Vector2, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.BoneWeight, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.BoneWeight, UnityEngine.BoneWeight, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.ReflectionProbeBlendInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.ReflectionProbeBlendInfo, UnityEngine.Rendering.ReflectionProbeBlendInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject, UnityEngine.GameObject, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.RaycastResult, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.RaycastResult, UnityEngine.EventSystems.RaycastResult, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.EventTrigger.Entry, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.EventTrigger.Entry, UnityEngine.EventSystems.EventTrigger.Entry, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UIVertex, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UIVertex, UnityEngine.UIVertex, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rect, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rect, UnityEngine.Rect, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.AnimatorClipInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.AnimatorClipInfo, UnityEngine.AnimatorClipInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Selectable, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Selectable, UnityEngine.UI.Selectable, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UICharInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UICharInfo, UnityEngine.UICharInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UILineInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UILineInfo, UnityEngine.UILineInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Dropdown.OptionData, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Dropdown.OptionData, UnityEngine.UI.Dropdown.OptionData, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.String, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Sprite, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Sprite, UnityEngine.Sprite, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.Int32, System.Char, System.Char>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.RectMask2D, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.RectMask2D, UnityEngine.UI.RectMask2D, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.ILayoutElement, System.Single>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Reflection.FieldInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Reflection.FieldInfo, System.Reflection.FieldInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Type, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Object, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Object, UnityEngine.Object, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.UInt16, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.UInt16, System.UInt16, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.ParticleSystemVertexStream, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.ParticleSystemVertexStream, UnityEngine.ParticleSystemVertexStream, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.ParticleCollisionEvent, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.ParticleCollisionEvent, UnityEngine.ParticleCollisionEvent, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.ParticleSystem.Particle, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.ParticleSystem.Particle, UnityEngine.ParticleSystem.Particle, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.AI.NavMeshBuildMarkup, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.AI.NavMeshBuildMarkup, UnityEngine.AI.NavMeshBuildMarkup, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.AI.NavMeshBuildSource, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.AI.NavMeshBuildSource, UnityEngine.AI.NavMeshBuildSource, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>, System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Networking.IMultipartFormSection, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Networking.IMultipartFormSection, UnityEngine.Networking.IMultipartFormSection, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot, UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Networking.ChannelQOS, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Networking.ChannelQOS, UnityEngine.Networking.ChannelQOS, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Networking.ConnectionConfig, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Networking.ConnectionConfig, UnityEngine.Networking.ConnectionConfig, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Byte, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Byte, System.Byte, System.Int32>();

        }

        static public void RegisterDelegateConvertor(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterDelegateConvertor<System.Reflection.TypeFilter>((act) =>
            {
                return new System.Reflection.TypeFilter((m, filterCriteria) =>
                {
                    return ((System.Func<System.Type, System.Object, System.Boolean>)act)(m, filterCriteria);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Reflection.MemberFilter>((act) =>
            {
                return new System.Reflection.MemberFilter((m, filterCriteria) =>
                {
                    return ((System.Func<System.Reflection.MemberInfo, System.Object, System.Boolean>)act)(m, filterCriteria);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Reflection.ModuleResolveEventHandler>((act) =>
            {
                return new System.Reflection.ModuleResolveEventHandler((sender, e) =>
                {
                    return ((System.Func<System.Object, System.ResolveEventArgs, System.Reflection.Module>)act)(sender, e);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.AsyncCallback>((act) =>
            {
                return new System.AsyncCallback((ar) =>
                {
                    ((System.Action<System.IAsyncResult>)act)(ar);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Component>>((act) =>
            {
                return new System.Predicate<UnityEngine.Component>((obj) =>
                {
                    return ((System.Func<UnityEngine.Component, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Component>>((act) =>
            {
                return new System.Comparison<UnityEngine.Component>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Component, UnityEngine.Component, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Object>>((act) =>
            {
                return new System.Predicate<System.Object>((obj) =>
                {
                    return ((System.Func<System.Object, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Object>>((act) =>
            {
                return new System.Comparison<System.Object>((x, y) =>
                {
                    return ((System.Func<System.Object, System.Object, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Int32>>((act) =>
            {
                return new System.Predicate<System.Int32>((obj) =>
                {
                    return ((System.Func<System.Int32, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Int32>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Int32>((arg0) =>
                {
                    ((System.Action<System.Int32>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.AudioClip.PCMSetPositionCallback>((act) =>
            {
                return new UnityEngine.AudioClip.PCMSetPositionCallback((position) =>
                {
                    ((System.Action<System.Int32>)act)(position);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.GUI.WindowFunction>((act) =>
            {
                return new UnityEngine.GUI.WindowFunction((id) =>
                {
                    ((System.Action<System.Int32>)act)(id);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Int32>>((act) =>
            {
                return new System.Comparison<System.Int32>((x, y) =>
                {
                    return ((System.Func<System.Int32, System.Int32, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Single>>((act) =>
            {
                return new System.Predicate<System.Single>((obj) =>
                {
                    return ((System.Func<System.Single, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Single>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Single>((arg0) =>
                {
                    ((System.Action<System.Single>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Single>>((act) =>
            {
                return new System.Comparison<System.Single>((x, y) =>
                {
                    return ((System.Func<System.Single, System.Single, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Vector4>>((act) =>
            {
                return new System.Predicate<UnityEngine.Vector4>((obj) =>
                {
                    return ((System.Func<UnityEngine.Vector4, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Vector4>>((act) =>
            {
                return new System.Comparison<UnityEngine.Vector4>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Vector4, UnityEngine.Vector4, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Matrix4x4>>((act) =>
            {
                return new System.Predicate<UnityEngine.Matrix4x4>((obj) =>
                {
                    return ((System.Func<UnityEngine.Matrix4x4, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Matrix4x4>>((act) =>
            {
                return new System.Comparison<UnityEngine.Matrix4x4>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Matrix4x4, UnityEngine.Matrix4x4, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Vector3>>((act) =>
            {
                return new System.Predicate<UnityEngine.Vector3>((obj) =>
                {
                    return ((System.Func<UnityEngine.Vector3, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Vector3>>((act) =>
            {
                return new System.Comparison<UnityEngine.Vector3>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Vector3, UnityEngine.Vector3, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Color>>((act) =>
            {
                return new System.Predicate<UnityEngine.Color>((obj) =>
                {
                    return ((System.Func<UnityEngine.Color, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Color>>((act) =>
            {
                return new System.Comparison<UnityEngine.Color>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Color, UnityEngine.Color, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Color32>>((act) =>
            {
                return new System.Predicate<UnityEngine.Color32>((obj) =>
                {
                    return ((System.Func<UnityEngine.Color32, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Color32>>((act) =>
            {
                return new System.Comparison<UnityEngine.Color32>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Color32, UnityEngine.Color32, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Vector2>>((act) =>
            {
                return new System.Predicate<UnityEngine.Vector2>((obj) =>
                {
                    return ((System.Func<UnityEngine.Vector2, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.Vector2>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.Vector2>((arg0) =>
                {
                    ((System.Action<UnityEngine.Vector2>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Vector2>>((act) =>
            {
                return new System.Comparison<UnityEngine.Vector2>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Vector2, UnityEngine.Vector2, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.BoneWeight>>((act) =>
            {
                return new System.Predicate<UnityEngine.BoneWeight>((obj) =>
                {
                    return ((System.Func<UnityEngine.BoneWeight, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.BoneWeight>>((act) =>
            {
                return new System.Comparison<UnityEngine.BoneWeight>((x, y) =>
                {
                    return ((System.Func<UnityEngine.BoneWeight, UnityEngine.BoneWeight, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Rendering.ReflectionProbeBlendInfo>>((act) =>
            {
                return new System.Predicate<UnityEngine.Rendering.ReflectionProbeBlendInfo>((obj) =>
                {
                    return ((System.Func<UnityEngine.Rendering.ReflectionProbeBlendInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Rendering.ReflectionProbeBlendInfo>>((act) =>
            {
                return new System.Comparison<UnityEngine.Rendering.ReflectionProbeBlendInfo>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Rendering.ReflectionProbeBlendInfo, UnityEngine.Rendering.ReflectionProbeBlendInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Camera.CameraCallback>((act) =>
            {
                return new UnityEngine.Camera.CameraCallback((cam) =>
                {
                    ((System.Action<UnityEngine.Camera>)act)(cam);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.GameObject>>((act) =>
            {
                return new System.Predicate<UnityEngine.GameObject>((obj) =>
                {
                    return ((System.Func<UnityEngine.GameObject, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.GameObject>>((act) =>
            {
                return new System.Comparison<UnityEngine.GameObject>((x, y) =>
                {
                    return ((System.Func<UnityEngine.GameObject, UnityEngine.GameObject, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.EventSystems.RaycastResult>>((act) =>
            {
                return new System.Predicate<UnityEngine.EventSystems.RaycastResult>((obj) =>
                {
                    return ((System.Func<UnityEngine.EventSystems.RaycastResult, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.EventSystems.RaycastResult>>((act) =>
            {
                return new System.Comparison<UnityEngine.EventSystems.RaycastResult>((x, y) =>
                {
                    return ((System.Func<UnityEngine.EventSystems.RaycastResult, UnityEngine.EventSystems.RaycastResult, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.EventSystems.EventTrigger.Entry>>((act) =>
            {
                return new System.Predicate<UnityEngine.EventSystems.EventTrigger.Entry>((obj) =>
                {
                    return ((System.Func<UnityEngine.EventSystems.EventTrigger.Entry, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.EventSystems.EventTrigger.Entry>>((act) =>
            {
                return new System.Comparison<UnityEngine.EventSystems.EventTrigger.Entry>((x, y) =>
                {
                    return ((System.Func<UnityEngine.EventSystems.EventTrigger.Entry, UnityEngine.EventSystems.EventTrigger.Entry, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>((arg0) =>
                {
                    ((System.Action<UnityEngine.EventSystems.BaseEventData>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.RectTransform.ReapplyDrivenProperties>((act) =>
            {
                return new UnityEngine.RectTransform.ReapplyDrivenProperties((driven) =>
                {
                    ((System.Action<UnityEngine.RectTransform>)act)(driven);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UIVertex>>((act) =>
            {
                return new System.Predicate<UnityEngine.UIVertex>((obj) =>
                {
                    return ((System.Func<UnityEngine.UIVertex, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UIVertex>>((act) =>
            {
                return new System.Comparison<UnityEngine.UIVertex>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UIVertex, UnityEngine.UIVertex, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Rect>>((act) =>
            {
                return new System.Predicate<UnityEngine.Rect>((obj) =>
                {
                    return ((System.Func<UnityEngine.Rect, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Rect>>((act) =>
            {
                return new System.Comparison<UnityEngine.Rect>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Rect, UnityEngine.Rect, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Boolean>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Boolean>((arg0) =>
                {
                    ((System.Action<System.Boolean>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.AudioSettings.AudioConfigurationChangeHandler>((act) =>
            {
                return new UnityEngine.AudioSettings.AudioConfigurationChangeHandler((deviceWasChanged) =>
                {
                    ((System.Action<System.Boolean>)act)(deviceWasChanged);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.AnimatorClipInfo>>((act) =>
            {
                return new System.Predicate<UnityEngine.AnimatorClipInfo>((obj) =>
                {
                    return ((System.Func<UnityEngine.AnimatorClipInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.AnimatorClipInfo>>((act) =>
            {
                return new System.Comparison<UnityEngine.AnimatorClipInfo>((x, y) =>
                {
                    return ((System.Func<UnityEngine.AnimatorClipInfo, UnityEngine.AnimatorClipInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UI.Selectable>>((act) =>
            {
                return new System.Predicate<UnityEngine.UI.Selectable>((obj) =>
                {
                    return ((System.Func<UnityEngine.UI.Selectable, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UI.Selectable>>((act) =>
            {
                return new System.Comparison<UnityEngine.UI.Selectable>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UI.Selectable, UnityEngine.UI.Selectable, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UICharInfo>>((act) =>
            {
                return new System.Predicate<UnityEngine.UICharInfo>((obj) =>
                {
                    return ((System.Func<UnityEngine.UICharInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UICharInfo>>((act) =>
            {
                return new System.Comparison<UnityEngine.UICharInfo>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UICharInfo, UnityEngine.UICharInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UILineInfo>>((act) =>
            {
                return new System.Predicate<UnityEngine.UILineInfo>((obj) =>
                {
                    return ((System.Func<UnityEngine.UILineInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UILineInfo>>((act) =>
            {
                return new System.Comparison<UnityEngine.UILineInfo>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UILineInfo, UnityEngine.UILineInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UI.Dropdown.OptionData>>((act) =>
            {
                return new System.Predicate<UnityEngine.UI.Dropdown.OptionData>((obj) =>
                {
                    return ((System.Func<UnityEngine.UI.Dropdown.OptionData, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UI.Dropdown.OptionData>>((act) =>
            {
                return new System.Comparison<UnityEngine.UI.Dropdown.OptionData>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UI.Dropdown.OptionData, UnityEngine.UI.Dropdown.OptionData, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.String>>((act) =>
            {
                return new System.Predicate<System.String>((obj) =>
                {
                    return ((System.Func<System.String, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.String>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.String>((arg0) =>
                {
                    ((System.Action<System.String>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Windows.Speech.DictationRecognizer.DictationHypothesisDelegate>((act) =>
            {
                return new UnityEngine.Windows.Speech.DictationRecognizer.DictationHypothesisDelegate((text) =>
                {
                    ((System.Action<System.String>)act)(text);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.String>>((act) =>
            {
                return new System.Comparison<System.String>((x, y) =>
                {
                    return ((System.Func<System.String, System.String, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Sprite>>((act) =>
            {
                return new System.Predicate<UnityEngine.Sprite>((obj) =>
                {
                    return ((System.Func<UnityEngine.Sprite, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Sprite>>((act) =>
            {
                return new System.Comparison<UnityEngine.Sprite>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Sprite, UnityEngine.Sprite, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.UI.InputField.OnValidateInput>((act) =>
            {
                return new UnityEngine.UI.InputField.OnValidateInput((text, charIndex, addedChar) =>
                {
                    return ((System.Func<System.String, System.Int32, System.Char, System.Char>)act)(text, charIndex, addedChar);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UI.RectMask2D>>((act) =>
            {
                return new System.Predicate<UnityEngine.UI.RectMask2D>((obj) =>
                {
                    return ((System.Func<UnityEngine.UI.RectMask2D, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UI.RectMask2D>>((act) =>
            {
                return new System.Comparison<UnityEngine.UI.RectMask2D>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UI.RectMask2D, UnityEngine.UI.RectMask2D, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Reflection.FieldInfo>>((act) =>
            {
                return new System.Predicate<System.Reflection.FieldInfo>((obj) =>
                {
                    return ((System.Func<System.Reflection.FieldInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Reflection.FieldInfo>>((act) =>
            {
                return new System.Comparison<System.Reflection.FieldInfo>((x, y) =>
                {
                    return ((System.Func<System.Reflection.FieldInfo, System.Reflection.FieldInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Type>>((act) =>
            {
                return new System.Predicate<System.Type>((obj) =>
                {
                    return ((System.Func<System.Type, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Type>>((act) =>
            {
                return new System.Comparison<System.Type>((x, y) =>
                {
                    return ((System.Func<System.Type, System.Type, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Object>>((act) =>
            {
                return new System.Predicate<UnityEngine.Object>((obj) =>
                {
                    return ((System.Func<UnityEngine.Object, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Object>>((act) =>
            {
                return new System.Comparison<UnityEngine.Object>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Object, UnityEngine.Object, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Application.AdvertisingIdentifierCallback>((act) =>
            {
                return new UnityEngine.Application.AdvertisingIdentifierCallback((advertisingId, trackingEnabled, errorMsg) =>
                {
                    ((System.Action<System.String, System.Boolean, System.String>)act)(advertisingId, trackingEnabled, errorMsg);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Application.LogCallback>((act) =>
            {
                return new UnityEngine.Application.LogCallback((condition, stackTrace, type) =>
                {
                    ((System.Action<System.String, System.String, UnityEngine.LogType>)act)(condition, stackTrace, type);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.UInt16>>((act) =>
            {
                return new System.Predicate<System.UInt16>((obj) =>
                {
                    return ((System.Func<System.UInt16, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.UInt16>>((act) =>
            {
                return new System.Comparison<System.UInt16>((x, y) =>
                {
                    return ((System.Func<System.UInt16, System.UInt16, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.CullingGroup.StateChanged>((act) =>
            {
                return new UnityEngine.CullingGroup.StateChanged((sphere) =>
                {
                    ((System.Action<UnityEngine.CullingGroupEvent>)act)(sphere);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Apple.ReplayKit.ReplayKit.BroadcastStatusCallback>((act) =>
            {
                return new UnityEngine.Apple.ReplayKit.ReplayKit.BroadcastStatusCallback((hasStarted, errorMessage) =>
                {
                    ((System.Action<System.Boolean, System.String>)act)(hasStarted, errorMessage);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate>((act) =>
            {
                return new UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate((success, extendedInfo) =>
                {
                    ((System.Action<System.Boolean, System.String>)act)(success, extendedInfo);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>((arg0, arg1) =>
                {
                    ((System.Action<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>)act)(arg0, arg1);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>((arg0) =>
                {
                    ((System.Action<UnityEngine.SceneManagement.Scene>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>((arg0, arg1) =>
                {
                    ((System.Action<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>)act)(arg0, arg1);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Windows.Speech.PhraseRecognitionSystem.ErrorDelegate>((act) =>
            {
                return new UnityEngine.Windows.Speech.PhraseRecognitionSystem.ErrorDelegate((errorCode) =>
                {
                    ((System.Action<UnityEngine.Windows.Speech.SpeechError>)act)(errorCode);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Windows.Speech.PhraseRecognitionSystem.StatusDelegate>((act) =>
            {
                return new UnityEngine.Windows.Speech.PhraseRecognitionSystem.StatusDelegate((status) =>
                {
                    ((System.Action<UnityEngine.Windows.Speech.SpeechSystemStatus>)act)(status);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Windows.Speech.PhraseRecognizer.PhraseRecognizedDelegate>((act) =>
            {
                return new UnityEngine.Windows.Speech.PhraseRecognizer.PhraseRecognizedDelegate((args) =>
                {
                    ((System.Action<UnityEngine.Windows.Speech.PhraseRecognizedEventArgs>)act)(args);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Windows.Speech.DictationRecognizer.DictationResultDelegate>((act) =>
            {
                return new UnityEngine.Windows.Speech.DictationRecognizer.DictationResultDelegate((text, confidence) =>
                {
                    ((System.Action<System.String, UnityEngine.Windows.Speech.ConfidenceLevel>)act)(text, confidence);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Windows.Speech.DictationRecognizer.DictationCompletedDelegate>((act) =>
            {
                return new UnityEngine.Windows.Speech.DictationRecognizer.DictationCompletedDelegate((cause) =>
                {
                    ((System.Action<UnityEngine.Windows.Speech.DictationCompletionCause>)act)(cause);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Windows.Speech.DictationRecognizer.DictationErrorHandler>((act) =>
            {
                return new UnityEngine.Windows.Speech.DictationRecognizer.DictationErrorHandler((error, hresult) =>
                {
                    ((System.Action<System.String, System.Int32>)act)(error, hresult);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.GestureErrorDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.GestureErrorDelegate((error, hresult) =>
                {
                    ((System.Action<System.String, System.Int32>)act)(error, hresult);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.WSA.WindowSizeChanged>((act) =>
            {
                return new UnityEngine.WSA.WindowSizeChanged((width, height) =>
                {
                    ((System.Action<System.Int32, System.Int32>)act)(width, height);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.WSA.WindowActivated>((act) =>
            {
                return new UnityEngine.WSA.WindowActivated((state) =>
                {
                    ((System.Action<UnityEngine.WSA.WindowActivationState>)act)(state);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.ParticleSystemVertexStream>>((act) =>
            {
                return new System.Predicate<UnityEngine.ParticleSystemVertexStream>((obj) =>
                {
                    return ((System.Func<UnityEngine.ParticleSystemVertexStream, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.ParticleSystemVertexStream>>((act) =>
            {
                return new System.Comparison<UnityEngine.ParticleSystemVertexStream>((x, y) =>
                {
                    return ((System.Func<UnityEngine.ParticleSystemVertexStream, UnityEngine.ParticleSystemVertexStream, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.ParticleCollisionEvent>>((act) =>
            {
                return new System.Predicate<UnityEngine.ParticleCollisionEvent>((obj) =>
                {
                    return ((System.Func<UnityEngine.ParticleCollisionEvent, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.ParticleCollisionEvent>>((act) =>
            {
                return new System.Comparison<UnityEngine.ParticleCollisionEvent>((x, y) =>
                {
                    return ((System.Func<UnityEngine.ParticleCollisionEvent, UnityEngine.ParticleCollisionEvent, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.ParticleSystem.Particle>>((act) =>
            {
                return new System.Predicate<UnityEngine.ParticleSystem.Particle>((obj) =>
                {
                    return ((System.Func<UnityEngine.ParticleSystem.Particle, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.ParticleSystem.Particle>>((act) =>
            {
                return new System.Comparison<UnityEngine.ParticleSystem.Particle>((x, y) =>
                {
                    return ((System.Func<UnityEngine.ParticleSystem.Particle, UnityEngine.ParticleSystem.Particle, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.AI.NavMeshBuildMarkup>>((act) =>
            {
                return new System.Predicate<UnityEngine.AI.NavMeshBuildMarkup>((obj) =>
                {
                    return ((System.Func<UnityEngine.AI.NavMeshBuildMarkup, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.AI.NavMeshBuildMarkup>>((act) =>
            {
                return new System.Comparison<UnityEngine.AI.NavMeshBuildMarkup>((x, y) =>
                {
                    return ((System.Func<UnityEngine.AI.NavMeshBuildMarkup, UnityEngine.AI.NavMeshBuildMarkup, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.AI.NavMeshBuildSource>>((act) =>
            {
                return new System.Predicate<UnityEngine.AI.NavMeshBuildSource>((obj) =>
                {
                    return ((System.Func<UnityEngine.AI.NavMeshBuildSource, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.AI.NavMeshBuildSource>>((act) =>
            {
                return new System.Comparison<UnityEngine.AI.NavMeshBuildSource>((x, y) =>
                {
                    return ((System.Func<UnityEngine.AI.NavMeshBuildSource, UnityEngine.AI.NavMeshBuildSource, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.AudioClip.PCMReaderCallback>((act) =>
            {
                return new UnityEngine.AudioClip.PCMReaderCallback((data) =>
                {
                    ((System.Action<System.Single[]>)act)(data);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>>((act) =>
            {
                return new System.Predicate<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>((obj) =>
                {
                    return ((System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>>((act) =>
            {
                return new System.Comparison<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>((x, y) =>
                {
                    return ((System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>, System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Networking.IMultipartFormSection>>((act) =>
            {
                return new System.Predicate<UnityEngine.Networking.IMultipartFormSection>((obj) =>
                {
                    return ((System.Func<UnityEngine.Networking.IMultipartFormSection, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Networking.IMultipartFormSection>>((act) =>
            {
                return new System.Comparison<UnityEngine.Networking.IMultipartFormSection>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Networking.IMultipartFormSection, UnityEngine.Networking.IMultipartFormSection, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot>>((act) =>
            {
                return new System.Predicate<UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot>((obj) =>
                {
                    return ((System.Func<UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot>>((act) =>
            {
                return new System.Comparison<UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot, UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo>>((act) =>
            {
                return new UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo>((success, extendedInfo, responseData) =>
                {
                    ((System.Action<System.Boolean, System.String, UnityEngine.Networking.Match.MatchInfo>)act)(success, extendedInfo, responseData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<System.Collections.Generic.List<UnityEngine.Networking.Match.MatchInfoSnapshot>>>((act) =>
            {
                return new UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<System.Collections.Generic.List<UnityEngine.Networking.Match.MatchInfoSnapshot>>((success, extendedInfo, responseData) =>
                {
                    ((System.Action<System.Boolean, System.String, System.Collections.Generic.List<UnityEngine.Networking.Match.MatchInfoSnapshot>>)act)(success, extendedInfo, responseData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Networking.ChannelQOS>>((act) =>
            {
                return new System.Predicate<UnityEngine.Networking.ChannelQOS>((obj) =>
                {
                    return ((System.Func<UnityEngine.Networking.ChannelQOS, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Networking.ChannelQOS>>((act) =>
            {
                return new System.Comparison<UnityEngine.Networking.ChannelQOS>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Networking.ChannelQOS, UnityEngine.Networking.ChannelQOS, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Networking.ConnectionConfig>>((act) =>
            {
                return new System.Predicate<UnityEngine.Networking.ConnectionConfig>((obj) =>
                {
                    return ((System.Func<UnityEngine.Networking.ConnectionConfig, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Networking.ConnectionConfig>>((act) =>
            {
                return new System.Comparison<UnityEngine.Networking.ConnectionConfig>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Networking.ConnectionConfig, UnityEngine.Networking.ConnectionConfig, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.HoldCanceledEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.HoldCanceledEventDelegate((source, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Ray>)act)(source, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.HoldCompletedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.HoldCompletedEventDelegate((source, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Ray>)act)(source, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.HoldStartedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.HoldStartedEventDelegate((source, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Ray>)act)(source, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.RecognitionEndedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.RecognitionEndedEventDelegate((source, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Ray>)act)(source, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.RecognitionStartedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.RecognitionStartedEventDelegate((source, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Ray>)act)(source, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.TappedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.TappedEventDelegate((source, tapCount, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, System.Int32, UnityEngine.Ray>)act)(source, tapCount, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.ManipulationCanceledEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.ManipulationCanceledEventDelegate((source, cumulativeDelta, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Vector3, UnityEngine.Ray>)act)(source, cumulativeDelta, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.ManipulationCompletedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.ManipulationCompletedEventDelegate((source, cumulativeDelta, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Vector3, UnityEngine.Ray>)act)(source, cumulativeDelta, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.ManipulationStartedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.ManipulationStartedEventDelegate((source, cumulativeDelta, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Vector3, UnityEngine.Ray>)act)(source, cumulativeDelta, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.ManipulationUpdatedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.ManipulationUpdatedEventDelegate((source, cumulativeDelta, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Vector3, UnityEngine.Ray>)act)(source, cumulativeDelta, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.NavigationCanceledEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.NavigationCanceledEventDelegate((source, normalizedOffset, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Vector3, UnityEngine.Ray>)act)(source, normalizedOffset, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.NavigationCompletedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.NavigationCompletedEventDelegate((source, normalizedOffset, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Vector3, UnityEngine.Ray>)act)(source, normalizedOffset, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.NavigationStartedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.NavigationStartedEventDelegate((source, normalizedOffset, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Vector3, UnityEngine.Ray>)act)(source, normalizedOffset, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.GestureRecognizer.NavigationUpdatedEventDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.GestureRecognizer.NavigationUpdatedEventDelegate((source, normalizedOffset, headRay) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Vector3, UnityEngine.Ray>)act)(source, normalizedOffset, headRay);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.SurfaceObserver.SurfaceChangedDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.SurfaceObserver.SurfaceChangedDelegate((surfaceId, changeType, bounds, updateTime) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.SurfaceId, UnityEngine.VR.WSA.SurfaceChange, UnityEngine.Bounds, System.DateTime>)act)(surfaceId, changeType, bounds, updateTime);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.SurfaceObserver.SurfaceDataReadyDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.SurfaceObserver.SurfaceDataReadyDelegate((bakedData, outputWritten, elapsedBakeTimeSeconds) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.SurfaceData, System.Boolean, System.Single>)act)(bakedData, outputWritten, elapsedBakeTimeSeconds);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Persistence.WorldAnchorStore.GetAsyncDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Persistence.WorldAnchorStore.GetAsyncDelegate((store) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Persistence.WorldAnchorStore>)act)(store);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WorldAnchor.OnTrackingChangedDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.WorldAnchor.OnTrackingChangedDelegate((self, located) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WorldAnchor, System.Boolean>)act)(self, located);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Sharing.WorldAnchorTransferBatch.SerializationDataAvailableDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Sharing.WorldAnchorTransferBatch.SerializationDataAvailableDelegate((data) =>
                {
                    ((System.Action<System.Byte[]>)act)(data);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Sharing.WorldAnchorTransferBatch.SerializationCompleteDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Sharing.WorldAnchorTransferBatch.SerializationCompleteDelegate((completionReason) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Sharing.SerializationCompletionReason>)act)(completionReason);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Sharing.WorldAnchorTransferBatch.DeserializationCompleteDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.Sharing.WorldAnchorTransferBatch.DeserializationCompleteDelegate((completionReason, deserializedTransferBatch) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Sharing.SerializationCompletionReason, UnityEngine.VR.WSA.Sharing.WorldAnchorTransferBatch>)act)(completionReason, deserializedTransferBatch);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.VideoCapture.OnVideoCaptureResourceCreatedCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.VideoCapture.OnVideoCaptureResourceCreatedCallback((captureObject) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.VideoCapture>)act)(captureObject);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.VideoCapture.OnVideoModeStartedCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.VideoCapture.OnVideoModeStartedCallback((result) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.VideoCapture.VideoCaptureResult>)act)(result);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.VideoCapture.OnVideoModeStoppedCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.VideoCapture.OnVideoModeStoppedCallback((result) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.VideoCapture.VideoCaptureResult>)act)(result);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.VideoCapture.OnStartedRecordingVideoCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.VideoCapture.OnStartedRecordingVideoCallback((result) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.VideoCapture.VideoCaptureResult>)act)(result);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.VideoCapture.OnStoppedRecordingVideoCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.VideoCapture.OnStoppedRecordingVideoCallback((result) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.VideoCapture.VideoCaptureResult>)act)(result);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.PhotoCapture.OnCaptureResourceCreatedCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.PhotoCapture.OnCaptureResourceCreatedCallback((captureObject) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.PhotoCapture>)act)(captureObject);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.PhotoCapture.OnPhotoModeStartedCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.PhotoCapture.OnPhotoModeStartedCallback((result) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.PhotoCapture.PhotoCaptureResult>)act)(result);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.PhotoCapture.OnPhotoModeStoppedCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.PhotoCapture.OnPhotoModeStoppedCallback((result) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.PhotoCapture.PhotoCaptureResult>)act)(result);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.PhotoCapture.OnCapturedToDiskCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.PhotoCapture.OnCapturedToDiskCallback((result) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.PhotoCapture.PhotoCaptureResult>)act)(result);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WebCam.PhotoCapture.OnCapturedToMemoryCallback>((act) =>
            {
                return new UnityEngine.VR.WSA.WebCam.PhotoCapture.OnCapturedToMemoryCallback((result, photoCaptureFrame) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.WebCam.PhotoCapture.PhotoCaptureResult, UnityEngine.VR.WSA.WebCam.PhotoCaptureFrame>)act)(result, photoCaptureFrame);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Byte>>((act) =>
            {
                return new System.Predicate<System.Byte>((obj) =>
                {
                    return ((System.Func<System.Byte, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Byte>>((act) =>
            {
                return new System.Comparison<System.Byte>((x, y) =>
                {
                    return ((System.Func<System.Byte, System.Byte, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.Input.InteractionManager.SourceEventHandler>((act) =>
            {
                return new UnityEngine.VR.WSA.Input.InteractionManager.SourceEventHandler((state) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.Input.InteractionSourceState>)act)(state);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.VR.WSA.WorldManager.OnPositionalLocatorStateChangedDelegate>((act) =>
            {
                return new UnityEngine.VR.WSA.WorldManager.OnPositionalLocatorStateChangedDelegate((oldState, newState) =>
                {
                    ((System.Action<UnityEngine.VR.WSA.PositionalLocatorState, UnityEngine.VR.WSA.PositionalLocatorState>)act)(oldState, newState);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Video.VideoPlayer.EventHandler>((act) =>
            {
                return new UnityEngine.Video.VideoPlayer.EventHandler((source) =>
                {
                    ((System.Action<UnityEngine.Video.VideoPlayer>)act)(source);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Video.VideoPlayer.ErrorEventHandler>((act) =>
            {
                return new UnityEngine.Video.VideoPlayer.ErrorEventHandler((source, message) =>
                {
                    ((System.Action<UnityEngine.Video.VideoPlayer, System.String>)act)(source, message);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Video.VideoPlayer.FrameReadyEventHandler>((act) =>
            {
                return new UnityEngine.Video.VideoPlayer.FrameReadyEventHandler((source, frameIdx) =>
                {
                    ((System.Action<UnityEngine.Video.VideoPlayer, System.Int64>)act)(source, frameIdx);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngineInternal.Input.NativeUpdateCallback>((act) =>
            {
                return new UnityEngineInternal.Input.NativeUpdateCallback((updateType) =>
                {
                    ((System.Action<UnityEngineInternal.Input.NativeInputUpdateType>)act)(updateType);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngineInternal.Input.NativeDeviceDiscoveredCallback>((act) =>
            {
                return new UnityEngineInternal.Input.NativeDeviceDiscoveredCallback((deviceInfo) =>
                {
                    ((System.Action<UnityEngineInternal.Input.NativeInputDeviceInfo>)act)(deviceInfo);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngineInternal.FastCallExceptionHandler>((act) =>
            {
                return new UnityEngineInternal.FastCallExceptionHandler((ex) =>
                {
                    ((System.Action<System.Exception>)act)(ex);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>((arg0) =>
                {
                    ((System.Action<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)act)(arg0);
                });
            });


        }

        static public void RegisterMethodDelegate(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterMethodDelegate<System.IAsyncResult>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Component>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Object>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Single>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector4>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Matrix4x4>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector3>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Color>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Color32>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector2>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.BoneWeight>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Rendering.ReflectionProbeBlendInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Camera>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.RaycastResult>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.EventTrigger.Entry>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.RectTransform>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UIVertex>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Rect>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Boolean>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.AnimatorClipInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UI.Selectable>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UICharInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UILineInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Font>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UI.Dropdown.OptionData>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.String>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Sprite>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UI.RectMask2D>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, System.Boolean>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, System.Single[], System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Collision>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Collision2D>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.ControllerColliderHit>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, System.Single>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Joint2D>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.GameObject>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.RenderTexture, UnityEngine.RenderTexture>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Collider>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Collider2D>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Reflection.FieldInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Type>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Object>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.String, System.Boolean, System.String>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.String, System.String, UnityEngine.LogType>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.UInt16>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.CullingGroupEvent>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Boolean, System.String>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.SceneManagement.Scene>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Windows.Speech.SpeechError>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Windows.Speech.SpeechSystemStatus>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Windows.Speech.PhraseRecognizedEventArgs>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.String, UnityEngine.Windows.Speech.ConfidenceLevel>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Windows.Speech.DictationCompletionCause>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.String, System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int32, System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.WSA.WindowActivationState>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.ParticleSystemVertexStream>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.ParticleCollisionEvent>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.ParticleSystem.Particle>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.AI.NavMeshBuildMarkup>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.AI.NavMeshBuildSource>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Single[]>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Networking.IMultipartFormSection>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Networking.Match.MatchInfoSnapshot.MatchInfoDirectConnectSnapshot>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Boolean, System.String, UnityEngine.Networking.Match.MatchInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Boolean, System.String, System.Collections.Generic.List<UnityEngine.Networking.Match.MatchInfoSnapshot>>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Networking.ChannelQOS>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Networking.ConnectionConfig>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Ray>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.Input.InteractionSourceKind, System.Int32, UnityEngine.Ray>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.Input.InteractionSourceKind, UnityEngine.Vector3, UnityEngine.Ray>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.SurfaceId, UnityEngine.VR.WSA.SurfaceChange, UnityEngine.Bounds, System.DateTime>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.SurfaceData, System.Boolean, System.Single>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.Persistence.WorldAnchorStore>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.WorldAnchor, System.Boolean>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Byte[]>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.Sharing.SerializationCompletionReason>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.Sharing.SerializationCompletionReason, UnityEngine.VR.WSA.Sharing.WorldAnchorTransferBatch>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.WebCam.VideoCapture>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.WebCam.VideoCapture.VideoCaptureResult>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.WebCam.PhotoCapture>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.WebCam.PhotoCapture.PhotoCaptureResult>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.WebCam.PhotoCapture.PhotoCaptureResult, UnityEngine.VR.WSA.WebCam.PhotoCaptureFrame>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Byte>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.Input.InteractionSourceState>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.VR.WSA.PositionalLocatorState, UnityEngine.VR.WSA.PositionalLocatorState>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Video.VideoPlayer>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Video.VideoPlayer, System.String>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Video.VideoPlayer, System.Int64>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngineInternal.Input.NativeInputUpdateType>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngineInternal.Input.NativeInputDeviceInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.SocialPlatforms.IUserProfile[]>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.SocialPlatforms.IAchievementDescription[]>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.SocialPlatforms.IAchievement[]>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.SocialPlatforms.IScore[]>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Exception>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Networking.PlayerConnection.MessageEventArgs>();

        }

        static public void Fame()
        {
            System.Type v = null;
            v = typeof(System.Collections.Generic.List<System.String>);

            v = typeof(System.Collections.Generic.List<System.String>.Enumerator);

            v = typeof(IL.RefOutParam<System.Int32>);

            v = typeof(System.Collections.Generic.List<System.Object>);

            v = typeof(System.Collections.Generic.List<System.Int32>);


        }
    }
}
#endif