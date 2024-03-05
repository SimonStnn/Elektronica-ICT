using System;
using System.Collections.Generic;
using System.Text;

namespace LightApp
{
    class RgbLed
    {
        // RgbLed
        // --------------------------
        // - color: Color
        // - isOn: boolean
        // --------------------------
        // + On()
        // + Off()
        // + SetColor(color: Color)
        // + ToString(): string         // return the state of the LED and if needed the color
        // --------------------------

        private Color color;
        private bool isOn;

        public void On()
        {
            isOn = true;
        }

        public void Off()
        {
            isOn = false;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return $"(isOn={isOn}, {color})";
        }
    }
}
