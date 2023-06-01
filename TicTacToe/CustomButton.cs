using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class CustomButton : Button
    {
        private Color disabledForeColor = Color.White;

        public CustomButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!Enabled)
            {
                using (SolidBrush brush = new SolidBrush(disabledForeColor))
                {
                    e.Graphics.DrawString(Text, Font, brush, ClientRectangle);
                }
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate(); // Forces the control to be repainted
        }
    }
}
