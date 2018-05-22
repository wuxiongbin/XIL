#if USE_HOT
namespace AutoIL
{
    using ILRuntime.Runtime.Enviorment;

    static class ILRegType
    {
        static public void RegisterFunctionDelegate(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Component, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Component, UnityEngine.Component, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject, UnityEngine.GameObject, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.RaycastResult, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.RaycastResult, UnityEngine.EventSystems.RaycastResult, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.EventTrigger.Entry, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.EventTrigger.Entry, UnityEngine.EventSystems.EventTrigger.Entry, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector2, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector2, UnityEngine.Vector2, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Selectable, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Selectable, UnityEngine.UI.Selectable, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Dropdown.OptionData, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Dropdown.OptionData, UnityEngine.UI.Dropdown.OptionData, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.String, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Sprite, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Sprite, UnityEngine.Sprite, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.Int32, System.Char, System.Char>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector3, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector3, UnityEngine.Vector3, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector4, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector4, UnityEngine.Vector4, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color, UnityEngine.Color, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color32, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color32, UnityEngine.Color32, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32, System.Int32, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Matrix4x4, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Matrix4x4, UnityEngine.Matrix4x4, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Type, System.Int32>();

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

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>((arg0) =>
                {
                    ((System.Action<UnityEngine.EventSystems.BaseEventData>)act)(arg0);
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

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Boolean>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Boolean>((arg0) =>
                {
                    ((System.Action<System.Boolean>)act)(arg0);
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

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Int32>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Int32>((arg0) =>
                {
                    ((System.Action<System.Int32>)act)(arg0);
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

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Single>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Single>((arg0) =>
                {
                    ((System.Action<System.Single>)act)(arg0);
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

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Int32>>((act) =>
            {
                return new System.Predicate<System.Int32>((obj) =>
                {
                    return ((System.Func<System.Int32, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Int32>>((act) =>
            {
                return new System.Comparison<System.Int32>((x, y) =>
                {
                    return ((System.Func<System.Int32, System.Int32, System.Int32>)act)(x, y);
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


        }

        static public void RegisterMethodDelegate(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Component>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.RaycastResult>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.EventTrigger.Entry>();
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
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector2>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Boolean>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UI.Selectable>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UI.Dropdown.OptionData>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.String>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Sprite>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Single>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector3>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector4>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Color>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Color32>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Matrix4x4>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Type>();

        }
    }
}
#endif