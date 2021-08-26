﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoMod;

namespace HKLab.Hooks
{
    public delegate void AfterSavegameLoadHandler(SaveGameData arg_0);
    public delegate void ClearSaveGameHandler(int arg_0);
    public delegate void AfterClearSaveGameHandler(int arg_0);
    public delegate string GetSaveFileNameHandler(int arg_0);
    public delegate void NewGameHandler();
    public delegate void NewPlayerDataHandler(PlayerData arg_0);
    public delegate void SceneChangedHandler(string arg_0);
    public delegate string BeforeSceneLoadHandler(string arg_0);
    public delegate string LanguageGetHandler(string arg_0, string arg_1);
    public delegate void HeroUpdateHandler();
    public delegate void CharmUpdateHandler(PlayerData arg_0, HeroController arg_1);
    public delegate void AttackHandler(GlobalEnums.AttackDirection arg_0);
    public delegate void AfterAttackHandler(GlobalEnums.AttackDirection arg_0);
    public delegate int AfterTakeDamageHandler(int arg_0, int arg_1);
    public delegate int BlueHealthHandler();
    public delegate void CursorHandler();
    public delegate void DoAttackHandler();
    public delegate float FocusCostHandler();
    public delegate void SlashHitHandler(UnityEngine.Collider2D arg_0, UnityEngine.GameObject arg_1);
    public delegate int SoulGainHandler(int arg_0);
    public delegate UnityEngine.Vector2 DashVelocityHandler(UnityEngine.Vector2 arg_0);
    public delegate bool DashPressedHandler();
    public delegate void ColliderCreateHandler(UnityEngine.GameObject arg_0);
    public delegate UnityEngine.GameObject GameObjectHandler(UnityEngine.GameObject arg_0);
    public delegate UnityEngine.GameObject GameObjectFsmHandler(UnityEngine.GameObject arg_0, HutongGames.PlayMaker.Fsm arg_1);
    public delegate void SetFontHandler();
    public delegate void VoidHandler();
    public delegate int BeforeAddHealthHandler(int arg_0);
    public delegate HitInstance HitInstanceHandler(HutongGames.PlayMaker.Fsm arg_0, HitInstance arg_1);
    public delegate void DrawBlackBordersHandler(List<UnityEngine.GameObject> arg_0);
    public delegate bool OnEnableEnemyHandler(UnityEngine.GameObject arg_0, bool arg_1);
    public delegate bool OnRecieveDeathEventHandler(EnemyDeathEffects arg_0, bool arg_1, ref float? arg_2, ref bool arg_3, ref bool arg_4, ref bool arg_5);
    public delegate void OnReceiveDeathEventHandler(EnemyDeathEffects arg_0, bool arg_1, ref float? arg_2, ref bool arg_3, ref bool arg_4, ref bool arg_5);
    public delegate bool OnRecordKillForJournalHandler(EnemyDeathEffects arg_0, string arg_1, string arg_2, string arg_3, string arg_4);
    public delegate void RecordKillForJournalHandler(EnemyDeathEffects arg_0, string arg_1, string arg_2, string arg_3, string arg_4);
    public delegate bool GetBoolProxy(string arg_0);
    public delegate void SetBoolProxy(string arg_0, bool arg_1);
    public delegate int GetIntProxy(string arg_0);
    public delegate void SetIntProxy(string arg_0, int arg_1);
    public delegate float GetFloatProxy(string arg_0);
    public delegate void SetFloatProxy(string arg_0, float arg_1);
    public delegate string GetStringProxy(string arg_0);
    public delegate void SetStringProxy(string arg_0, string arg_1);
    public delegate UnityEngine.Vector3 GetVector3Proxy(string arg_0);
    public delegate void SetVector3Proxy(string arg_0, UnityEngine.Vector3 arg_1);
    public delegate object GetVariableProxy(Type arg_0, string arg_1, object arg_2);
    public delegate object SetVariableProxy(Type arg_0, string arg_1, object arg_2);
    public delegate int TakeDamageProxy(ref int arg_0, int arg_1);
    public delegate int TakeHealthProxy(int arg_0);
    public delegate bool TextDirectionProxy(bool arg_0);
    public delegate void SavegameLoadHandler(int id);
    public delegate void SavegameSaveHandler(int id);
    public delegate void BeforeSavegameSaveHandler(SaveGameData data);
    public delegate void ApplicationQuitHandler();
}
