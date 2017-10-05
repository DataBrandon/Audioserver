using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindopdracht
{
    public partial class MediaPlayerForm : Form
    {
        public MediaPlayerForm()
        {
            InitializeComponent();
        }

        public void Start()
        {
            Application.Run(this);
        }
    }
}
