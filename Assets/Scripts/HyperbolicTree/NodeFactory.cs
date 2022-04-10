using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WanzyeeStudio;

namespace HyperbolicTree {
  public class NodeFactory : BaseSingleton<NodeFactory> {
    public GameObject prefabNode;

    public Node_Controller Create(string id, Transform _parent, Vector2 position) {
      Node_Model model = NodeModel_Loader.instance.SearchNode(Diagram.instance.root.childNodes, id);
      if (model == null) {
        Debug.LogError(model);
        return null;
      }

      return Create(model, _parent, position);
    }

    public Node_Controller Create(Node_Model model, Transform _parent, Vector2 position) {
      GameObject newObj = Lean.Pool.LeanPool.Spawn(prefabNode, _parent);
      newObj.name = "UINode_" + model.id + "_" + model.name;
      RectTransform rt = newObj.transform as RectTransform;
      rt.anchoredPosition = position;

      Node_Controller node = rt.GetComponent<Node_Controller>();
      node.Initialize(model);
      return node;
    }
  }
}