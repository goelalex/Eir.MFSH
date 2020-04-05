﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSHpp
{
    public class NodeCode : NodeBase
    {
        public String Code;

        public NodeCode() : base()
        {
        }

        public override String ToFSH()
        {
            return base.ToFSH() + this.Code;
        }
    }
}
