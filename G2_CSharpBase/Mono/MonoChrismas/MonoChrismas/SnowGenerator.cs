using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoChrismas
{
    class SnowGenerator
    {
        private Random _random = new Random();
        private float _generateTimer;
        private float _wndGenerateInterval;
        private SnowFlake _snowFlake;
        private List<SnowFlake> _snowFlakes;
        private int _maxSnowFlake = 500;
        private float _generateSpeed = 0.005f;
        private float _windSpeedMax = 1.0f;

        public SnowGenerator(SnowFlake snowFlake)
        {
            _snowFlake = snowFlake;
            _snowFlakes = new List<SnowFlake>();
        }

        private SnowFlake GenerateSnowFlake()
        {
            SnowFlake flake = _snowFlake.Clone();
            float xSpace = _random.Next(0, GameMain.screenWidth);
            float fallingSpeed = _random.Next(10, 100) / 100f;
            flake.position = new Microsoft.Xna.Framework.Vector2(xSpace, -flake.striteHeight);
            flake.opacity = (float)_random.NextDouble();
            flake.rotation = MathHelper.ToRadians(_random.Next(0, 360));
            flake.scale = _random.Next(0, 4);
            flake.velocity = new Vector2(0, fallingSpeed);

            return flake;
        }

        private void AddSnowFlake()
        {
            if (_generateTimer > _generateSpeed)
            {
                _generateTimer = 0;
                if (_snowFlakes.Count < _maxSnowFlake)
                {
                    _snowFlakes.Add(GenerateSnowFlake());
                }
            }
        }

        private void RemoveSnowFlake()
        {
            for (int i = 0; i < _snowFlakes.Count; i++)
            {
                if (_snowFlakes[i].removed)
                {
                    _snowFlakes.RemoveAt(i);
                    i--;
                }
            }
        }

        private void SnowWindSpeed()
        {
            float xSpeed = (float)_random.Next(-3, 3);
            foreach (var i in _snowFlakes)
            {
                i.velocity.X = (xSpeed * _snowFlake.scale) / 100;
            }
        }

        public void Update(GameTime gameTime)
        {
            _generateTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;
            _wndGenerateInterval += (float)gameTime.ElapsedGameTime.TotalSeconds;

            AddSnowFlake();

            if (_wndGenerateInterval > _windSpeedMax)
            {
                _wndGenerateInterval = 0;
                SnowWindSpeed();
            }

            foreach (var i in _snowFlakes)
            {
                i.Update(gameTime);
            }

            RemoveSnowFlake();
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (var i in _snowFlakes)
            {
                i.Draw(gameTime, spriteBatch);
            }
        }

    }
}
