using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HyperbolicTree
{
    public class Node_View : MonoBehaviour
    {
        private Node_Model model;

        private CircleCollider2D colliderCircle;
        private RectTransform rectTransform;
        private Image imageBg;
        private Text textTitle;
        private Text textId;

        private const float scaleFactor_0 = 2.3f;
        private const float scaleFactor_1 = 1.5f;
        private const float scaleFactor_2 = 1f;
        private const float scaleFactor_3 = 0.7f;
        private const float scaleFactor_4 = 0.5f;

        public float radius_0 = 64f * scaleFactor_0;
        public float radius_1 = 64f * scaleFactor_1;
        public float radius_2 = 64f * scaleFactor_2;
        public float radius_3 = 64f * scaleFactor_3;
        public float radius_4 = 64f * scaleFactor_4;


        private void Awake()
        {
            colliderCircle = transform.GetComponent<CircleCollider2D>();
            rectTransform = transform.Find("NodeComponent") as RectTransform;
            imageBg = transform.Find("NodeComponent/ImageBg").GetComponent<Image>();
            textTitle = transform.Find("NodeComponent/TextTitle").GetComponent<Text>();
            textId = transform.Find("NodeComponent/TextId").GetComponent<Text>();
        }

        public void Initialize(Node_Model _model)
        {
            model = _model;

            SetScale();
            SetColor();
            SetColliderRadius();
            SetTextTitle(model.name);
        }

        private void SetTextTitle(string title)
        {
            textId.text = model.id;
            textTitle.text = title;
        }

        private void SetScale()
        {
            if (model.depth == 0)
            {
                rectTransform.localScale = new Vector3(scaleFactor_0, scaleFactor_0, 1f);
            }
            else if (model.depth == 1)
            {
                rectTransform.localScale = new Vector3(scaleFactor_1, scaleFactor_1, 1f);
            }
            else if (model.depth == 2)
            {
                rectTransform.localScale = new Vector3(scaleFactor_2, scaleFactor_2, 1f);
            }
            else if (model.depth == 3)
            {
                rectTransform.localScale = new Vector3(scaleFactor_3, scaleFactor_3, 1f);
            }
            else if (model.depth == 4)
            {
                rectTransform.localScale = new Vector3(scaleFactor_4, scaleFactor_4, 1f);
            }
            else
            {
                Debug.LogError(model.depth);
            }
        }

        private void SetColor()
        {
            Color newColor;
            if (model.depth == 0)
            {
                ColorUtility.TryParseHtmlString("#987284", out newColor);
                imageBg.color = newColor;
            }
            else if (model.depth == 1)
            {
                ColorUtility.TryParseHtmlString("#9DBF9E", out newColor);
                imageBg.color = newColor;
            }
            else if (model.depth == 2)
            {
                ColorUtility.TryParseHtmlString("#D0D6B5", out newColor);
                imageBg.color = newColor;
            }
            else if (model.depth == 3)
            {
                ColorUtility.TryParseHtmlString("#F9B5AC", out newColor);
                imageBg.color = newColor;
            }
            else if (model.depth == 4)
            {
                ColorUtility.TryParseHtmlString("#EE7674", out newColor);
                imageBg.color = newColor;
            }
            else
            {
                Debug.LogError(model.depth);
            }
        }

        private void SetColliderRadius()
        {
            //colliderCircle.radius = radius;

            if (model.depth == 0)
            {
                colliderCircle.radius = radius_0;
            }
            else if (model.depth == 1)
            {
                colliderCircle.radius = radius_1;
            }
            else if (model.depth == 2)
            {
                colliderCircle.radius = radius_2;
            }
            else if (model.depth == 3)
            {
                colliderCircle.radius = radius_3;
            }
            else if (model.depth == 4)
            {
                colliderCircle.radius = radius_4;
            }
            else
            {
                Debug.LogError(model.depth);
            }
        }

        public float GetRadius()
        {
            if (model.depth == 0)
            {
                return radius_0;
            }
            else if (model.depth == 1)
            {
                return radius_1;
            }
            else if (model.depth == 2)
            {
                return radius_2;
            }
            else if (model.depth == 3)
            {
                return radius_3;
            }
            else if (model.depth == 4)
            {
                return radius_4;
            }
            else
            {
                Debug.LogError(model.depth);
                return 0f;
            }
        }

        private void SetLineLength()
        { 
        }
    }
}