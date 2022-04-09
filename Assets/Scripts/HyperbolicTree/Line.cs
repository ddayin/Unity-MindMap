using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

namespace HyperbolicTree
{
    public class Line : MonoBehaviour
    {
        private UILineRenderer lineRenderer;

        public float length;
        public float thickness = 2;

        private void Awake()
        {
            lineRenderer = transform.GetComponent<UILineRenderer>();
            //lineRenderer.LineThickness = thickness;
        }

        public void SetPosition(Vector2 targetPosition)
        {
            Vector2[] posArray = new Vector2[2];
            posArray[0] = Vector2.zero;
            posArray[1] = targetPosition;
            lineRenderer.Points.SetValue(posArray[0], 0);
            lineRenderer.Points.SetValue(posArray[1], 1);
        }
    }
}