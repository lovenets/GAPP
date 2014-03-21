﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAPPSF.Core
{
    public partial class Settings
    {
        public string HTMLTargetPath
        {
            get { return GetProperty(""); }
            set { SetProperty(value); }
        }

        public string HTMLSheets
        {
            get { return GetProperty(""); }
            set { SetProperty(value); }
        }
    }
}
