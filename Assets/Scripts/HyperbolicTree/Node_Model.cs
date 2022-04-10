using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperbolicTree {
  public enum NodeType {
    Normal = 0,
    Image,
    ImageAndText
  }

  public class Node_Model {
    public string id;
    public string name;
    public int depth;
    public Vector2 position;
    public NodeType type;
    public string imageFileName;
    public string description;

    public Node_Model[] childNodes = null;
  }
}