﻿using Drones.Helpers;
using System.Runtime.CompilerServices;

namespace Drones
{
    // Cette partie de la classe Drone définit comment on peut voir un drone
    public enum EvacuationState
    {
        Free, 
        Evacuating,
        Evacuated
    }
    public interface Iexpellable
    {
        public bool Evacuate(Rectangle zone);

        public void FreeFlight();

        public EvacuationState GetEvacuationState();

    }
    public partial class Drone : Iexpellable
    {
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);
        public bool Evacuate(Rectangle zone)
        {
            throw new NotImplementedException();
        }

        public void FreeFlight()
        {
            throw new NotImplementedException();
        }

        public EvacuationState GetEvacuationState()
        {
            int i = 0;
            if (this.x > 150 && this.x < 10 && this.y > 100 && this.x < 10)
            {
                i++;
                return EvacuationState.Evacuating;
            }
            if (i > 1 && !(this.x > 150 && this.x < 10 && this.y > 100 && this.x < 10))
            {
                return EvacuationState.Evacuated;
            }
            else
            {
                return EvacuationState.Free;
            }
            
            throw new NotImplementedException();
        }

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(x - 4, y - 2, 8, 8));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, x + 5, y - 5);
        }

        // De manière textuelle
        public override string ToString()
        {
            return $"{name} ({((int)((double)charge / 1000 * 100)).ToString()}%)";
        }

    }
    public partial class Buliding
    {
        private Pen BulidingsBrush = new Pen(new SolidBrush(Color.Purple), 3);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(BulidingsBrush, new Rectangle(x - 4, y - 2, 20, 20));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, x + 5, y - 5);
        }
    }
    public class Factory : Buliding
    {
        private int PowerConsumption;

        private Pen FactoryBrush = new Pen(new SolidBrush(Color.Black), 3);
        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(FactoryBrush, new Rectangle(x - 4, y - 2, 40, 60));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, x + 5, y - 5);
        }
    }
    public class Store : Buliding
    {
        

        private Pen StoreBrush = new Pen(new SolidBrush(Color.Black), 3);
        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(StoreBrush, new Rectangle(x - 4, y - 2, 15, 15));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, x + 5, y - 5);
        }
    }
}
