using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matematico.ClientSide
{
    public partial class MatematicoButton : Button
    {
        private int x, y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        private int value;
        public int Value {
            get { 
                if(this.value > 13)
                    this.value = 0;
                return this.value; 
            }
            set
            {
                string text = string.Empty;

                if (value > 0 && value <= 13)
                {
                    this.value = value;
                    text = value.ToString();
                }
                else
                {
                    this.value = 0;
                }

                this.Text = text;
            }
        }

   
        public MatematicoButton(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Text = (Value == 0 ? string.Empty : Value.ToString());
        }
    }
}
