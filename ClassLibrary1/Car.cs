using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public enum EngineState
    {
        engineAlive,
        engineDead
    }
    public abstract class Car
    {
        protected string petName;
        private short currSpeed;
        private short maxSpeed;
        public EngineState egnState = EngineState.engineAlive;

        public abstract void TurboBoost();
        public Car()
        {

        }

        public Car(string petName, short currSpeed, short maxSpeed)
        {
            this.petName = petName;
            this.CurrSpeed = currSpeed;
            this.MaxSpeed = maxSpeed;
        }

        public string PetName
        {
            get
            {
                return petName;
            }
            set
            {
                petName = value;
            }
        }

        public short CurrSpeed
        {
            get
            {
                return currSpeed;
            }

            set
            {
                currSpeed = value;
            }
        }

        public short MaxSpeed
        {
            get
            {
                return maxSpeed;
            }

            set
            {
                maxSpeed = value;
            }
        }

        protected EngineState EgnState
        {
            get
            {
                return egnState;
            }
        }
    }
}
