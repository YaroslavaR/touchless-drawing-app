//*****************************************************************************************
//  File:       DefendDemo.cs
//  Project:    TouchlessDemo
//  Author(s):  Michael Wasserman (Michael.Wasserman@microsoft.com)
//
//  Defend your region of the screen with a marker-controlled paddle
//
//  TODO: Adjust collision reaction (consider paddle motion / angle / etc.)
//  TODO: Use timestepping, currently by framerate (kinda nice, slow when marker not found)
//*****************************************************************************************

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using TouchlessLib;

namespace TouchlessDemo
{
    public class DefendDemo : IDisposable
    {
        public DefendDemo(TouchlessMgr tlmgr, Rectangle displayBounds)
        {
            _tlmgr = tlmgr;

            _captureWidth = tlmgr.CurrentCamera.CaptureWidth;
            _captureHeight = tlmgr.CurrentCamera.CaptureHeight;
            _displayWidth = displayBounds.Width;
            _displayHeight = displayBounds.Height;
            _displayScale = _displayWidth / _captureWidth;
            _backgroundColor = Color.Black;

            _puckBrush = Brushes.WhiteSmoke;
            _puckRadius = 12;
            _rand = new Random();
            _puckPosition = _puckStartPosition = new Point(_displayWidth / 2, _displayHeight / 2);
            _puckVelocity = new Point(_rand.Next(3) + 3, _rand.Next(3) + 3);
            if (_rand.Next(2) == 0)
                _puckVelocity.X *= -1;
            if (_rand.Next(2) == 0)
                _puckVelocity.Y *= -1;
            _lastPlayerToHit = -1;

            // Add marker update handling
            foreach (Marker marker in _tlmgr.Markers)
                marker.OnChange += new EventHandler<MarkerEventArgs>(updateMarker);

            // Add the players
            _players = new List<Player>(2);
            if(_tlmgr.MarkerCount >= 1)
                _players.Add(new Player(_tlmgr.Markers[0], Color.Red, false, new Point(10, 10),
                    new Rectangle(5, 0,_BasePaddle.Width, _BasePaddle.Height),
                    new Rectangle(-50, -50, 52, _displayHeight+100)));
            if (_tlmgr.MarkerCount >= 2)
                _players.Add(new Player(_tlmgr.Markers[1], Color.Blue, false, new Point(_displayWidth - 45, 10),
                    new Rectangle(_displayWidth - 5 - _BasePaddle.Width, 0, _BasePaddle.Width, _BasePaddle.Height),
                    new Rectangle(_displayWidth-2, -50, 52, _displayHeight + 100)));
            if (_tlmgr.MarkerCount >= 3)
                _players.Add(new Player(_tlmgr.Markers[2], Color.Green, true, new Point(10, _displayHeight - 45),
                    new Rectangle(0, _displayHeight - 5 - _BasePaddle.Width, _BasePaddle.Height, _BasePaddle.Width),
                    new Rectangle(-50, _displayHeight - 2, _displayWidth + 100, 52)));
            if (_tlmgr.MarkerCount >= 4)
                _players.Add(new Player(_tlmgr.Markers[3], Color.Wheat, true, new Point(_displayWidth - 45, _displayHeight - 45),
                    new Rectangle(0, 5, _BasePaddle.Height, _BasePaddle.Width),
                    new Rectangle(-50, -50, _displayWidth + 100, 52)));
        }

        public void Dispose()
        {
            // Remove marker update handling
            foreach (Marker marker in _tlmgr.Markers)
                marker.OnChange -= new EventHandler<MarkerEventArgs>(updateMarker);
        }

        public void drawCanvas(Graphics gfx)
        {
            updateGameState();

            gfx.Clear(_backgroundColor);

            // Draw the puck
            gfx.FillEllipse(_puckBrush, _puckPosition.X - _puckRadius, _puckPosition.Y - _puckRadius, _puckRadius * 2, _puckRadius * 2);

            // Draw stuff for each player
            foreach (Player p in _players)
            {
                // Draw the goal area and paddle
                gfx.FillRectangle(p.paddleBrush, p.goalArea);
                gfx.FillRectangle(p.paddleBrush, p.paddleRect);
                // Draw the marker position
                gfx.DrawEllipse(new Pen(p.playerColor, 1), p.markerPos.X - _MarkerPosRadius, p.markerPos.Y - _MarkerPosRadius, _MarkerPosRadius * 2, _MarkerPosRadius * 2);
                // Draw lines connecting the marker and paddle
                if (!p.horizontalPlayer)
                {
                    gfx.DrawLine(new Pen(p.playerColor, 1), p.markerPos.X, p.markerPos.Y - _MarkerPosRadius,
                        p.paddleRect.Left + p.paddleRect.Width / 2, p.paddleRect.Top);
                    gfx.DrawLine(new Pen(p.playerColor, 1), p.markerPos.X, p.markerPos.Y + _MarkerPosRadius,
                        p.paddleRect.Left + p.paddleRect.Width / 2, p.paddleRect.Bottom);
                }
                else
                {
                    gfx.DrawLine(new Pen(p.playerColor, 1), p.markerPos.X - _MarkerPosRadius, p.markerPos.Y,
                        p.paddleRect.Left, p.paddleRect.Top + p.paddleRect.Height / 2);
                    gfx.DrawLine(new Pen(p.playerColor, 1), p.markerPos.X + _MarkerPosRadius, p.markerPos.Y,
                        p.paddleRect.Right, p.paddleRect.Top + p.paddleRect.Height / 2);
                }
                // Draw the player's score
                gfx.DrawString(p.score.ToString(), new Font(FontFamily.GenericSansSerif, 30), p.paddleBrush, p.scorePos);
            }

            // Check for start/reset
            if (_puckPosition.Equals(_puckStartPosition))
            {
                _lastPlayerToHit = -1;
                // Pause on start/reset
                System.Threading.Thread.Sleep(500);
            }
        }

        public void updateMarker(object sender, MarkerEventArgs args)
        {
            // Determine which player owns the updated marker
            for (int i = 0; i < _players.Count; i++)
                if (args.EventMarker == _players[i].marker)
                    _players[i].update(args.EventData.X * _displayScale, args.EventData.Y * _displayScale);
        }

        public void updateGameState()
        {
            _puckPosition.X += _puckVelocity.X;
            _puckPosition.Y += _puckVelocity.Y;

            Rectangle playArea = new Rectangle(0, 0, _displayWidth, _displayHeight);
            if (!playArea.Contains(_puckPosition))
            {
                // Check for goal scored
                for (int i = 0; i < _players.Count; i++)
                    if (_players[i].goalArea.Contains(_puckPosition))
                    {
                        // Increment the score of the last player to hit the puck (don't award a point on first volley missed)
                        if (_lastPlayerToHit != -1)
                            _players[_lastPlayerToHit].score++;

                        // Reset the puck
                        _puckPosition = _puckStartPosition;
                        _puckVelocity = new Point(_rand.Next(3) + 3, _rand.Next(3) + 3);
                        if (_rand.Next(2) == 0)
                            _puckVelocity.X *= -1;
                        if (_rand.Next(2) == 0)
                            _puckVelocity.Y *= -1;
                    }
            }
            else
            {
                // Check for paddle hit and react to collision
                for (int i = 0; i < _players.Count; i++)
                {
                    Player p = _players[i];
                    // Don't collide in a way that reflects the puck into the goal
                    if (p.paddleRect.IntersectsWith(new Rectangle(_puckPosition.X-_puckRadius, _puckPosition.Y-_puckRadius, _puckRadius*2, _puckRadius*2)) &&
                        ( !p.horizontalPlayer && ((p.goalArea.Left - _puckPosition.X > 0 && _puckVelocity.X > 0) || (p.goalArea.Left - _puckPosition.X < 0 && _puckVelocity.X < 0))
                        || p.horizontalPlayer && ((p.goalArea.Top - _puckPosition.Y > 0 && _puckVelocity.Y > 0) || (p.goalArea.Top - _puckPosition.Y < 0 && _puckVelocity.Y < 0))))
                    {
                        if (!p.horizontalPlayer)
                            _puckVelocity.X = -_puckVelocity.X;
                        else
                            _puckVelocity.Y = -_puckVelocity.Y;

                        // Increase the velocity
                        _puckVelocity.X += (_puckVelocity.X < 0) ? -1 : 1;
                        _puckVelocity.Y += (_puckVelocity.Y < 0) ? -1 : 1;

                        _lastPlayerToHit = i;
                    }
                }
            }
            // Check for collisions on the bottom wall (if < 3 players)
            if (_players.Count < 3 && _puckPosition.Y > _displayHeight - _puckRadius && _puckVelocity.Y > 0)
                _puckVelocity.Y *= -1;
            // Check for collisions on the top wall (if < 4 players)
            if (_players.Count < 4 && _puckPosition.Y < _puckRadius && _puckVelocity.Y < 0)
                _puckVelocity.Y *= -1;
        }

        // Drawing and input
        private TouchlessMgr _tlmgr;
        private int _captureWidth, _captureHeight;
        private int _displayWidth, _displayHeight, _displayScale;
        private List<Player> _players;
        private Color _backgroundColor;
        private Rectangle _BasePaddle = new Rectangle(0, 0, 10, 60);
        private const int _MarkerPosRadius = 5;

        // Puck info
        private Brush _puckBrush;
        private Point _puckPosition, _puckStartPosition;
        private Point _puckVelocity;
        private int _puckRadius;
        private Random _rand;
        private const int _MaxVelocity = 10;
        private int _lastPlayerToHit;

        /// <summary>
        /// Structure to represent a player
        /// </summary>
        private class Player
        {
            public Player(Marker m, Color c, bool h, Point s, Rectangle p, Rectangle g)
            {
                marker = m;
                markerPos = new Point();
                playerColor = c;
                paddleBrush = new SolidBrush(playerColor);
                horizontalPlayer = h;
                scorePos = s;
                paddleRect = p;
                goalArea = g;
                score = 0;
            }

            public void update(int x, int y)
            {
                // Update the player's paddle position
                markerPos.X = x;
                markerPos.Y = y;
                if (!horizontalPlayer)
                    paddleRect.Y = y - paddleRect.Height / 2;
                else
                    paddleRect.X = x - paddleRect.Width / 2;
            }

            public Marker marker;
            public Point markerPos;
            public Color playerColor;
            public bool horizontalPlayer;
            public Point scorePos;
            public Brush paddleBrush;
            public Rectangle paddleRect;
            public Rectangle goalArea;
            public int score;
        }
    }
}
