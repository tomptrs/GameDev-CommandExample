﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestGame.interfaces;

namespace TestGame.Commands
{
    public interface IGameCommand
    {
        void Execute(ITransform transform, Vector2 direction);
        void Undo();
    }
}
