using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public partial class SnakeHead : PictureBox
    {
        //public SnakeHead()
        //{
        //    InitializeComponent();
        //}

        public SnakeHead(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
