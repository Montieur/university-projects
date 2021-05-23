using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmowiec
{
    public partial class TagsForm : Form
    {
        Video vid;

        public TagsForm(Video vid)
        {
            InitializeComponent();
            this.vid = vid;
        }

        private void TagsForm_Load(object sender, EventArgs e)
        {
            LabelHeight.Text = vid.height.ToString();
            LabelWidth.Text = vid.width.ToString();
            LabelLength.Text = vid.duration.ToString(@"hh\:mm\:ss");
            LabelTitle.Text = vid.title;
            LabelSize.Text = vid.size + "B";
            LabelCodec.Text = vid.codec;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
