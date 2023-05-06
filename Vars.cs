using System;
using UnityEngine;

namespace Solitaire
{
	public class Vars
	{
        public static GameObject currentGameObject;
		public static CardGame currentGame;
		public static PlayingCard cardInHand;
		public static bool isPlaying = false;
		public static PlayingCard[] cardListInHand;
		public static int cardListCounter = 0;
	}
}