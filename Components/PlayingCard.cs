using System;
using MelonLoader;
using Harmony;
using UnityEngine;

namespace Solitaire
{
    [RegisterTypeInIl2Cpp]
    public class PlayingCard : MonoBehaviour
    {
        public PlayingCard(IntPtr intPtr) : base(intPtr)
        {
        }

		public int cardID;
		public GameObject cardObject;

		public string cardName;
		public string cardSymbol;
		public int cardNumValue;

		public Transform cardTransform;
		public MeshRenderer cardRenderer;

		public CardGame parentGame;

		public BoxCollider cardCollider;

		public bool cardIsUncovered;
		public bool cardIsOnTop;
		public int cardColPosition;
		public int cardRowPosition;
	}
}