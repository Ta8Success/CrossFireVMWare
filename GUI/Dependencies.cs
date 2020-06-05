using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace GUI
{
    public class Constants
    {
        public class ServerNames
        {
            public const String NA_Alpha = "North America - Alpha";
            public const String NA_Bravo = "North America - Bravo";
            public const String NA_Charlie = "North America - Charlie";
            public const String NA_Delta = "North America - Delta";
            public const String LATAM_N = "LATAM - North";
            public const String LATAM_S = "LATAM - South";
            public const String EU_Alpha = "Europe - Alpha";
            public const String EU_Bravo = "Europe - Bravo";
            public const String EU_Charlie = "Europe - Charlie";
            public const String EU_Delta = "Europe - Delta";
            public const String EU_Foxtrot = "Europe - Foxtrot";
            public const String MENA_Alpha = "MENA - Alpha";
            public const String MENA_Bravo = "MENA - Bravo";
            public const String NA_Clan = "North America - Clan";
            public const String EU_Clan = "Europe - Clan";
        }
    }
    class Dependencies
    {
        public static class LevenshteinDistance
        {
            /// <summary>
            /// Compute the distance between two strings.
            /// </summary>
            private static int Compute(string s, string t)
            {
                int n = s.Length;
                int m = t.Length;
                int[,] d = new int[n + 1, m + 1];

                // Step 1
                if (n == 0)
                {
                    return m;
                }

                if (m == 0)
                {
                    return n;
                }

                // Step 2
                for (int i = 0; i <= n; d[i, 0] = i++)
                {
                }

                for (int j = 0; j <= m; d[0, j] = j++)
                {
                }

                // Step 3
                for (int i = 1; i <= n; i++)
                {
                    //Step 4
                    for (int j = 1; j <= m; j++)
                    {
                        // Step 5
                        int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                        // Step 6
                        d[i, j] = Math.Min(
                            Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                            d[i - 1, j - 1] + cost);
                    }
                }
                // Step 7
                return d[n, m];
            }

            /// <summary>
            /// Calculate percentage similarity of two strings
            /// <param name="source">Source String to Compare with</param>
            /// <param name="target">Targeted String to Compare</param>
            /// <returns>Return Similarity between two strings from 0 to 1.0</returns>
            /// </summary>
            public static double CalculateSimilarity(string source, string target)
            {
                if ((source == null) || (target == null)) return 0.0;
                if ((source.Length == 0) || (target.Length == 0)) return 0.0;
                if (source == target) return 1.0;

                int stepsToSame = LevenshteinDistance.Compute(source, target);
                return (1.0 - ((double)stepsToSame / (double)Math.Max(source.Length, target.Length)));
            }
        }
        public static class ScreenShot
        {
            public static Bitmap CopyScreen(Rectangle rect, bool DebugImg = false)
            {
                Rectangle searchArea = new Rectangle(rect.X, rect.Y, rect.Width - rect.X, rect.Height - rect.Y);
                var screenshot = new Bitmap(searchArea.Width, searchArea.Height, PixelFormat.Format32bppArgb);
                using (var g = Graphics.FromImage(screenshot))
                {
                    try
                    {
                        g.FillRectangle(Brushes.Black, 0, 0, searchArea.Width, searchArea.Height);
                        g.CopyFromScreen(searchArea.Location, Point.Empty, searchArea.Size, CopyPixelOperation.SourceCopy);
                        if (DebugImg == true)
                            screenshot.Save("DEBUG.bmp");
                    }
                    catch { };
                    return screenshot;
                }
            }
        }
    }
}
