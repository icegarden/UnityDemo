using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {

//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            ILRuntime.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }

        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2> s_UnityEngine_Vector2_Binding_Binder = null;
        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3> s_UnityEngine_Vector3_Binding_Binder = null;
        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion> s_UnityEngine_Quaternion_Binding_Binder = null;

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            System_Collections_Generic_Dictionary_2_Type_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Type_Binding.Register(app);
            System_Type_Binding.Register(app);
            System_Object_Binding.Register(app);
            System_Reflection_PropertyInfo_Binding.Register(app);
            System_String_Binding.Register(app);
            LitJson_JsonReader_Binding.Register(app);
            LitJson_JsonMapper_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            FairyGUI_UIPackage_Binding.Register(app);
            FairyGUI_GComponent_Binding.Register(app);
            FairyGUI_UIObjectFactory_Binding.Register(app);
            System_Reflection_MemberInfo_Binding.Register(app);
            System_Exception_Binding.Register(app);
            ET_Log_Binding.Register(app);
            System_Collections_Generic_HashSet_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_HashSet_1_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_IDisposable_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_ILTypeInstance_Binding_ValueCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_ILTypeInstance_Binding_ValueCollection_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_ILTypeInstance_Binding_ValueCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_ILTypeInstance_Binding_ValueCollection_Binding_Enumerator_Binding.Register(app);
            ET_MonoPool_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Type_ILTypeInstance_Binding.Register(app);
            System_Activator_Binding.Register(app);
            System_Collections_Generic_List_1_Type_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_List_1_Type_Binding.Register(app);
            System_Collections_Generic_List_1_Type_Binding_Enumerator_Binding.Register(app);
            ET_UnOrderMultiMap_2_Type_Type_Binding.Register(app);
            ET_UnOrderMultiMap_2_Type_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_List_1_Object_Binding.Register(app);
            System_Collections_Generic_List_1_Object_Binding.Register(app);
            System_Reflection_Assembly_Binding.Register(app);
            System_Reflection_AssemblyName_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Assembly_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Assembly_Binding_ValueCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Assembly_Binding_ValueCollection_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_Queue_1_Int64_Binding.Register(app);
            ET_ObjectHelper_Binding.Register(app);
            System_Text_StringBuilder_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Type_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Int64_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Type_Binding_Enumerator_Binding.Register(app);
            System_Linq_Enumerable_Binding.Register(app);
            System_Collections_Generic_IEnumerable_1_KeyValuePair_2_Type_Int32_Binding.Register(app);
            System_Collections_Generic_IEnumerator_1_KeyValuePair_2_Type_Int32_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Type_Int32_Binding.Register(app);
            System_Collections_IEnumerator_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_UnOrderMultiMap_2_Type_Object_Binding.Register(app);
            ET_TimeInfo_Binding.Register(app);
            ET_Options_Binding.Register(app);
            System_DateTime_Binding.Register(app);
            System_IO_MemoryStream_Binding.Register(app);
            ProtoBuf_Meta_RuntimeTypeModel_Binding.Register(app);
            ProtoBuf_Meta_TypeModel_Binding.Register(app);
            ProtoBuf_Serializer_Binding.Register(app);
            System_ValueTuple_2_Int16_MemoryStream_Binding.Register(app);
            System_Collections_Generic_HashSet_1_AService_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int16_Type_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_Int16_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_Type_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Int16_Binding.Register(app);
            ET_TimeHelper_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding.Register(app);
            ET_AService_Binding.Register(app);
            ET_ETTask_1_ILTypeInstance_Binding.Register(app);
            System_Action_1_ILTypeInstance_Binding.Register(app);
            ET_WService_Binding.Register(app);
            System_IO_Stream_Binding.Register(app);
            System_Byte_Binding.Register(app);
            System_BitConverter_Binding.Register(app);
            System_Net_IPAddress_Binding.Register(app);
            System_Action_2_Int16_Object_Binding.Register(app);
            System_Action_Binding.Register(app);
            ET_RandomHelper_Binding.Register(app);
            System_Net_IPEndPoint_Binding.Register(app);
            System_Int32_Binding.Register(app);
            ET_ThreadSynchronizationContext_Binding.Register(app);
            ET_ForeachHelper_Binding.Register(app);
            FairyGUI_GRoot_Binding.Register(app);
            FairyGUI_GObject_Binding.Register(app);
            FairyGUI_EventListener_Binding.Register(app);
            UnityEngine_Input_Binding.Register(app);
            UnityEngine_Screen_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            FairyGUI_GTweener_Binding.Register(app);
            Game_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Type_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_GComponent_Binding.Register(app);
            FairyGUI_Stage_Binding.Register(app);
            FairyGUI_GProgressBar_Binding.Register(app);
            FairyGUI_EventContext_Binding.Register(app);
            System_Double_Binding.Register(app);
            EventUtil_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            System_Collections_Generic_List_1_Action_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int16_Action_1_Object_Binding.Register(app);
            System_Action_1_Object_Binding.Register(app);
            ResourceItemLoader_Binding.Register(app);
            EventConst_Binding.Register(app);
            System_IO_Path_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            System_Collections_Generic_List_1_String_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            FairyGUI_GLoader3D_Binding.Register(app);
            Spine_Unity_SkeletonAnimation_Binding.Register(app);
            Spine_AnimationState_Binding.Register(app);
            UnityEngine_Component_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_List_1_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_List_1_ILTypeInstance_Binding.Register(app);

            ILRuntime.CLR.TypeSystem.CLRType __clrType = null;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Vector2));
            s_UnityEngine_Vector2_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Vector3));
            s_UnityEngine_Vector3_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Quaternion));
            s_UnityEngine_Quaternion_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>;
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            s_UnityEngine_Vector2_Binding_Binder = null;
            s_UnityEngine_Vector3_Binding_Binder = null;
            s_UnityEngine_Quaternion_Binding_Binder = null;
        }
    }
}
