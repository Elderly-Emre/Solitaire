using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;
using DigitalRuby.Tween;
using System.Reflection;
using AudioMgr;

namespace Solitaire
{
	public class SolitaireMain : MelonMod
	{
        public static AssetBundle cardAudioBundle;
        public static ClipManager cardAudioManager;
        public static Setting cardAudioSetting;

        public override void OnInitializeMelon()
		{
            LoadEmbeddedAssetBundle();
        }

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
            TweenFactory.SceneManagerSceneLoaded();

            if (sceneName.Contains("MainMenu"))
            {
                SetupCardAudio();
            }
        }

        public override void OnUpdate()
		{
            Input.Update();
        }

        public void CreateCardAudioSetting()
        {
            cardAudioSetting = new Setting(AudioMaster.SourceType.Custom);

            cardAudioSetting.spread = 0.0f;
            cardAudioSetting.panStereo = 0.0f;
            cardAudioSetting.dopplerLevel = 0f;
            cardAudioSetting.maxDistance = 2f; // 18.0f;
            cardAudioSetting.minDistance = 1.0f;
            cardAudioSetting.pitch = 1.0f;
            cardAudioSetting.spatialBlend = 1.0f;
            cardAudioSetting.rolloffFactor = 0.8f;
            cardAudioSetting.spatialize = true;
            cardAudioSetting.rolloffMode = AudioRolloffMode.Linear;
            //_defaultSetting[AudioMaster.SourceType.SFX].rollOffCurve = stdRollOffCurve;
            cardAudioSetting.priority = 128;
            cardAudioSetting.maxVolume = 0.5f;
            cardAudioSetting.minVolume = 0.1f;

        }

        public void SetupCardAudio()
        {
            cardAudioManager = AudioMaster.NewClipManager();

            cardAudioManager.LoadAllClipsFromBundle(cardAudioBundle);


            CreateCardAudioSetting();
        }

        public static void LoadEmbeddedAssetBundle()
        {
            MemoryStream memoryStream;
            System.IO.Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Solitaire.Resources.cardaudio");
            memoryStream = new MemoryStream((int)stream.Length);
            stream.CopyTo(memoryStream);

            cardAudioBundle = AssetBundle.LoadFromMemory(memoryStream.ToArray());

            cardAudioBundle.hideFlags = HideFlags.HideAndDontSave;
            GameObject.DontDestroyOnLoad(cardAudioBundle);       
        }
    }
}