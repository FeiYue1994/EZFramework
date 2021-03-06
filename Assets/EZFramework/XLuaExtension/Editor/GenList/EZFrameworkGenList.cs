/*
 * Author:      熊哲
 * CreateTime:  3/31/2017 6:11:46 PM
 * Description:
 * 
*/
using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace EZFramework.XLuaConfig
{
    public static class EZFrameworkGenList
    {
        [LuaCallCSharp]
        public static List<Type> LuaCallCSharp = new List<Type>()
        {
            typeof(EZFramework.EZFacade),
            typeof(EZFramework.EZDatabase),
            typeof(EZFramework.EZNetwork),
            typeof(EZFramework.EZResource),
            typeof(EZFramework.EZSound),
            typeof(EZFramework.EZUpdate),
            typeof(EZFramework.EZUI),
            typeof(EZFramework.EZWWWTask),
            typeof(EZFramework.EZLoadingPanel),
            typeof(EZFramework.EZUtility),
            typeof(EZFramework.EZExtensions),

            typeof(EZFramework.UniSDK.Base.PolyAD),
            typeof(EZFramework.UniSDK.Base.Notification),
            typeof(EZFramework.UniSDK.Base.UnityAnalytics),
            typeof(EZFramework.UniSDK.Base.UnityAnalytics.CustomEvent),
            typeof(EZFramework.UniSDK.Base.UnityPurchasing),
            typeof(EZFramework.UniSDK.Base.UnityPurchasing.CustomProduct),
            typeof(EZFramework.UniSDK.Base.UnityPurchasing.ReceiptContent),
            typeof(EZFramework.UniSDK.Base.UnityPurchasing.PayloadContent),
            typeof(EZFramework.UniSDK.Base.UnityPurchasing.JsonContent),

            typeof(EZFramework.XLuaExtension.EZLua),
            typeof(EZFramework.XLuaExtension.LuaBehaviour),
            typeof(EZFramework.XLuaExtension.LuaInjector),
            typeof(EZFramework.XLuaExtension.ExtensionFunctions),
            typeof(EZFramework.XLuaExtension.LuaUtility),
            typeof(EZFramework.XLuaExtension.ActivityMessage),
            typeof(EZFramework.XLuaExtension.ActivityMessage.ActivityEvent),
            typeof(EZFramework.XLuaExtension.ApplicationMessage),
            typeof(EZFramework.XLuaExtension.ApplicationMessage.ApplicationEvent),
            typeof(EZFramework.XLuaExtension.CollisionMessage),
            typeof(EZFramework.XLuaExtension.CollisionMessage.CollisionEvent),
            typeof(EZFramework.XLuaExtension.MouseMessage),
            typeof(EZFramework.XLuaExtension.MouseMessage.MouseEvent),
            typeof(EZFramework.XLuaExtension.TriggerMessage),
            typeof(EZFramework.XLuaExtension.TriggerMessage.TriggerEvent),
            typeof(EZFramework.XLuaExtension.UpdateMessage),
            typeof(EZFramework.XLuaExtension.UpdateMessage.UpdateEvent),

            typeof(EZComponent.EZTimer),
            typeof(EZComponent.EZTimer.Task),
            typeof(EZComponent.EZTimer.TickMode),

            typeof(EZComponent.EZAnimation.EZGraphicColorAnimation),
            typeof(EZComponent.EZAnimation.EZRectTransformAnimation),
            typeof(EZComponent.EZAnimation.EZTransformAnimation),

            typeof(EZComponent.UI.EZGridLayout2D),
            typeof(EZComponent.UI.EZOutstand),
            typeof(EZComponent.UI.EZScrollRect),
            typeof(EZComponent.UI.EZSizeDriver),
            typeof(EZComponent.UI.EZTransition),
        };

        [CSharpCallLua]
        public static List<Type> CSharpCallLua = new List<Type>()
        {
            typeof(EZFramework.EZFacade.OnApplicationAction),
            typeof(EZFramework.EZFacade.OnApplicationStatusAction),
            typeof(EZFramework.EZResource.OnAssetLoadedAction),
            typeof(EZFramework.EZResource.OnSceneChangedAction),
            typeof(EZFramework.EZResource.OnBundleLoadedAction),
            typeof(EZFramework.EZWWWTask.OnProgressAction),
            typeof(EZFramework.EZWWWTask.OnStopAction),

            typeof(EZFramework.UniSDK.Base.OnResultCallback),
            typeof(EZFramework.UniSDK.Base.OnDataCallback),
            typeof(EZFramework.UniSDK.Base.OnEventCallback1),
            typeof(EZFramework.UniSDK.Base.OnEventCallback2),
            typeof(EZFramework.UniSDK.Base.Notification.NotificationProvider),

            typeof(EZFramework.XLuaExtension.LuaBehaviour.LCBinder),
            typeof(EZFramework.XLuaExtension.LuaRequire),
            typeof(EZFramework.XLuaExtension.LuaAction),
            typeof(EZFramework.XLuaExtension.LuaCoroutineCallback),
            typeof(EZFramework.XLuaExtension.OnMessageAction),
            typeof(EZFramework.XLuaExtension.OnMessageAction<bool>),
            typeof(EZFramework.XLuaExtension.OnMessageAction<Collider>),
            typeof(EZFramework.XLuaExtension.OnMessageAction<Collision>),

            typeof(EZComponent.EZAnimation.OnAnimationEndAction),

            typeof(EZComponent.UI.EZScrollRect.OnBeginScrollAction),
            typeof(EZComponent.UI.EZScrollRect.OnEndScrollAction),
        };

        [BlackList]
        public static List<List<string>> BlackList = new List<List<string>>()
        {

        };
    }
}