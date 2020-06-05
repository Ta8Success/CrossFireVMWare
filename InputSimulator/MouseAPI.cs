using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputSimulator
{
    public class MouseAPI
    {
        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public class Main
        {
            /// <summary>
            /// Left Click on X and Y Coords for Z Amount of time (without Calculations)
            /// </summary>
            /// <param name="x">X Coord</param>
            /// <param name="y">Y Coord</param>
            /// <param name="time">Time in Int32</param>
            public static void LeftClick(Point point, Int32 time)
            {
                SetCursorPos(point.X, point.Y);
                MouseEvent(MouseEventFlags.LeftDown);
                new System.Threading.ManualResetEvent(false).WaitOne(time);
                MouseEvent(MouseEventFlags.LeftUp);
                new System.Threading.ManualResetEvent(false).WaitOne(time);
            }
            public static void DoubleLeftClick(Point point, int time)
            {
                LeftClick(point, time);
                LeftClick(point, time);
            }
            public static void RLeftClick(Point point)
            {
                Random r = new Random();
                LeftClick(point ,r.Next(33, 66));
            }
            public static void RDoubleLeftClick(Point point)
            {
                RLeftClick(point);
                RLeftClick(point);
            }
        }
        public class Alternative
        {
            /// <summary>
            /// MoveCursor To
            /// </summary>
            /// <param name="x">X Coords</param>
            /// <param name="y">Y Coords</param>
            public static void MoveTo(float x, float y)
            {
                float min = 0;
                float max = 65535;

                int mappedX = (int)Remap(x, 0.0f, Screen.PrimaryScreen.WorkingArea.Width, min, max);
                int mappedY = (int)Remap(y, 0.0f, Screen.PrimaryScreen.WorkingArea.Height, min, max);

                mouse_event((int)MouseEventFlags.Absolute | (int)MouseEventFlags.Move, mappedX, mappedY, 0, 0);
            }
            private static float Remap(float value, float from1, float to1, float from2, float to2)
            {
                return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
            }
            public static void ARDoubleLeftClick(int x, int y)
            {
                ARLeftClick(x, y);
                ARLeftClick(x, y);
            }
            /// <summary>
            /// Random Timed Alternative LeftClick on X and Y Coords (with Calculations)
            /// </summary>
            /// <param name="x">X Coords</param>
            /// <param name="y">Y Coords</param>
            public static void ARLeftClick(int x, int y)
            {
                Random r = new Random();

                MoveTo(x, y);
                MouseEvent(MouseEventFlags.LeftDown);
                new System.Threading.ManualResetEvent(false).WaitOne(r.Next(33, 66));
                MouseEvent(MouseEventFlags.LeftUp);
                new System.Threading.ManualResetEvent(false).WaitOne(r.Next(33, 66));
            }

            /// <summary>
            /// Alternative LeftClick on X and Y Coords waiting Z amount of Time (with Calculations)
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="time"></param>
            public static void ALeftClick(int x, int y, int time)
            {
                Random r = new Random();

                MoveTo(x, y);
                MouseEvent(MouseEventFlags.LeftDown);
                new System.Threading.ManualResetEvent(false).WaitOne(time);
                MouseEvent(MouseEventFlags.LeftUp);
                new System.Threading.ManualResetEvent(false).WaitOne(time);
            }
        }
        /// <summary>
        /// Only Dragging the Mouse to X and Y from Current Pos
        /// </summary>
        /// <param name="x">X Coords</param>
        /// <param name="y">Y Coords</param>
        public class Only
        {
            public static void OMouseDrag(int x, int y)
            {
                mouse_event((int)MouseEventFlags.LeftDown, 0, 0, 0, 0);
                mouse_event((int)MouseEventFlags.Move, x, y, 0, 0);
                mouse_event((int)MouseEventFlags.LeftUp, 0, 0, 0, 0);
            }
            /// <summary>
            /// Only RightClick
            /// </summary>
            public static void ORightClick()
            {
                MouseEvent(MouseEventFlags.RightDown);
                new System.Threading.ManualResetEvent(false).WaitOne(10);
                MouseEvent(MouseEventFlags.RightUp);
                new System.Threading.ManualResetEvent(false).WaitOne(1);
            }
            /// <summary>
            /// Only LeftClick
            /// </summary>
            public static void OLeftClick()
            {
                MouseEvent(MouseEventFlags.LeftDown);
                new System.Threading.ManualResetEvent(false).WaitOne(10);
                MouseEvent(MouseEventFlags.LeftUp);
                new System.Threading.ManualResetEvent(false).WaitOne(1);
            }
        }
        private static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }
        private static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        private static void MouseEvent(MouseEventFlags value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                ((int)value,
                 position.X,
                 position.Y,
                 0,
                 0)
                ;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
