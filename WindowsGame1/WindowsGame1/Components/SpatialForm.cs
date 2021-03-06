﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artemis;

namespace StarWarrior.Components
{
    class SpatialForm : Component
    {
        private String spatialFormFile;

        public SpatialForm() { }

        public SpatialForm(String spatialFormFile)
        {
            this.spatialFormFile = spatialFormFile;
        }

        public String SpatialFormFile
        {
            get { return spatialFormFile;}
			set { spatialFormFile = value; }
        }
    }
}
