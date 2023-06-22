using System;
using MelonLoader;
using Harmony;
using UnityEngine;

namespace Solitaire
{
    [RegisterTypeInIl2Cpp]
    public class CardPlaceholder : MonoBehaviour
    {
        public CardPlaceholder(IntPtr intPtr) : base(intPtr)
        {
        }

		public int placeholderID;
		public string placeholderName;
		public GameObject placeholderObject;
		public Transform placeholderTransform;
		public MeshRenderer placeholderRenderer;
	}
}