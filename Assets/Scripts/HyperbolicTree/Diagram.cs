using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WanzyeeStudio;

namespace HyperbolicTree
{
    public class Diagram : BaseSingleton<Diagram>
    {
        public Node_Model root = new Node_Model();

        public Transform transformParent;

        private void Start()
        {
            root = NodeModel_Loader.instance.CreateDummyData(root);

            CreateTestRoot();
        }
       
        private void CreateTestRoot()
        {
            NodeFactory.instance.Create(root, transformParent, Vector2.zero);
        }
    }
}