using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class UnitsBehaviour : MonoBehaviour
    {
        public Image iconImage;
        private Sprite nowSprite;

        public Image Upper;
        public Image Lower;

        public Image Left;
        public Image Center;
        public Image Right;

        void Start()
        {
            nowSprite = null;
        }

        public void OnPointerEnter(PointerEventData pointerEventData)
        {
            if (pointerEventData.pointerDrag == null) { return; }
            var card = pointerEventData.pointerDrag.GetComponent<CardBehavior>();

            if (card == null) { return; }
            

        }

        public void OnPointerExit(PointerEventData pointerEventData)
        {
            if (pointerEventData.pointerDrag == null) { return; }
            iconImage.sprite = nowSprite;

            if (nowSprite == null) { iconImage.color = Vector4.zero; }
            else { iconImage.color = Vector4.one; }

        }

        public void OnDrop(PointerEventData pointerEventData)
        {
            Image droppedImage = pointerEventData.pointerDrag.GetComponent<Image>();
            iconImage.sprite = droppedImage.sprite;
            nowSprite = droppedImage.sprite;
            iconImage.color = Vector4.one;
        }
    }
}