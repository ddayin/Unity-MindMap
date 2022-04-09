using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HyperbolicTree
{
    /// <summary>
    /// 
    /// </summary>
    public class Node_Controller : MonoBehaviour
    {
        public class Connection
        {
            public Vector2 point = Vector2.zero;
            public float radius = 0f;
        }

        public Node_Model model;
        private Node_View view;

        private Transform parentNode;
        private Transform parentLine;

        //public List<Node_Model> nodeChildren = new List<Node_Model>();
        public List<Node_Controller> nodeChildren = new List<Node_Controller>();
        public List<Line> lineChildren = new List<Line>();
        public List<Vector2> childLinePoints = new List<Vector2>();
        public List<Connection> connectionsList = new List<Connection>();

        private void Awake()
        {
            view = GetComponent<Node_View>();
            parentNode = transform.Find("NodeChild");
            parentLine = transform.Find("ParentLine");

            //CalculatePoints();
        }

        public void Initialize(Node_Model _model)
        {
            model = _model;

            view.Initialize(model);

            CheckAndCreateChildren();
        }

        private const float lineLength = 300f;
        private const float lineLengthDouble = 300f * 1.4f;

        private void CalculatePoints()
        {
            // 총 8개의 각도 배열로 저장
            float[] anglesArray = new float[] { 0f, 45f, 90f, 135f, 180f, 225f, 270f, 315f };

            foreach (float angle in anglesArray)
            {
                // 수학 공식 참고 : https://nenara.com/68
                // 높이 = sin( 각도 ) * 빗면
                // 밑변 = cos( 각도 ) * 빗면
                float x = Mathf.Cos(angle * (Mathf.PI / 180f)) * lineLength;
                float y = Mathf.Sin(angle * (Mathf.PI / 180f)) * lineLength;

                childLinePoints.Add(new Vector2(x, y));

                Connection connnection = new Connection();
                connnection.point = new Vector2(x, y);
                connnection.radius = view.radius_0;

                connectionsList.Add(connnection);
            }
        }

        private Vector2 GetChildPoint(float angle, bool hasChild)
        {
            // 수학 공식 참고 : https://nenara.com/68
            // 높이 = sin( 각도 ) * 빗면
            // 밑변 = cos( 각도 ) * 빗면

            float x = 0f;
            float y = 0f;
            if (hasChild == false)
            {
                x = Mathf.Cos(angle * (Mathf.PI / 180f)) * lineLength;
                y = Mathf.Sin(angle * (Mathf.PI / 180f)) * lineLength;
            }
            else
            {
                x = Mathf.Cos(angle * (Mathf.PI / 180f)) * lineLengthDouble;
                y = Mathf.Sin(angle * (Mathf.PI / 180f)) * lineLengthDouble;
            }
            

            return new Vector2(x, y);
        }

        private void CheckAndCreateChildren()
        {
            for (int n = 0; n < model.childNodes.Count; n++)
            {
                bool isLoop = true;
                do
                {
                    // 360도 랜덤한 각도로 360번 빈 영역이 있는지 검사한다.
                    float randomAngle = (float)UnityEngine.Random.Range(0, 360);
                    bool hasChild = false;
                    if (model.childNodes[n].childNodes.Count > 0)
                    {
                        hasChild = true;
                    }
                    else
                    {
                        hasChild = false;
                    }
                    Vector2 point = GetChildPoint(randomAngle, hasChild);
                    float radius = view.GetRadius();

                    if (CheckIfEmptySpace(point, radius) == true)
                    {
                        Debug.Log("자식노드를 생성할 영역을 찾음 name = " + model.childNodes[n].name + " point = " + point);

                        Node_Controller node = NodeFactory.instance.Create(model.childNodes[n], parentNode, point);
                        nodeChildren.Add(node);

                        Line line = LineFactory.instance.Create(parentLine, point);
                        lineChildren.Add(line);
                        isLoop = false;
                    }
                }
                while (isLoop == true);

                /*
                for (int i = 0; i < 360; i++)
                {
                    // 360도 랜덤한 각도로 360번 빈 영역이 있는지 검사한다.
                    float randomAngle = (float)UnityEngine.Random.Range(0, 360);
                    bool hasChild = false;
                    if (model.childNodes[n].childNodes.Count > 0)
                    {
                        hasChild = true;
                    }
                    else
                    {
                        hasChild = false;
                    }
                    Vector2 point = GetChildPoint(randomAngle, hasChild);
                    float radius = view.GetRadius();

                    if (CheckIfEmptySpace(point, radius) == true)
                    {
                        Debug.Log("자식노드를 생성할 영역을 찾음 name = " + model.childNodes[n].name + " point = " + point);

                        Node_Controller node = NodeFactory.instance.Create(model.childNodes[n], parentNode, point);
                        nodeChildren.Add(node);

                        Line line = LineFactory.instance.Create(parentLine, point);
                        lineChildren.Add(line);
                        break;
                    }
                }
                */
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point">worldspace 위치 좌표</param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private bool CheckIfEmptySpace(Vector2 point, float radius)
        {
            Vector3 worldPoint = transform.TransformPoint(new Vector3(point.x, point.y, 0f));
            Debug.Log("worldPoint = " + worldPoint);

            Collider2D[] colliderArray = Physics2D.OverlapCircleAll(new Vector2(worldPoint.x, worldPoint.y), radius);
            if (colliderArray.Length == 0)
            {
                Debug.Log("빈 영역 존재");
                return true;
            }
            else
            {
                Debug.Log("충돌 영역");
                return false;
            }
        }
    }
}