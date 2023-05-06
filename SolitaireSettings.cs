using System.IO;
using System.Reflection;
using UnityEngine;
using ModSettings;

namespace Solitaire
{
	internal class CardGameSettingsMain : JsonModSettings
	{
        /*
		[Section("Stuff")]

		
		[Name("Sneeze")]
		[Description("Makes you sneeze. Thank Waltz for that.")]
		public UnityEngine.KeyCode sneezeButton = KeyCode.LeftAlt;


		[Name("Disable sneeze sound")]
		[Description("Disable")]
		public bool disableSneeze = false;
		*/

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
		{
			//AudioListener.volume = Settings.options.cardGameVolume;
		}

		protected override void OnConfirm()
		{			
			base.OnConfirm();
		}
	}

	internal static class Settings
	{
		public static CardGameSettingsMain options;

		public static void OnLoad()
		{
			//options = new CardGameSettingsMain();
			///options.RefreshFields();
			//options.AddToModSettings("Solitaire");
		}
	}
}
