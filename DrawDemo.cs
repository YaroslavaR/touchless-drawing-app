//*****************************************************************************************
//  File:       DrawDemo.cs
//  Project:    TouchlessDemo
//  Author(s):  Michael Wasserman (Michael.Wasserman@microsoft.com)
//
//  Demo to draw using n > 0 markers, using the size for the brush size.
//*****************************************************************************************

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using TouchlessLib;

namespace TouchlessDemo
{
    public class DrawDemo : IDisposable
    {
        public DrawDemo(TouchlessMgr tlmgr, Rectangle displayBounds)
        {
            _tlmgr = tlmgr;

            // Initialize the display bounds
            _displayWidth = displayBounds.Width;
            _displayHeight = displayBounds.Height;

            // Initialize the canvas for drawing and its graphics object
            _canvas = new Bitmap(_tlmgr.CurrentCamera.CaptureWidth, _tlmgr.CurrentCamera.CaptureHeight);
            _canvasGFX = Graphics.FromImage(_canvas);
            _canvasGFX.FillRectangle(new SolidBrush(Color.FromArgb(64, 255, 255, 255)), 0, 0, _canvas.Width, _canvas.Height);

            // Initialize the points and pen used for drawing segments
            _pen = new Pen(Color.Black);
            _p1 = new Point();
            _p2 = new Point();

            // Add marker update handling
            foreach (Marker marker in tlmgr.Markers)
                marker.OnChange += new EventHandler<MarkerEventArgs>(updateMarker);
        }

        public void Dispose()
        {
            // Remove marker update handling
            foreach (Marker marker in _tlmgr.Markers)
                marker.OnChange -= new EventHandler<MarkerEventArgs>(updateMarker);
        }

        public void drawCanvas(Graphics gfx)
        {
            // Draw our canvas with all the segments
            gfx.DrawImage(_canvas, 0, 0, _displayWidth, _displayHeight);
        }

        public void updateMarker(object sender, MarkerEventArgs args)
        {
            // Do not draw if the marker's wasn't previously found
            if (!args.EventMarker.PreviousData.Present)
                return;

            // Draw a segment on our canvas between the marker and where it was previously found
            MarkerEventData data = args.EventData;
            _pen.Color = Color.FromArgb( 128, data.ColorAvg.R, data.ColorAvg.G, data.ColorAvg.B);
            _pen.Width = data.Area / 60;
            _p1.X = (data.X - data.DX);
            _p1.Y = (data.Y - data.DY);
            _p2.X = data.X;
            _p2.Y = data.Y;
            _canvasGFX.DrawLine(_pen, _p1, _p2);
        }

        private TouchlessMgr _tlmgr;
        private int _displayWidth, _displayHeight;
        private Bitmap _canvas;
        private Graphics _canvasGFX;
        private Point _p1, _p2;
        private Pen _pen;

        public Bitmap Canvas { get => _canvas; set => _canvas = value; }
        public Graphics CanvasGFX { get => _canvasGFX; set => _canvasGFX = value; }
    }
}
