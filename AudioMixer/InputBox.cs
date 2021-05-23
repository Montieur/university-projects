using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blenderv2
{
    public partial class InputBox : Form
    {
        public InputBox(string option)
        {
            InitializeComponent();
            switch (option)
            {
                case "trimStart":
                    LabelTool.Text = "Trim from beginning:";
                    break;
                case "trimEnd":
                    LabelTool.Text = "Trim from end:";
                    break;
                case "delay":
                    LabelTool.Text = "Delay by:";
                    break;
                case "fadeIn":
                    LabelTool.Text = "Fade in for:";
                    break;
                case "loop":
                    LabelTool.Text = "Loop for";
                    break;

                default:
                    break;
            }
        }

    }
}
