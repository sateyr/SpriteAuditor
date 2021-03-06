﻿namespace UnityEngine.UI
{
    public static partial class GraphicExtensions
    {
        public static Vector3? GetPixelSize(this Graphic graphic)
        {
            if (!graphic.isActiveAndEnabled)
                return null;
            
            Canvas componentInParent = graphic.GetComponentInParent<Canvas>();
            if (componentInParent != null)
            {
                RectTransform canvasRectTransform = (RectTransform) componentInParent.transform;
                Bounds bounds = RectTransformUtility.CalculateRelativeRectTransformBounds(canvasRectTransform, graphic.rectTransform);

                return bounds.size;
            }

            return null;
        }
   }
}
