using System.Collections.Generic;
using System.Drawing;
using GeometryTasks;

namespace GeometryPainting
{
    //Напишите здесь код, который заставит работать методы segment.GetColor и segment.SetColor

    static class SegmentExtensions
    {
        public static Color Color;
        public static Dictionary<Segment, Color> DictionaryColor = new Dictionary<Segment, Color>();


        public static void SetColor(this Segment segment, Color segmentColor)
        {
            Color = segmentColor;

            if (!DictionaryColor.ContainsKey(segment))
            {
                DictionaryColor.Add(segment, segmentColor);
            }
            else
            {
                DictionaryColor.Remove(segment);
                DictionaryColor.Add(segment, segmentColor);
            }
        }

        public static Color GetColor(this Segment segment)
        {
            Color color;
            DictionaryColor.TryGetValue(segment, out color);
            return color;
        }
    }
}
