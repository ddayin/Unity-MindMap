using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WanzyeeStudio;

namespace HyperbolicTree
{
    public class LineFactory : BaseSingleton<LineFactory>
    {
        public GameObject prefabLine;

        public Line Create(Transform parent, Vector2 targetPosition)
        {
            GameObject newObj = Lean.Pool.LeanPool.Spawn(prefabLine, parent);
            RectTransform rectTransform = newObj.transform as RectTransform;
            rectTransform.anchoredPosition = Vector2.zero;
            
            Line line = rectTransform.GetComponent<Line>();
            line.SetPosition(targetPosition);
            return line;
        }
    }
}