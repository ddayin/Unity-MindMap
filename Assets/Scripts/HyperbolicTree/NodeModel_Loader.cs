using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WanzyeeStudio;

namespace HyperbolicTree
{
    public class NodeModel_Loader : BaseSingleton<NodeModel_Loader>
    {
        public Node_Model CreateDummyData(Node_Model _root)
        {
            _root.id = "0";
            _root.name = "동물";
            _root.depth = 0;
            _root.position = Vector2.zero;
            _root.type = NodeType.Normal;
            _root.imageFileName = "동물";
            _root.description = "animal blah blah";

            Node_Model node_1 = new Node_Model();
            node_1.id = "1";
            node_1.name = "척추동물";
            node_1.depth = 1;
            node_1.position = Vector2.zero;
            node_1.type = NodeType.Normal;
            node_1.imageFileName = "초식동물";
            node_1.description = "초식동물 blah blah";

            Node_Model node_2 = new Node_Model();
            node_2.id = "2";
            node_2.name = "무척추동물";
            node_2.depth = 1;
            node_2.position = Vector2.zero;
            node_2.type = NodeType.Normal;
            node_2.imageFileName = "육식동물";
            node_2.description = "육식동물 blah blah";

            _root.childNodes = new Node_Model[2];
            for (int i = 0; i < 2; i++) {
                _root.childNodes[i] = null;
            }
            _root.childNodes[0] = node_1;
            _root.childNodes[1] = node_2;

            Node_Model node_1_0 = new Node_Model();
            node_1_0.id = "1_0";
            node_1_0.name = "새";
            node_1_0.depth = 2;
            node_1_0.position = Vector2.zero;
            node_1_0.type = NodeType.Normal;
            node_1_0.imageFileName = "새";
            node_1_0.description = "새 blah blah";

            Node_Model node_1_1 = new Node_Model();
            node_1_1.id = "1_1";
            node_1_1.name = "물고기";
            node_1_1.depth = 2;
            node_1_1.position = Vector2.zero;
            node_1_1.type = NodeType.Normal;
            node_1_1.imageFileName = "물고기";
            node_1_1.description = "물고기 blah blah";

            Node_Model node_1_2 = new Node_Model();
            node_1_2.id = "1_2";
            node_1_2.name = "포유동물";
            node_1_2.depth = 2;
            node_1_2.position = Vector2.zero;
            node_1_2.type = NodeType.Normal;
            node_1_2.imageFileName = "포유동물";
            node_1_2.description = "포유동물 blah blah";

            Node_Model node_1_3 = new Node_Model();
            node_1_3.id = "1_3";
            node_1_3.name = "파충류";
            node_1_3.depth = 2;
            node_1_3.position = Vector2.zero;
            node_1_3.type = NodeType.Normal;
            node_1_3.imageFileName = "파충류";
            node_1_3.description = "파충류 blah blah";

            Node_Model node_1_4 = new Node_Model();
            node_1_4.id = "1_4";
            node_1_4.name = "양서류";
            node_1_4.depth = 2;
            node_1_4.position = Vector2.zero;
            node_1_4.type = NodeType.Normal;
            node_1_4.imageFileName = "양서류";
            node_1_4.description = "양서류 blah blah";

            node_1.childNodes = new Node_Model[5];
            for (int i = 0; i < 5; i++) {
                node_1.childNodes[i] = null;
            }
            node_1.childNodes[0] = node_1_0;
            node_1.childNodes[1] = node_1_1;
            node_1.childNodes[2] = node_1_2;
            node_1.childNodes[3] = node_1_3;
            node_1.childNodes[4] = node_1_4;

            Node_Model node_1_2_0 = new Node_Model();
            node_1_2_0.id = "1_2_0";
            node_1_2_0.name = "발굽포유동물";
            node_1_2_0.depth = 3;
            node_1_2_0.position = Vector2.zero;
            node_1_2_0.type = NodeType.Normal;
            node_1_2_0.imageFileName = "발굽포유동물";
            node_1_2_0.description = "발굽포유동물 blah blah";

            Node_Model node_1_2_1 = new Node_Model();
            node_1_2_1.id = "1_2_1";
            node_1_2_1.name = "식충포유동물";
            node_1_2_1.depth = 3;
            node_1_2_1.position = Vector2.zero;
            node_1_2_1.type = NodeType.Normal;
            node_1_2_1.imageFileName = "식충포유동물";
            node_1_2_1.description = "식충포유동물 blah blah";

            Node_Model node_1_2_2 = new Node_Model();
            node_1_2_2.id = "1_2_2";
            node_1_2_2.name = "육식포유동물";
            node_1_2_2.depth = 3;
            node_1_2_2.position = Vector2.zero;
            node_1_2_2.type = NodeType.Normal;
            node_1_2_2.imageFileName = "육식포유동물";
            node_1_2_2.description = "육식포유동물 blah blah";

            Node_Model node_1_2_3 = new Node_Model();
            node_1_2_3.id = "1_2_3";
            node_1_2_3.name = "해양포유동물";
            node_1_2_3.depth = 3;
            node_1_2_3.position = Vector2.zero;
            node_1_2_3.type = NodeType.Normal;
            node_1_2_3.imageFileName = "해양포유동물";
            node_1_2_3.description = "해양포유동물 blah blah";

            Node_Model node_1_2_4 = new Node_Model();
            node_1_2_4.id = "1_2_4";
            node_1_2_4.name = "설치류";
            node_1_2_4.depth = 3;
            node_1_2_4.position = Vector2.zero;
            node_1_2_4.type = NodeType.Normal;
            node_1_2_4.imageFileName = "설치류";
            node_1_2_4.description = "설치류 blah blah";

            Node_Model node_1_2_5 = new Node_Model();
            node_1_2_5.id = "1_2_5";
            node_1_2_5.name = "유대류";
            node_1_2_5.depth = 3;
            node_1_2_5.position = Vector2.zero;
            node_1_2_5.type = NodeType.Normal;
            node_1_2_5.imageFileName = "유대류";
            node_1_2_5.description = "유대류 blah blah";

            node_1_2.childNodes = new Node_Model[6];
            for (int i = 0; i < 6; i++) {
                node_1_2.childNodes[i] = null;
            }
            node_1_2.childNodes[0] = node_1_2_0;
            node_1_2.childNodes[1] = node_1_2_1;
            node_1_2.childNodes[2] = node_1_2_2;
            node_1_2.childNodes[3] = node_1_2_3;
            node_1_2.childNodes[4] = node_1_2_4;
            node_1_2.childNodes[5] = node_1_2_5;

            Node_Model node_1_2_4_0 = new Node_Model();
            node_1_2_4_0.id = "1_2_4_0";
            node_1_2_4_0.name = "들쥐";
            node_1_2_4_0.depth = 4;
            node_1_2_4_0.position = Vector2.zero;
            node_1_2_4_0.type = NodeType.Normal;
            node_1_2_4_0.imageFileName = "들쥐";
            node_1_2_4_0.description = "들쥐 blah blah";

            Node_Model node_1_2_4_1 = new Node_Model();
            node_1_2_4_1.id = "1_2_4_1";
            node_1_2_4_1.name = "줄무늬다람쥐";
            node_1_2_4_1.depth = 4;
            node_1_2_4_1.position = Vector2.zero;
            node_1_2_4_1.type = NodeType.Normal;
            node_1_2_4_1.imageFileName = "줄무늬다람쥐";
            node_1_2_4_1.description = "줄무늬다람쥐 blah blah";

            Node_Model node_1_2_4_2 = new Node_Model();
            node_1_2_4_2.id = "1_2_4_2";
            node_1_2_4_2.name = "햄스터";
            node_1_2_4_2.depth = 4;
            node_1_2_4_2.position = Vector2.zero;
            node_1_2_4_2.type = NodeType.Normal;
            node_1_2_4_2.imageFileName = "햄스터";
            node_1_2_4_2.description = "햄스터 blah blah";

            Node_Model node_1_2_4_3 = new Node_Model();
            node_1_2_4_3.id = "1_2_4_3";
            node_1_2_4_3.name = "다람쥐";
            node_1_2_4_3.depth = 4;
            node_1_2_4_3.position = Vector2.zero;
            node_1_2_4_3.type = NodeType.Normal;
            node_1_2_4_3.imageFileName = "다람쥐";
            node_1_2_4_3.description = "다람쥐 blah blah";

            Node_Model node_1_2_4_4 = new Node_Model();
            node_1_2_4_4.id = "1_2_4_4";
            node_1_2_4_4.name = "쥐";
            node_1_2_4_4.depth = 4;
            node_1_2_4_4.position = Vector2.zero;
            node_1_2_4_4.type = NodeType.Normal;
            node_1_2_4_4.imageFileName = "쥐";
            node_1_2_4_4.description = "쥐 blah blah";

            Node_Model node_1_2_4_5 = new Node_Model();
            node_1_2_4_5.id = "1_2_4_5";
            node_1_2_4_5.name = "기니피그";
            node_1_2_4_5.depth = 4;
            node_1_2_4_5.position = Vector2.zero;
            node_1_2_4_5.type = NodeType.Normal;
            node_1_2_4_5.imageFileName = "기니피그";
            node_1_2_4_5.description = "기니피그 blah blah";

            Node_Model node_1_2_4_6 = new Node_Model();
            node_1_2_4_6.id = "1_2_4_6";
            node_1_2_4_6.name = "비버";
            node_1_2_4_6.depth = 4;
            node_1_2_4_6.position = Vector2.zero;
            node_1_2_4_6.type = NodeType.Normal;
            node_1_2_4_6.imageFileName = "비버";
            node_1_2_4_6.description = "비버 blah blah";

            Node_Model node_1_2_4_7 = new Node_Model();
            node_1_2_4_7.id = "1_2_4_7";
            node_1_2_4_7.name = "호저";
            node_1_2_4_7.depth = 4;
            node_1_2_4_7.position = Vector2.zero;
            node_1_2_4_7.type = NodeType.Normal;
            node_1_2_4_7.imageFileName = "호저";
            node_1_2_4_7.description = "호저 blah blah";

            node_1_2_4.childNodes = new Node_Model[8];
            for (int i = 0; i < 8; i++) {
                node_1_2_4.childNodes[i] = null;
            }
            node_1_2_4.childNodes[0] = node_1_2_4_0;
            node_1_2_4.childNodes[1] = node_1_2_4_1;
            node_1_2_4.childNodes[2] = node_1_2_4_2;
            node_1_2_4.childNodes[3] = node_1_2_4_3;
            node_1_2_4.childNodes[4] = node_1_2_4_4;
            node_1_2_4.childNodes[5] = node_1_2_4_5;
            node_1_2_4.childNodes[6] = node_1_2_4_6;
            node_1_2_4.childNodes[7] = node_1_2_4_7;

            return _root;
        }

        public Node_Model SearchNode(Node_Model[] nodes, string id)
        {
            foreach (Node_Model model in nodes)
            {
                if (model.id == id)
                {
                    return model;
                }
                else
                {
                    Node_Model foundNode = SearchNode(model.childNodes, id);

                    if (foundNode != null)
                    {
                        return foundNode;
                    }
                }
            }

            return null;
        }
    }
}