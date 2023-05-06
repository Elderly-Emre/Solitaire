using System;
using MelonLoader;
using Harmony;
using UnityEngine;


using AudioMgr;

namespace Solitaire
{
	public class InitBoard
	{
		public static CardGame Init(GameObject cardGameObject)
		{
			CardGame cardGame = Utils.GetOrCreateComponent<CardGame>(cardGameObject);			

			if (!cardGame.boardInitialized)
            {
                cardGame.cardPositions = new int[13, 52];
                cardGame.playingCards = new PlayingCard[52];
                cardGame.cardControls = new CardControl[4];
                cardGame.cardPlaceholder = new CardPlaceholder[13];
                //cardGame.cardAudioShot = AudioMaster.CreateShot(cardGameObject, SolitaireMain.cardAudioSetting);
                cardGame.cardAudioShot = AudioMaster.CreateShot(cardGameObject, AudioMaster.SourceType.SFX);
                //cardGame.cardAudioShot.PlayOneshot(SolitaireMain.cardAudioManager.GetClip(""));

                InitObjects.Init(cardGame);
                cardGame.boardInitialized = true;
            }
			
			return cardGame;
		}

       
    }
}