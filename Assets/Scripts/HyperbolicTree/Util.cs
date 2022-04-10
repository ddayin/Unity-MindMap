using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperbolicTree {
  public static class Util {
    public static List<Vector2> CalculatePoints(float radius) {
      List<Vector2> linePointsList = new List<Vector2>();

      // 총 8개의 각도 배열로 저장
      float[] anglesArray = new float[] { 0f, 45f, 90f, 135f, 180f, 225f, 270f, 315f };

      foreach (float angle in anglesArray) {
        // 수학 공식 참고 : https://nenara.com/68
        // 높이 = sin( 각도 ) * 빗면
        // 밑변 = cos( 각도 ) * 빗면
        float x = Mathf.Cos(angle * (Mathf.PI / 180f)) * radius;
        float y = Mathf.Sin(angle * (Mathf.PI / 180f)) * radius;

        linePointsList.Add(new Vector2(x, y));
      }

      return linePointsList;
    }
  }
}