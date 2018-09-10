#if USE_HOT && UNITY_STANDALONE_WIN
namespace AutoIL
{
    using ILRuntime.Runtime.Enviorment;

    static class ILRegType
    {
        static public void RegisterFunctionDelegate(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Component, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Component, UnityEngine.Component, System.Int32>();
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
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject, UnityEngine.GameObject, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.RaycastResult, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.RaycastResult, UnityEngine.EventSystems.RaycastResult, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.EventTrigger.Entry, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.EventTrigger.Entry, UnityEngine.EventSystems.EventTrigger.Entry, System.Int32>();
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
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Type, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Object, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Object, UnityEngine.Object, System.Int32>();

        }

        static public void RegisterDelegateConvertor(AppDomain appdomain)
        {
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

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction>((act) =>
            {
                return new UnityEngine.Events.UnityAction(() =>
                {
                    ((System.Action)act)();
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Canvas.WillRenderCanvases>((act) =>
            {
                return new UnityEngine.Canvas.WillRenderCanvases(() =>
                {
                    ((System.Action)act)();
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Font.FontTextureRebuildCallback>((act) =>
            {
                return new UnityEngine.Font.FontTextureRebuildCallback(() =>
                {
                    ((System.Action)act)();
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.RectTransform.ReapplyDrivenProperties>((act) =>
            {
                return new UnityEngine.RectTransform.ReapplyDrivenProperties((driven) =>
                {
                    ((System.Action<UnityEngine.RectTransform>)act)(driven);
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

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<ILRuntime.CLR.TypeSystem.IType>>((act) =>
            {
                return new System.Predicate<ILRuntime.CLR.TypeSystem.IType>((obj) =>
                {
                    return ((System.Func<ILRuntime.CLR.TypeSystem.IType, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.CLR.TypeSystem.IType>>((act) =>
            {
                return new System.Comparison<ILRuntime.CLR.TypeSystem.IType>((x, y) =>
                {
                    return ((System.Func<ILRuntime.CLR.TypeSystem.IType, ILRuntime.CLR.TypeSystem.IType, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<ILRuntime.CLR.Method.IMethod>>((act) =>
            {
                return new System.Predicate<ILRuntime.CLR.Method.IMethod>((obj) =>
                {
                    return ((System.Func<ILRuntime.CLR.Method.IMethod, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.CLR.Method.IMethod>>((act) =>
            {
                return new System.Comparison<ILRuntime.CLR.Method.IMethod>((x, y) =>
                {
                    return ((System.Func<ILRuntime.CLR.Method.IMethod, ILRuntime.CLR.Method.IMethod, System.Int32>)act)(x, y);
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


        }

        static public void RegisterMethodDelegate(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Component>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Object>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Rendering.AsyncGPUReadbackRequest>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Single>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector4>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Matrix4x4>();
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
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector3>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Color>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Color32>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector2>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.BoneWeight>();
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
            appdomain.DelegateManager.RegisterMethodDelegate<System.Type>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Object>();

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