using System;
using MelonLoader;
using Harmony;
using UnityEngine;
using AudioMgr;

namespace Solitaire
{
    public class CardGame : MonoBehaviour
    {
        public CardGame(IntPtr intPtr) : base(intPtr)
        {
        }

		public PlayingCard[] playingCards;
		public CardControl[] cardControls;
		public CardPlaceholder[] cardPlaceholder;

        public GameObject dummyCamera;
        public GameObject playMat;

        public Shot cardAudioShot;

        public bool boardInitialized = false;
		public bool stackInitialized = false;

		public int[,] cardPositions; // cardsGameOrder		
	}
}