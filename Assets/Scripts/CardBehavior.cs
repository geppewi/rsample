using Assets.Master.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class CardBehavior : MonoBehaviour
    {
        public Image image;
        public M_Card card;

        private Transform canvasTran;

        private Vector3 defaultLocation;

        void Awake()
        {
            defaultLocation = transform.position;
            canvasTran = transform.parent.parent;
        }

        public void OnBeginDrag(PointerEventData pointerEventData)
        {
            defaultLocation = transform.position;
            transform.position = pointerEventData.position;
        }

        public void OnDrag(PointerEventData pointerEventData)
        {
            transform.position = pointerEventData.position;
        }

        public void OnEndDrag(PointerEventData pointerEventData)
        {
            gameObject.GetComponent<Image>().color = Vector4.one;
            transform.position = defaultLocation;
        }

    }
}
